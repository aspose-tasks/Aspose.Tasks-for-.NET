using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    class GetResourceWorkVariance
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:GetResourceWorkVariance
            // Read the input Project file
            Project project = new Project(dataDir + "WorkVariance.mpp");

            foreach (ResourceAssignment ra in project.ResourceAssignments)
            {
                Resource rsc = ra.Get(Asn.Resource);

                double d = rsc.Get(Rsc.WorkVariance);

                Console.WriteLine(d);
            }
            //ExEnd:GetResourceWorkVariance
        }
    }
}
