using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    class GetResourceAssignmentStopResumeDates
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:GetResourceAssignmentStopResumeDates
            // Create project instance
            Project project1 = new Project(dataDir + "ResourceAssignmentStopResumeDates.mpp");

            // Print resource assignment's stop and resume dates
            foreach (ResourceAssignment ra in project1.ResourceAssignments)
            {
                if (ra.Get(Asn.Stop).ToShortDateString() == "1/1/2000")
                    Console.WriteLine("NA");
                else
                    Console.WriteLine(ra.Get(Asn.Stop).ToShortDateString());

                if (ra.Get(Asn.Resume).ToShortDateString() == "1/1/2000")
                    Console.WriteLine("NA");
                else
                    Console.WriteLine(ra.Get(Asn.Resume).ToShortDateString());
            }
            // ExEnd:GetResourceAssignmentStopResumeDates
        }
    }
}
