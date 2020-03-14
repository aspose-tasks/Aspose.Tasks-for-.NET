using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    class GetTaskLinkType
    {
        public static void Run()
        {
            //ExStart:GetTaskLinkType
            // Create project instance
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            Project project1 = new Project(dataDir + "GetTaskLinkType.mpp");

            // Display task link types 
            var taskLinks = project1.TaskLinks;
            foreach (TaskLink link in taskLinks)
            {
                Console.WriteLine(link.LinkType.ToString());
            }
            //ExEnd:GetTaskLinkType
        }
    }
}
