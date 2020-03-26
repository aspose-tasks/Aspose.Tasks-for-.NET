namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    using System;

    internal class GetTaskLinkType
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:GetTaskLinkType
            //ExFor: TaskLink.LinkType
            //ExSummary: Shows how to read task link types.
            var project = new Project(dataDir + "GetTaskLinkType.mpp");

            foreach (var link in project.TaskLinks)
            {
                Console.WriteLine(link.LinkType.ToString());
            }
            //ExEnd:GetTaskLinkType
        }
    }
}
