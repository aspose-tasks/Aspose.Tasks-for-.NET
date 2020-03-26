namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    using System;

    internal class GetCrossProjectTaskLinks
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:GetCrossProjectTaskLinks
            //ExFor: Project.TaskLinks
            //ExFor: TaskLink.CrossProjectName
            //ExSummary: Shows how to find cross project task links. 
            var project = new Project(dataDir + "GetCrossProjectTaskLinks.mpp");

            // Check cross project task links
            foreach (var taskLink in project.TaskLinks)
            {
                if (taskLink.IsCrossProject)
                {
                    Console.WriteLine(taskLink.CrossProjectName);
                }
            }
            //ExEnd:GetCrossProjectTaskLinks
        }
    }
}
