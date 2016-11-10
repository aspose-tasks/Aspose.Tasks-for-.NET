using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    class GetTaskLinkType
    {
        public static void Run()
        {
            // ExStart:GetTaskLinkType
            // Create project instance
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            Project project1 = new Project(dataDir + "project.mpp");

            // Display task link types 
            var allinks = project1.TaskLinks;
            foreach (TaskLink tsklnk in allinks)
            {
                Console.WriteLine(tsklnk.LinkType.ToString());
            }
            // ExEnd:GetTaskLinkType
        }
    }
}
