namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    using System;

    internal class GetCrossProjectTaskLinks
    {
        public static void Run()
        {                        
            //ExStart:GetCrossProjectTaskLinks
            // Create project instance
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
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
