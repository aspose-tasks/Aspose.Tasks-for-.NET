namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectProperties
{
    using System;

    internal class DetermineProjectVersion
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());  

            //ExStart:DetermineProjectVersion
            //ExFor: Prj.LastSaved
            //ExFor: Prj.SaveVersion
            //ExFor: Project.Get``1(Key{``0,PrjKey})
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