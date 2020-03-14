using Aspose.Tasks.Saving;

namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    class AddingCssStylePrefix
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:AddingCssStylePrefix
            Project project = new Project(dataDir + "CreateProject2.mpp");

            HtmlSaveOptions options = new HtmlSaveOptions
            {
                CssStylePrefix = "test_prefix"
            };

            project.Save(dataDir + "TestCssStylePrefix_out.html", options);
            //ExEnd:AddingCssStylePrefix
        }
    }
}
