namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    using System;

    internal class GetResourceAssignmentPercentWorkComplete
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:GetResourceAssignmentPercentWorkComplete
            //ExFor: Asn.PercentWorkComplete
            //ExSummary: Shows how to read percent work complete of an assignment.
            var project = new Project(dataDir + "ResourceAssignmentPercentWorkComplete.mpp");

            // Print assignment percent completion
            foreach (var ra in project.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.PercentWorkComplete).ToString()); 
            }
            //ExEnd:GetResourceAssignmentPercentWorkComplete
        }
    }
}
