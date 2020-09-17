namespace Aspose.Tasks.Examples.CSharp.SavingOptions
{
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExSvgOptions : ApiExampleBase
    {
        [Test]
        public void WorkWithSvgOptions()
        {
            // ExStart:UseSvgOptions
            // ExFor: SvgOptions
            // ExFor: SvgOptions.#ctor
            // ExFor: SvgOptions.UseGradientBrush
            // ExFor: Timescale
            // ExSummary: Shows how to save project as SVG file.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");
            SaveOptions options = new SvgOptions
                                    {
                                        // set the <see cref="P:Aspose.Tasks.Saving.SaveOptions.PresentationFormat" /> in which the document will be saved
                                        PresentationFormat = PresentationFormat.GanttChart,
                                        
                                        // set a value indicating whether row height should be increased to fit its content
                                        FitContent = true,
                                        
                                        // set the minimal time period to render. The default value is <see cref="P:Aspose.Tasks.Saving.SaveOptions.Timescale">Days</see>
                                        Timescale = Timescale.ThirdsOfMonths,

                                        // determines whether to use gradient brush when rendering project layout
                                        // Currently using of gradient brush is not supported for rendering to SVG.
                                        // UseGradientBrush = true
                                    };
            project.Save(OutDir + "UseSvgOptions_out.svg", options);

            // ExEnd:UseSvgOptions
        }
    }
}