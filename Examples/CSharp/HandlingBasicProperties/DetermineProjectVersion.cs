using System;

namespace Aspose.Tasks.Examples.CSharp.HandlingBasicProperties
{
    public class DetermineProjectVersion
    {
        public static void Run()
        {
            // ExStart:DetermineProjectVersion

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_HandlingBasicProperties();
            Project project = new Project(dataDir + "DetermineProjectVersion.mpp");
            Console.WriteLine("Project Version : " + project.Get(Prj.SaveVersion).ToString());
            Console.WriteLine("Last Saved : " + project.Get(Prj.LastSaved).ToShortDateString());
            // ExEnd:DetermineProjectVersion
        }
    }
}