namespace Aspose.Tasks.Examples.CSharp.Articles
{
    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    internal class TimescaleSettings
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:TimescaleSettings
            //ExFor: SaveOptions.Timescale
            //ExSummary: Shows how to set the minimal time period to render. The default value is <see cref="P:Aspose.Tasks.Saving.SaveOptions.Timescale">Days</see>.
            var project = new Project(dataDir + "Project2.mpp");

            // Save to one page image (Timescale.days by default)
            project.Save(dataDir + "NewProductDevDays_out.jpeg", new ImageSaveOptions(SaveFileFormat.JPEG));

            // Save to one page image (Timescale.ThirdsOfMonths)
            var options = new ImageSaveOptions(SaveFileFormat.JPEG);
            options.Timescale = Timescale.ThirdsOfMonths;

            project.Save(dataDir + "NewProductDevThirdsOfMonths_out.jpeg", options);

            // Save to one page image (Timescale.Months)
            options.Timescale = Timescale.Months;
            project.Save(dataDir + "NewProductDevMonths_out.jpeg", options);
            //ExEnd:TimescaleSettings
        }
    }
}
