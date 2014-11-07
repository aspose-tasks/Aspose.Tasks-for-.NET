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

namespace RollingUpGanttChartBarsExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            PdfSaveOptions options = new PdfSaveOptions();
            options.PresentationFormat = PresentationFormat.GanttChart;
            options.FitContent = true;
            options.RollUpGanttBars = true;
            options.DrawNonWorkingTime = true;
            options.PageSize = PageSize.A3;
            string file = dataDir+ "project.mpp";
            string resFile = dataDir+ "output.pdf";
            Project project = new Project(file);
            for (int i = 14; i <= 23; i++)
                project.GetTaskById(i).HideBar = false;
            project.Save(resFile, options);
            
        }
    }
}