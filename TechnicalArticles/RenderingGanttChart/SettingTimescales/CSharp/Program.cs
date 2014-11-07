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
using Aspose.Tasks.Visualization;
using System.Drawing;

namespace SettingTimescalesExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            Project project = new ProjectReader().Read(dataDir+ "NewProductDev.mpp");

            // Save to one page image (Timescale.days by default)
            project.Save(dataDir+ "NewProductDevDays.jpeg", new ImageSaveOptions(SaveFileFormat.JPEG));


            // Save to one page image (Timescale.ThirdsOfMonths)
            ImageSaveOptions options = new ImageSaveOptions(SaveFileFormat.JPEG);
            options.Timescale = Timescale.ThirdsOfMonths;

            project.Save(dataDir+ "NewProductDevThirdsOfMonths.jpeg", options);

            // Save to one page image (Timescale.Months)
            options.Timescale = Timescale.Months;
            project.Save(dataDir+ "NewProductDevMonths.jpeg", options);

            // There is IRender property for compliance with Project.Export interface
            options.RenderParam = new BaseImageRenderParam(null, Point.Empty, new Size(800, 600), 100, 0, true);

            project.Save(dataDir+ "NewProductDevRenderOptions.jpeg", options);

            
            
        }
    }
}