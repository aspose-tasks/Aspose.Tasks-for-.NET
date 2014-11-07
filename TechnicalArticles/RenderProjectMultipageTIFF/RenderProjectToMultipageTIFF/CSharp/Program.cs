//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using Aspose.Tasks.Saving;

namespace RenderProjectToMultipageTIFFExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            
            //Source file to be converted to TIFF
        string file = dataDir+ "RenderMe.mpp";
        Project project = new ProjectReader().Read(file);

        //Save the project to TIFF
        project.Save(dataDir+ "RenderMe.tif", SaveFileFormat.TIFF);

        //Save the project with CCITT4 compression
        ImageSaveOptions options = new ImageSaveOptions(SaveFileFormat.TIFF);
        options.TiffCompression = TiffCompression.Ccitt4;
        project.Save(dataDir+ "RenderMe_options.tif", options);

        //Remove the compression
        options.TiffCompression = TiffCompression.None;
        project.Save(dataDir+ "RenderMe_comp_none.tif", options);

        }
    }
}