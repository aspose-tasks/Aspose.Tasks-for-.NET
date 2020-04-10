namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExSvgOptions : ApiExampleBase
    {
        [Test]
        public void UseSvgOptions()
        {
            //ExStart:UseSvgOptions
            //ExFor: SvgOptions
            //ExFor: SvgOptions.#ctor
            //ExSummary: Shows how to save project as SVG file.
            var project = new Project(DataDir + "CreateProject2.mpp");
            SaveOptions options = new SvgOptions();
            options.FitContent = true;
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(OutDir + "UseSvgOptions_out.svg", options);
            //ExEnd:UseSvgOptions
        }
    }
}