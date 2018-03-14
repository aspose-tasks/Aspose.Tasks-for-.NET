using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    class ReducingGapBetweenTasksListAndFooter
    {
        public static void Run()
        {
            //ExStart: ReducingGapBetweenTasksListAndFooter
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //Read the MPP file.
            Project project = new Project(dataDir + "CreateProject2.mpp");

            //Use ReduceFooterGap property to reduce the gap between list of tasks and Footer
            var imageSaveOptions =
                new ImageSaveOptions(SaveFileFormat.PNG) { ReduceFooterGap = true, /* set to true */ SaveToSeparateFiles = true, PageSize = PageSize.A0, Timescale = Timescale.Days };
            project.Save(dataDir + "ReducingGapBetweenTasksListAndFooter_out.png", (SaveOptions)imageSaveOptions);

            var pdfSaveOptions = new PdfSaveOptions { ReduceFooterGap = true, /* set to true */ SaveToSeparateFiles = true, PageSize = PageSize.A0, Timescale = Timescale.Days };
            project.Save(dataDir + "ReducingGapBetweenTasksListAndFooter_out.pdf", (SaveOptions)pdfSaveOptions);

            var htmlSaveOptions = new HtmlSaveOptions
            {
                ReduceFooterGap = false, // set to true
                IncludeProjectNameInPageHeader = false,
                IncludeProjectNameInTitle = false,
                PageSize = PageSize.A0,
                Timescale = Timescale.Days
            };
            project.Save(dataDir + "ReducingGapBetweenTasksListAndFooter_out.html", htmlSaveOptions);
            //ExEnd: ReducingGapBetweenTasksListAndFooter
        }
    }
}
