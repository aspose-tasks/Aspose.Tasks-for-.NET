namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    using System;

    internal class GetGeneralResourceAssignmentProperties
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:GetGeneralResourceAssignmentProperties
            //ExFor: Asn.Uid
            //ExFor: Asn.Start
            //ExFor: Asn.Finish
            //ExSummary: Shows how to read common resource assignment's properties.
            var project = new Project(dataDir + "GetGeneralResourceAssignmentProperties.mpp");

            // Print general resource assignment properties
            foreach (var ra in project.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.Uid));
                Console.WriteLine(ra.Get(Asn.Start).ToShortDateString());
                Console.WriteLine(ra.Get(Asn.Finish).ToShortDateString());
            }
            //ExEnd:GetGeneralResourceAssignmentProperties
        }
    }
}
