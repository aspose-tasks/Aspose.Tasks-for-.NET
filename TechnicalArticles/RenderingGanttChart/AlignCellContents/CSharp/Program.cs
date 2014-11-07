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
using Aspose.Tasks.Saving;
using System.Drawing;

namespace AlignCellContentsExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            Project project = new Project(dataDir+ "RenderMe.mpp"); // attached test project
            SaveOptions options = new PdfSaveOptions();
            options.Timescale = Timescale.Months;
            options.View = ProjectView.GetDefaultGanttChartView();

            GanttChartColumn col = options.View.Columns[2] as GanttChartColumn;
            col.StringAlignment = StringAlignment.Center;
            col = options.View.Columns[3] as GanttChartColumn;
            col.StringAlignment = StringAlignment.Far;
            col = options.View.Columns[4] as GanttChartColumn;
            col.StringAlignment = StringAlignment.Far;

            project.Save(dataDir+ "result GanttChart.pdf", options);

            options.PresentationFormat = PresentationFormat.ResourceSheet;

            ResourceViewColumn col1 = options.View.Columns[2] as ResourceViewColumn;
            col1.StringAlignment = StringAlignment.Center;
            col1 = options.View.Columns[3] as ResourceViewColumn;
            col1.StringAlignment = StringAlignment.Far;
            col1 = options.View.Columns[4] as ResourceViewColumn;
            col1.StringAlignment = StringAlignment.Far;

            project.Save(dataDir+ "result ResourceSheet.pdf", options);
            
        }
    }
}