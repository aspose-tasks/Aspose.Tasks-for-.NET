namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    using System;

    internal class GetResourcePercentWorkComplete
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:GetResourcePercentWorkComplete
            //ExFor: Rsc.PercentWorkComplete
            //ExSummary: Shows how to read resource percent work complete.
            var project = new Project(dataDir + "ResourcePercentWorkComplete.mpp");

            // Display work percentage completion for all resources
            foreach (var res in project.Resources)
            {
                if (res.Get(Rsc.Name) != null)
                {
                    Console.WriteLine(res.Get(Rsc.PercentWorkComplete));
                }
            }
            //ExEnd:GetResourcePercentWorkComplete
        }
    }
}
