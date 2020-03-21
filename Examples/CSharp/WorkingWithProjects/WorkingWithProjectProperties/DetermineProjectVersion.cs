namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectProperties
{
    using System;

    internal class DetermineProjectVersion
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);  

            //ExStart:DetermineProjectVersion
            //ExFor: Prj.SaveVersion
            //ExFor: Prj.LastSaved
            //ExSummary: Shows how to check a project version.
            // Read project from template file
            var project = new Project(dataDir + "DetermineProjectVersion.mpp");

            // Display project version
            Console.WriteLine("Project Version : " + project.Get(Prj.SaveVersion));
            Console.WriteLine("Last Saved : " + project.Get(Prj.LastSaved).ToShortDateString());
            //ExEnd:DetermineProjectVersion
        }
    }
}