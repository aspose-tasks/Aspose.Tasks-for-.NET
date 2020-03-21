namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    using System;

    internal class GetResourceOvertime
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:GetResourceOvertime
            //ExFor: Rsc.OvertimeCost
            //ExFor: Rsc.OvertimeWork
            //ExFor: Rsc.OvertimeRateFormat
            //ExSummary: Shows how to read resource overtime values.
            // Create project instance
            var project = new Project(dataDir + "ResourceOvertime.mpp");

            // Display overtime related parameters for all resources
            foreach (var res in project.Resources)
            {
                if (res.Get(Rsc.Name) == null)
                {
                    continue;
                }

                Console.WriteLine(res.Get(Rsc.OvertimeCost));
                Console.WriteLine(res.Get(Rsc.OvertimeWork).ToString());
                Console.WriteLine(res.Get(Rsc.OvertimeRateFormat).ToString());
            }
            //ExEnd:GetResourceOvertime
        }
    }
}
