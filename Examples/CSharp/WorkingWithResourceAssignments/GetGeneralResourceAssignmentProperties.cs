namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    using System;

    internal class GetGeneralResourceAssignmentProperties
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:GetGeneralResourceAssignmentProperties
            //ExFor: Asn.Uid
            //ExFor: Asn.Start
            //ExFor: Asn.Finish
            //ExSummary: Shows how to read common resource assignment's properties.
            // Create project instance
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
