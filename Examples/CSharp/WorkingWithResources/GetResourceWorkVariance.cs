namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    using System;

    internal class GetResourceWorkVariance
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:GetResourceWorkVariance
            // Read the input Project file
            var project = new Project(dataDir + "WorkVariance.mpp");

            foreach (var ra in project.ResourceAssignments)
            {
                var rsc = ra.Get(Asn.Resource);

                var d = rsc.Get(Rsc.WorkVariance);

                Console.WriteLine(d);
            }
            //ExEnd:GetResourceWorkVariance
        }
    }
}
