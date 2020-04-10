namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExXamlOptions : ApiExampleBase
    {
        [Test]
        public void RenderXAMLWithOptions()
        {
            //ExStart:RenderXAMLWithOptions
            //ExFor: XamlOptions
            //ExFor: XamlOptions.#ctor
            //ExSummary: Shows how to save a project in XAML format by using save options.
            var project = new Project(DataDir + "Project2.mpp");
            SaveOptions options = new XamlOptions();
            options.FitContent = true;
            options.LegendOnEachPage = false;
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(OutDir + "RenderXAMLWithOptions_out.xaml", options);
            //ExEnd:RenderXAMLWithOptions
        }
    }
}