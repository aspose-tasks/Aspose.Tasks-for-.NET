using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    class GetGeneralResourceAssignmentProperties
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:GetGeneralResourceAssignmentProperties
            // Create project instance
            Project project1 = new Project(dataDir + "GetGeneralResourceAssignmentProperties.mpp");

            // Print general resource assignment properties
            foreach (ResourceAssignment ra in project1.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.Uid));
                Console.WriteLine(ra.Get(Asn.Start).ToShortDateString());
                Console.WriteLine(ra.Get(Asn.Finish).ToShortDateString());
            }
            // ExEnd:GetGeneralResourceAssignmentProperties
        }
    }
}
