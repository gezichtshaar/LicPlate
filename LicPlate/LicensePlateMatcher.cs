using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace LicPlate
{
    public class LicensePlateMatcher
    {
        private class TresHolds
        {
            public static readonly TresHolds H_NORM = new TresHolds(11, 80);
            public static readonly TresHolds S_NORM = new TresHolds(100, 255);
            public static readonly TresHolds V_NORM = new TresHolds(100, 255);

            public static readonly TresHolds H_ONDER = new TresHolds(11, 85);
            public static readonly TresHolds S_ONDER = new TresHolds(20, 160);
            public static readonly TresHolds V_ONDER = new TresHolds(30, 175);

            public static readonly TresHolds H_OVER = new TresHolds(20, 240);
            public static readonly TresHolds S_OVER = new TresHolds(30, 150);
            public static readonly TresHolds V_OVER = new TresHolds(250, 255);

            public static readonly TresHolds BLOBS = new TresHolds(1, 1000);

            public int min { get; set;}
            public int max { get; set; }
            private TresHolds(int min, int max) {
                this.min = min;
                this.max = max;
            }
        }

        private static readonly Regex[] regexes = new Regex[] { new Regex(@"^[a-zA-Z]{2}[\d]{2}[\d]{2}$"),
                                                                new Regex(@"^[\d]{2}[\d]{2}[a-zA-Z]{2}$"),
                                                                new Regex(@"^[\d]{2}[a-zA-Z]{2}[\d]{2}$"),
                                                                new Regex(@"^[a-zA-Z]{2}[\d]{2}[a-zA-Z]{2}$"),
                                                                new Regex(@"^[a-zA-Z]{2}[a-zA-Z]{2}[\d]{2}$"),
                                                                new Regex(@"^[\d]{2}[a-zA-Z]{2}[a-zA-Z]{2}$"),
                                                                new Regex(@"^[\d]{2}[a-zA-Z]{3}[\d]{1}$"),
                                                                new Regex(@"^[\d]{1}[a-zA-Z]{3}[\d]{2}$"),
                                                                new Regex(@"^[a-zA-Z]{2}[\d]{3}[a-zA-Z]{1}$"),
                                                                new Regex(@"^[a-zA-Z]{1}[\d]{3}[a-zA-Z]{2}$"),
                                                                new Regex(@"^[a-zA-Z]{3}[\d]{2}[a-zA-Z]{1}$"),
                                                                new Regex(@"^[a-zA-Z]{1}[\d]{2}[a-zA-Z]{3}$"),
                                                                new Regex(@"^[\d]{1}[a-zA-Z]{2}[\d]{3}$"),
                                                                new Regex(@"^[\d]{3}[a-zA-Z]{2}[\d]{1}$")};
        
        /*
         *  Description:
         *      Find the largest license plate in the image
         *      - Segment using ThresholdHSVchannels
         *      - Remove blobs which are not license plates
         *  Input:
         *      //Original image
         *      RGB888Image plateImage	
         *  Output:
         *      //Segmented license plate
         *      ref Int32Image binaryPlateImage
         *  Return:	
         *      //License plate found?
         *      bool 
         */
        public static bool FindPlate(RGB888Image plateImage, ref Int32Image binaryPlateImage) {
            try {
                //*******************************//
                //** Exercise:                 **//
                //**   adjust licenseplate     **//
                //**   segmentation            **//
                //*******************************//            

                //Find licenseplate

                Func<RGB888Image, TresHolds, Int32Image>[] methods = new Func<RGB888Image, TresHolds, Int32Image>[] {
                    new Func<RGB888Image, TresHolds, Int32Image>((a, b) => FindPlateOnTres(a, b, TresHolds.H_NORM, TresHolds.S_NORM, TresHolds.V_NORM)),
                    new Func<RGB888Image, TresHolds, Int32Image>((a, b) => FindPlateOnTres(a, b, TresHolds.H_ONDER, TresHolds.S_ONDER, TresHolds.V_ONDER)), 
                    new Func<RGB888Image, TresHolds, Int32Image>((a, b) => FindPlateOnTres(a, b, TresHolds.H_OVER, TresHolds.S_OVER, TresHolds.V_OVER)), 
                    FindPlateOnHSV};

                Int32Image binaryImage;

                foreach(var method in methods) {
                    if ((VisionLab.SumIntPixels(binaryImage = method(plateImage, TresHolds.BLOBS)) > 0)) {
                        binaryPlateImage = binaryImage;
                        return true;
                    }
                }
                return false;
            } catch (System.Exception ex) {
                throw new Exception("FindPlate: " + ex.Message);
            }
        }

        private static Int32Image FindPlateOnTres(RGB888Image plateImage, TresHolds blob, TresHolds h, TresHolds s, TresHolds v) {
            Int32Image binaryPlateImage = new Int32Image(plateImage.GetWidth(), plateImage.GetHeight());

            HSV888Image plateImageHSV = new HSV888Image();
            VisionLab.FastRGBToHSV(plateImage, plateImageHSV);
            VisionLab.Threshold3Channels(plateImageHSV, binaryPlateImage, h.min, h.max, s.min, s.max, v.min, v.max);
            removeBlobs(binaryPlateImage, plateImageHSV, blob.min, blob.max);
            return binaryPlateImage;
        }

        private static Int32Image FindPlateOnHSV(RGB888Image plateImage, TresHolds blob) {
            HSV888Image plateImageHSV = new HSV888Image();
            VisionLab.FastRGBToHSV(plateImage, plateImageHSV);

            Int32Image h = new Int32Image();
            Int32Image s = new Int32Image();
            Int32Image v = new Int32Image();

            VisionLab.Extract1Channel(plateImageHSV, HSVColor.Hue, h);
            VisionLab.Extract1Channel(plateImageHSV, HSVColor.Saturation, s);
            VisionLab.Threshold(h, 18, 55);
            VisionLab.Threshold(s, 140, 230);
            VisionLab.Add(h, s);
            removeBlobs(h, plateImageHSV, blob.min, blob.max);
            plateImageHSV.Dispose();
            return h;
        }

        private static void removeBlobs(Int32Image binaryPlateImage, HSV888Image plateImageHSV, int c_remove_blobs_min, int c_remove_blobs_max) {
            //Remove blobs with small areas
            VisionLab.RemoveBlobs(binaryPlateImage, Connected.EightConnected, BlobAnalyse.BA_Area, c_remove_blobs_min, c_remove_blobs_max);
            VisionLab.RemoveBorderBlobs(binaryPlateImage, Connected.EightConnected, Border.AllBorders);
            VisionLab.RemoveBlobs(binaryPlateImage, Connected.EightConnected, BlobAnalyse.BA_LengthBreadthRatio, 0, 2.5);

            //VisionLab.RemoveBlobs(binaryPlateImage, Connected.EightConnected, BlobAnalyse.BA_NrOfHoles, 0, 5);
            //Fill up characters
            VisionLab.FillHoles(binaryPlateImage, Connected.FourConnected);
        }

        /* 
         *  Description:
         *      Locates the characters of the license plate
         *      - Warp image (Rectify)
         *      - Segment characters
         *      - Remove blobs which are to small (Lines between characters)
         *  Input:
         *      //Original image
         *      RGB888Image plateImage
         *      //Segmented license plate
         *      Int32Image binaryPlateImage
         *      Output:
         *      //Image containing binary six characters	
         *      ref Int32Image binaryCharacterImage 
         *  Return:
         *      //Function executed successfully
         *      bool
         */
        public static bool FindCharacters(RGB888Image plateImage, Int32Image binaryPlateImage, ref Int32Image binaryCharacterImage) {
            try {
                //Constants
                const int c_height = 100;
                const int c_width = 470;
                const int c_remove_blobs_min = 1;
                const int c_remove_blobs_max = 400;

                XYCoord leftTop = new XYCoord();
                XYCoord rightTop = new XYCoord();
                XYCoord leftBottom = new XYCoord();
                XYCoord rightBottom = new XYCoord();

                XYCoord leftTopr = new XYCoord();
                XYCoord rightTopr = new XYCoord();
                XYCoord leftBottomr = new XYCoord();
                XYCoord rightBottomr = new XYCoord();


                //Find licenseplate
                VisionLab.FindCornersRectangle(binaryPlateImage, Connected.EightConnected, 0.5, Orientation.Landscape, leftTop, rightTop, leftBottom, rightBottom);
                //VisionLab.FindCornersRectangleSq(binaryPlateImage, Connected.EightConnected, leftTopr, rightTopr, leftBottomr, rightBottomr);

                Int32Image plateImageGray = new Int32Image();
                VisionLab.Convert(plateImage, plateImageGray);


                try {
                    //Rectify plate
                    VisionLab.Warp(plateImageGray, binaryCharacterImage, TransformDirection.ForwardT, new Coord2D(leftTop), new Coord2D(rightTop), new Coord2D(leftBottom), new Coord2D(rightBottom), c_height, c_width, 0);
                } catch (Exception) {
                    //Warp, 3 coords on one line
                    return false;
                }

                plateImageGray.Dispose();

                //*******************************//
                //** Exercise:                 **//
                //**   adjust licenseplate     **//
                //**   segmentation            **//
                //*******************************//

                //Find dark text on bright licenseplate using ThresholdISOData
                VisionLab.ThresholdIsoData(binaryCharacterImage, ObjectBrightness.DarkObject);

                //Remove small blobs and noise
                Int32Image binaryCharacterImageCopy = new Int32Image(binaryCharacterImage);
                VisionLab.Opening(binaryCharacterImageCopy, binaryCharacterImage, new Mask_Int32(5, 1, 1));

                //Remove blobs connected to the border
                VisionLab.RemoveBorderBlobs(binaryCharacterImage, Connected.EightConnected, Border.AllBorders);
                //Remove small blobs
                VisionLab.RemoveBlobs(binaryCharacterImage, Connected.EightConnected, BlobAnalyse.BA_Area, c_remove_blobs_min, c_remove_blobs_max);


                // binaryCharacterImage.WriteToFile("c:/temp/plate.jl");

                //if (VisionLab.LabelBlobs(binaryCharacterImage, Connected.EightConnected) != 6)
                //{

                //    // Find licenseplate
                //    VisionLab.FindCornersRectangle(binaryPlateImage, Connected.EightConnected, 0.5, Orientation.Landscape, leftTop, rightTop, leftBottom, rightBottom);

                //    HSV888Image plateImageHSV = new HSV888Image();
                //    HSV888Image warpplateImageHSV = new HSV888Image();
                //    VisionLab.Convert(plateImage, plateImageHSV);
                //    Int32Image h = new Int32Image();
                //    Int32Image s = new Int32Image();
                //    Int32Image v = new Int32Image();


                //    try
                //    {
                //        //Rectify plate
                //        VisionLab.Warp(plateImageHSV, warpplateImageHSV, TransformDirection.ForwardT, new Coord2D(leftTop), new Coord2D(rightTop), new Coord2D(leftBottom), new Coord2D(rightBottom), c_height, c_width, new HSV888Pixel());
                //    }
                //    catch (Exception)
                //    {
                //        //Warp, 3 coords on one line
                //        return false;
                //    }
                //    try
                //    {
                //        //Rectify plate
                //        VisionLab.Warp(plateImageHSV, warpplateImageHSV, TransformDirection.ForwardT, new Coord2D(leftTopr), new Coord2D(rightTopr), new Coord2D(leftBottomr), new Coord2D(rightBottomr), c_height, c_width, new HSV888Pixel());
                //    }
                //    catch (Exception)
                //    {
                //        //Warp, 3 coords on one line
                //        return false;
                //    }
                //    plateImageGray.Dispose();

                //    //*******************************//
                //    //** Exercise:                 **//
                //    //**   adjust licenseplate     **//
                //    //**   segmentation            **//
                //    //*******************************//

                //    //Find dark text on bright licenseplate using ThresholdISOData
                //    VisionLab.Extract1Channel(plateImageHSV, HSVColor.Hue, h);
                //    VisionLab.Extract1Channel(plateImageHSV, HSVColor.Saturation, s);
                //    VisionLab.Threshold(h, 15, 55);
                //    VisionLab.Threshold(s, 15, 230);
                //    VisionLab.Add(h, s);
                //    binaryCharacterImage = h;
                //    Console.WriteLine("testiez");
                //    //Remove small blobs and noise
                //    Int32Image bbinaryCharacterImageCopy = new Int32Image(binaryCharacterImage);
                //    VisionLab.Opening(bbinaryCharacterImageCopy, binaryCharacterImage, new Mask_Int32(5, 1, 1));

                //    //Remove blobs connected to the border
                //    VisionLab.RemoveBorderBlobs(binaryCharacterImage, Connected.EightConnected, Border.AllBorders);
                //    //Remove small blobs
                //    VisionLab.RemoveBlobs(binaryCharacterImage, Connected.EightConnected, BlobAnalyse.BA_Area, c_remove_blobs_min, c_remove_blobs_max);

                //    //leftTop.Dispose();
                //    //rightTop.Dispose();
                //    //leftBottom.Dispose();
                //    //rightBottom.Dispose();
                //    // binaryCharacterImage.WriteToFile("c:/temp/plate.jl");
                // }
                leftTop.Dispose();
                rightTop.Dispose();
                leftBottom.Dispose();
                rightBottom.Dispose();
                leftTopr.Dispose();
                rightTopr.Dispose();
                leftBottomr.Dispose();
                rightBottomr.Dispose();

                return true;
            } catch (System.Exception ex) {
                throw new Exception("FindCharacters: " + ex.Message);
            }
        }

        /*
         *  Description:
         *      Read the license plate
         *  Input:
         *      //Rectified license plate image containing six characters	
         *      Int32Image labeledRectifiedPlateImage
         *  Output:
         *      //Result by the blob matcher
         *      ref LicensePlate result
         *  Return:
         *      //six characters found
         *      bool 
        */
        public static bool MatchPlate(Int32Image binaryCharacterImage, BlobMatcher_Int32 matcher, ClassLexicon lexicon, ref LicensePlate result, ref LicensePlate lexiconResult) {
            try {
                //Check if 6 characters/blobs have been found and label image.
                if (VisionLab.LabelBlobs(binaryCharacterImage, Connected.EightConnected) != 6)
                    return false;

                //Calculate dimensions and locations of all characters/blobs.
                vector_BlobAnalyse ba_vec = new vector_BlobAnalyse();
                ba_vec.Add(BlobAnalyse.BA_TopLeft);
                ba_vec.Add(BlobAnalyse.BA_Height);
                ba_vec.Add(BlobAnalyse.BA_Width);
                vector_Blob returnBlobs = new vector_Blob();
                VisionLab.BlobAnalysis(binaryCharacterImage, VisionLab.VectorToSet_BlobAnalyse(ba_vec), VisionLab.MaxPixel(binaryCharacterImage), returnBlobs, SortOrder.SortDown, BlobAnalyse.BA_TopLeft, UseXOrY.UseX);
                ba_vec.Dispose();
                Int32Image binaryCharacter = new Int32Image();

                //Create data structure for lexicon.
                vector_vector_LetterMatch match = new vector_vector_LetterMatch();

                int n = 0;
                LicensePlate licenzPlate;
                List<Tuple<float, int>> bestErr = new List<Tuple<float,int>>();
                do {
                    licenzPlate = new LicensePlate();
                    bestErr.Add(new Tuple<float, int>(10f, 0));
                    //Process each character/blob.
                    for (int y = 0; y < returnBlobs.Count; y++) {
                        Blob b = returnBlobs[y];
                        //Cut out character
                        VisionLab.ROI(binaryCharacterImage, binaryCharacter, b.TopLeft(), new HeightWidth(b.Height(), b.Width()));
                        //Convert ROI result to binary
                        VisionLab.ClipPixelValue(binaryCharacter, 0, 1);

                        int z = bestErr.Count > 1 && bestErr[bestErr.Count - 2].Item2 == y ? 1 : 0;
                        Console.WriteLine("{0} {1} {2}", n, y, z);
                        //Calculate character's classification for all classes.
                        vector_PatternMatchResult returnMatches = new vector_PatternMatchResult();
                        float conf = matcher.AllMatches(binaryCharacter, (float)-0.5, (float)0.5, returnMatches);
                        float err = returnMatches[z].error;
                        int id = returnMatches[z].id;
                        string chr = matcher.PatternName(id);

                        if (err - returnMatches[1].error < bestErr[bestErr.Count - 1].Item1) {
                            bestErr[bestErr.Count - 1] = new Tuple<float, int>(err, y);
                            Console.WriteLine(bestErr[bestErr.Count - 1]);
                        }

                        //Fill datastructure for lexicon.
                        match.Add(VisionLabEx.PatternMatchResultToLetterMatch(returnMatches));

                        //Store best match in result
                        licenzPlate.characters.Add(new LicenseCharacter(chr, err, conf));
                    }
                    Console.WriteLine("{0} {1}", licenzPlate.getLicensePlateString(), testNummerbord(licenzPlate.getLicensePlateString()));
                } while(n++ < 3 && !testNummerbord(licenzPlate.getLicensePlateString())); //regex match

                result = licenzPlate;

                //Validate match with lexicon.
                vector_int bestWord = new vector_int();
                lexiconResult.confidence = lexicon.FindBestWord(match, bestWord, Optimize.OptimizeForMinimum);
                for (int i = 0; i < bestWord.Count; i++) {
                    string character = matcher.PatternName(bestWord[i]);
                    //Store lexicon result
                    lexiconResult.characters.Add(new LicenseCharacter(character));
                }

                binaryCharacter.Dispose();
                returnBlobs.Dispose();
                match.Dispose();
                bestWord.Dispose();
                return testNummerbord(result.getLicensePlateString()); // return regex match
            } catch (System.Exception ex) {
                throw new Exception("MatchPlate: " + ex.Message);
            }
        }

        private static bool testNummerbord(String nummerbord) {
            foreach (Regex regex in regexes) {
                if (regex.IsMatch(nummerbord)) {
                    return true;
                }
            }
            return false;
        }
    }
}

