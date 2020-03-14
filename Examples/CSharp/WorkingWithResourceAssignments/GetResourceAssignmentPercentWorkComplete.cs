using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    class GetResourceAssignmentPercentWorkComplete
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:GetResourceAssignmentPercentWorkComplete
            // Create project instance
            Project project1 = new Project(dataDir + "ResourceAssignmentPercentWorkComplete.mpp");

            // Print assignment percent completion
            foreach (ResourceAssignment ra in project1.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.PercentWorkComplete).ToString()); 
            }
            //ExEnd:GetResourceAssignmentPercentWorkComplete
        }
    }
}
