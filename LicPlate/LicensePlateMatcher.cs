using System;

namespace LicPlate
{
    public class LicensePlateMatcher
    {
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
        public static bool FindPlate(RGB888Image plateImage, ref Int32Image binaryPlateImage)
        {
            try
            {
                //Constants
                const int c_threshold_h_min = 11;
                const int c_threshold_h_max = 80;
                const int c_threshold_s_min = 100;
                const int c_threshold_s_max = 255;
                const int c_threshold_v_min = 100;
                const int c_threshold_v_max = 255;
                const int c_remove_blobs_min = 1;
                const int c_remove_blobs_max = 1000;

                const int c_threshold_h_mino = 11;
                const int c_threshold_h_maxo = 85;
                const int c_threshold_s_mino = 20;
                const int c_threshold_s_maxo = 160;
                const int c_threshold_v_mino = 30;
                const int c_threshold_v_maxo= 175;

                const int c_threshold_h_minov = 20;
                const int c_threshold_h_maxov = 240;
                const int c_threshold_s_minov = 30;
                const int c_threshold_s_maxov = 150;
                const int c_threshold_v_minov = 250;
                const int c_threshold_v_maxov = 255;


                //*******************************//
                //** Exercise:                 **//
                //**   adjust licenseplate     **//
                //**   segmentation            **//
                //*******************************//            

                //Find licenseplate
                HSV888Image plateImageHSV = new HSV888Image();
                Int32Image h = new Int32Image();
                Int32Image s = new Int32Image();
                Int32Image v = new Int32Image();
                //Convert to RGB to HSV
                VisionLab.FastRGBToHSV(plateImage, plateImageHSV);
                Int32Image binaryPlateImageCopy = new Int32Image(binaryPlateImage);
                Int32Image binaryPlateImageCopy2 = new Int32Image(binaryPlateImage);
                Int32Image binaryPlateImageCopy3 = new Int32Image(binaryPlateImage);
                

                //Threshold HSV image
                VisionLab.Threshold3Channels(plateImageHSV, binaryPlateImage, c_threshold_h_min, c_threshold_h_max, c_threshold_s_min, c_threshold_s_max, c_threshold_v_min, c_threshold_v_max);
                //Return true, if pixels found
                //Remove blobs with small areas
                VisionLab.RemoveBlobs(binaryPlateImage, Connected.EightConnected, BlobAnalyse.BA_Area, c_remove_blobs_min, c_remove_blobs_max);

                VisionLab.RemoveBorderBlobs(binaryPlateImage, Connected.EightConnected, Border.AllBorders);

                VisionLab.RemoveBlobs(binaryPlateImage, Connected.EightConnected, BlobAnalyse.BA_LengthBreadthRatio, 0, 2.5);
                

                //VisionLab.RemoveBlobs(binaryPlateImage, Connected.EightConnected, BlobAnalyse.BA_NrOfHoles, 0, 5);
                //Fill up characters
                VisionLab.FillHoles(binaryPlateImage, Connected.FourConnected);

                plateImageHSV.Dispose();
                return (VisionLab.SumIntPixels(binaryPlateImage) > 0);

                //if (VisionLab.SumIntPixels(binaryPlateImage) == 0)
                //{
                //    VisionLab.Threshold3Channels(plateImageHSV, binaryPlateImageCopy, c_threshold_h_mino, c_threshold_h_maxo, c_threshold_s_mino, c_threshold_s_maxo, c_threshold_v_mino, c_threshold_v_maxo);
                //    return(removeBlobs(binaryPlateImageCopy, plateImageHSV, c_remove_blobs_min, c_remove_blobs_max));

                //}
                //if (VisionLab.SumIntPixels(binaryPlateImageCopy) == 0)
                //{
                //    VisionLab.Threshold3Channels(plateImageHSV, binaryPlateImageCopy2, c_threshold_h_minov, c_threshold_h_maxov, c_threshold_s_minov, c_threshold_s_maxov, c_threshold_v_minov, c_threshold_v_maxov);
                //    return (removeBlobs(binaryPlateImageCopy2, plateImageHSV, c_remove_blobs_min, c_remove_blobs_max));

                //}

                //if (VisionLab.SumIntPixels(binaryPlateImageCopy2) == 0)
                //{
                //    VisionLab.Extract1Channel(plateImageHSV, HSVColor.Hue, h);
                //    VisionLab.Extract1Channel(plateImageHSV, HSVColor.Saturation, s);
                //    VisionLab.Threshold(h, 18, 55);
                //    VisionLab.Threshold(s, 140, 230);
                //    VisionLab.Add(h, s);
                //    binaryPlateImage = h;
                //    removeBlobs(binaryPlateImageCopy3, plateImageHSV, c_remove_blobs_min, c_remove_blobs_max);

                //}
                
                
            }
            catch (System.Exception ex)
            {
                throw new Exception("FindPlate: " + ex.Message);
            }
        }


        public static bool removeBlobs( Int32Image binaryPlateImage,  HSV888Image plateImageHSV,int c_remove_blobs_min, int c_remove_blobs_max) 
        {
            //Remove blobs with small areas
            VisionLab.RemoveBlobs(binaryPlateImage, Connected.EightConnected, BlobAnalyse.BA_Area, c_remove_blobs_min, c_remove_blobs_max);

            VisionLab.RemoveBorderBlobs(binaryPlateImage, Connected.EightConnected, Border.AllBorders);

            VisionLab.RemoveBlobs(binaryPlateImage, Connected.EightConnected, BlobAnalyse.BA_LengthBreadthRatio, 0, 2.5);
            

            //VisionLab.RemoveBlobs(binaryPlateImage, Connected.EightConnected, BlobAnalyse.BA_NrOfHoles, 0, 5);
            //Fill up characters
            VisionLab.FillHoles(binaryPlateImage, Connected.FourConnected);

            //plateImageHSV.Dispose();
            return (VisionLab.SumIntPixels(binaryPlateImage) > 0);
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
        public static bool FindCharacters(RGB888Image plateImage, Int32Image binaryPlateImage, ref Int32Image binaryCharacterImage)
        {
            try
            {
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
                VisionLab.FindCornersRectangleSq(binaryPlateImage,Connected.EightConnected,leftTopr,rightTopr,leftBottomr, rightBottomr);

                Int32Image plateImageGray = new Int32Image();
                VisionLab.Convert(plateImage, plateImageGray);


                try
                {
                    //Rectify plate
                    VisionLab.Warp(plateImageGray, binaryCharacterImage, TransformDirection.ForwardT, new Coord2D(leftTop), new Coord2D(rightTop), new Coord2D(leftBottom), new Coord2D(rightBottom), c_height, c_width, 0);
                }
                catch (Exception)
                {
                    //Warp, 3 coords on one line
                    return false;
                }
                //try
                //{
                //        //Rectify plate
                //    VisionLab.Warp(plateImageGray, binaryCharacterImage, TransformDirection.ForwardT, new Coord2D(leftTopr), new Coord2D(rightTopr), new Coord2D(leftBottomr), new Coord2D(rightBottomr), c_height, c_width, 0);
                //}
                //catch (Exception)
                //{ 
                //    return false; 
                //}
                 
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
            }
            catch (System.Exception ex)
            {
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
        public static bool MatchPlate(Int32Image binaryCharacterImage, BlobMatcher_Int32 matcher, ClassLexicon lexicon, ref LicensePlate result, ref LicensePlate lexiconResult)        
        {            
            try
            {
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

                //Process each character/blob.
                foreach (Blob b in returnBlobs)
                {
                    //Cut out character
                    VisionLab.ROI(binaryCharacterImage, binaryCharacter, b.TopLeft(), new HeightWidth(b.Height(), b.Width()));
                    //Convert ROI result to binary
                    VisionLab.ClipPixelValue(binaryCharacter, 0, 1);
                    
                    //Calculate character's classification for all classes.
                    vector_PatternMatchResult returnMatches = new vector_PatternMatchResult();
                    float conf = matcher.AllMatches(binaryCharacter, (float)-0.5, (float)0.5, returnMatches);
                    float err = returnMatches[0].error;
                    int id = returnMatches[0].id;
                    string chr = matcher.PatternName(id);

                    //Fill datastructure for lexicon.
                    match.Add(VisionLabEx.PatternMatchResultToLetterMatch(returnMatches));

                    //Store best match in result
                    result.characters.Add(new LicenseCharacter(chr, err, conf));
                }

                //Validate match with lexicon.
                vector_int bestWord = new vector_int();
                lexiconResult.confidence = lexicon.FindBestWord(match, bestWord, Optimize.OptimizeForMinimum);
                for (int i = 0; i < bestWord.Count; i++)
                {
                    string character = matcher.PatternName(bestWord[i]);
                    //Store lexicon result
                    lexiconResult.characters.Add(new LicenseCharacter(character));
                }

                binaryCharacter.Dispose();
                returnBlobs.Dispose();
                match.Dispose();
                bestWord.Dispose();
                return true;
            }
            catch (System.Exception ex)
            {
                throw new Exception("MatchPlate: " + ex.Message);
            }
        }
    }
}

