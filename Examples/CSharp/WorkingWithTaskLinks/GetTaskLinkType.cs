namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    using System;

    internal class GetTaskLinkType
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            //ExStart:GetTaskLinkType
            // Create project instance
            var project = new Project(dataDir + "GetTaskLinkType.mpp");

            // Display task link types 
            var taskLinks = project.TaskLinks;
            foreach (var link in taskLinks)
            {
                Console.WriteLine(link.LinkType.ToString());
            }
            //ExEnd:GetTaskLinkType
        }
    }
}
