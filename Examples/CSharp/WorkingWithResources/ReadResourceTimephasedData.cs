namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    using System;

    internal class ReadResourceTimephasedData
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:ReadResourceTimephasedData
            //ExFor: Resource.GetTimephasedData(DateTime,DateTime)
            //ExFor: Resource.GetTimephasedData(DateTime,DateTime,TimephasedDataType)
            //ExSummary: Shows how to read timephased data of work/cost resources.
            // Create project instance
            var project = new Project(dataDir + "ResourceTimephasedData.mpp");

            // Get the Resource by its ID
            var resource = project.Resources.GetByUid(1);

            // Print Timephased data of ResourceWork
            Console.WriteLine("Timephased data of ResourceWork");
            foreach (var td in resource.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate)))
            {
                Console.Write("Start: " + td.Start.ToShortDateString());
                Console.WriteLine(" Work: " + td.Value);
            }

            // Print Timephased data of ResourceCost
            Console.WriteLine("Timephased data of ResourceCost");
            foreach (var td in resource.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate), TimephasedDataType.ResourceCost))
            {
                Console.Write("Start: " + td.Start.ToShortDateString());
                Console.WriteLine(" Cost: " + td.Value);
            }
            //ExEnd:ReadResourceTimephasedData
        }
    }
}
