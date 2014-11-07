//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using Aspose.Tasks.Visualization;
using System;
using Aspose.Tasks.Saving;

namespace RenderingProjectDataExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Source File to Render
            string file = dataDir+ "RenderMe.mpp";

            ProjectReader reader = new ProjectReader();

            //Read the Project
            Project project = reader.Read(file);

            //Select a Presentation format - Any other can be selected as well
            PresentationFormat format = PresentationFormat.GanttChart;

            //Render the project to all Pre-Defined page sizes
            foreach (PageSize pageSize in (PageSize[])Enum.GetValues(typeof(PageSize)))
            {
                PdfSaveOptions options = new PdfSaveOptions();
                options.PresentationFormat = format;
                options.FitContent = true;
                options.PageSize = pageSize;
                string resFile = dataDir+ "result_" + format.ToString() + "_" + pageSize.ToString() + ".pdf";
                project.Save(resFile, options);
            }
            
            
        }
    }
}