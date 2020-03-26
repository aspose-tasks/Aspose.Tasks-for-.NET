namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    using System;

    internal class GetResourceWorkVariance
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:GetResourceWorkVariance
            //ExFor: Rsc.WorkVariance
            //ExSummary: Shows how to read resource work variance.
            // Read the input Project file
            var project = new Project(dataDir + "WorkVariance.mpp");

            foreach (var assignment in project.ResourceAssignments)
            {
                var resource = assignment.Get(Asn.Resource);

                var workVariance = resource.Get(Rsc.WorkVariance);

                Console.WriteLine(workVariance);
            }
            //ExEnd:GetResourceWorkVariance
        }
    }
}
