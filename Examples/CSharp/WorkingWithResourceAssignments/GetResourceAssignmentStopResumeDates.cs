namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    using System;

    internal class GetResourceAssignmentStopResumeDates
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:GetResourceAssignmentStopResumeDates
            //ExFor: Asn.Stop
            //ExFor: Asn.Resume
            //ExSummary: Shows how to read assignment's stop/resume dates. 
            var project = new Project(dataDir + "ResourceAssignmentStopResumeDates.mpp");

            // Print resource assignment's stop and resume dates
            foreach (var ra in project.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.Stop).ToShortDateString() == "1/1/2000" ? "NA" : ra.Get(Asn.Stop).ToShortDateString());
                Console.WriteLine(ra.Get(Asn.Resume).ToShortDateString() == "1/1/2000" ? "NA" : ra.Get(Asn.Resume).ToShortDateString());
            }
            //ExEnd:GetResourceAssignmentStopResumeDates
        }
    }
}
