using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.Articles
{
    class TimescaleSettings
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:TimescaleSettings
            Project project = new Project("Project2.mpp");

            // Save to one page image (Timescale.days by default)
            project.Save("NewProductDevDays.jpeg", new ImageSaveOptions(SaveFileFormat.JPEG));


            // Save to one page image (Timescale.ThirdsOfMonths)
            ImageSaveOptions options = new ImageSaveOptions(SaveFileFormat.JPEG);
            options.Timescale = Timescale.ThirdsOfMonths;

            project.Save("NewProductDevThirdsOfMonths.jpeg", options);

            // Save to one page image (Timescale.Months)
            options.Timescale = Timescale.Months;
            project.Save("NewProductDevMonths.jpeg", options);
            // ExEnd:TimescaleSettings
        }
    }
}
