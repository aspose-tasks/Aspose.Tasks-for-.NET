using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    class GetCrossProjectTaskLinks
    {
        public static void Run()
        {                        
            // ExStart:GetCrossProjectTaskLinks
            // Create project instance
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            Project project1 = new Project(dataDir + "project.mpp");

            // Check cross project task links
            foreach (TaskLink tsklnk in project1.TaskLinks)
            {
                if (tsklnk.IsCrossProject)
                    Console.WriteLine(tsklnk.CrossProjectName);
            }
            // ExEnd:GetCrossProjectTaskLinks
        }
    }
}
