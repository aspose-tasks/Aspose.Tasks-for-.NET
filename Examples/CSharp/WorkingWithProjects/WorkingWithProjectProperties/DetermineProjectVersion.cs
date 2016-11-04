using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectProperties
{
    public class DetermineProjectVersion
    {
        public static void Run()
        {
            // ExStart:DetermineProjectVersion
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);  
            
            // Read project from template file
            Project project = new Project(dataDir + "DetermineProjectVersion.mpp");

            // Display project version
            Console.WriteLine("Project Version : " + project.Get(Prj.SaveVersion).ToString());
            Console.WriteLine("Last Saved : " + project.Get(Prj.LastSaved).ToShortDateString());
            // ExEnd:DetermineProjectVersion
        }
    }
}