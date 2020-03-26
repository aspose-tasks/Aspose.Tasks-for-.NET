namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    using Aspose.Tasks.Saving;

    internal class AddingCssStylePrefix
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:AddingCssStylePrefix
            //ExFor: HtmlSaveOptions.CssStylePrefix
            //ExSummary: Shows how to set a common prefix for CSS styles are used during export to HTML.
            var project = new Project(dataDir + "CreateProject2.mpp");

            var options = new HtmlSaveOptions
            {
                CssStylePrefix = "test_prefix"
            };

            project.Save(dataDir + "TestCssStylePrefix_out.html", options);
            //ExEnd:AddingCssStylePrefix
        }
    }
}
