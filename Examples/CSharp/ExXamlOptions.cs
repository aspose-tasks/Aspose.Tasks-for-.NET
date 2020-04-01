namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;
    using Saving;
    using Visualization;

    public class ExXamlOptions : ApiExampleBase
    {
        [Test]
        public void ChangeGanttBarsColorGradient()
        {
            //ExStart:ChangeGanttBarsColorGradient
            //ExFor: SaveOptions.UseGradientBrush
            //ExSummary: shows how to set a value indicating whether gradient brush should be used when rendering Gantt Chart.
            var project = new Project(DataDir + "Project2.mpp");
            
            SaveOptions options = new XamlOptions();
            options.UseGradientBrush = false;
            project.Save(OutDir + "ChangeGanttBarsColorGradient_Solid_out.xaml", options);

            options.UseGradientBrush = true;
            project.Save(OutDir + "ChangeGanttBarsColorGradient_Gradient_out.xaml", options);
            //ExEnd:ChangeGanttBarsColorGradient
        }

        [Test]
        public void RenderXAMLWithOptions()
        {
            //ExStart:RenderXAMLWithOptions
            //ExFor: XamlOptions
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