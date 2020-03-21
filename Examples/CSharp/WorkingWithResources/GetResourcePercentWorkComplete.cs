namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    using System;

    internal class GetResourcePercentWorkComplete
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:GetResourcePercentWorkComplete
            //ExFor: Rsc.PercentWorkComplete
            //ExSummary: Shows how to read resource percent work complete.
            // Create project instance
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
