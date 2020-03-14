using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    class GetCrossProjectTaskLinks
    {
        public static void Run()
        {                        
            //ExStart:GetCrossProjectTaskLinks
            // Create project instance
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            Project project1 = new Project(dataDir + "GetCrossProjectTaskLinks.mpp");

            // Check cross project task links
            foreach (TaskLink taskLink in project1.TaskLinks)
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
