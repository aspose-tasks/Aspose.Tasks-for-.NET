using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    class ReadResourceTimephasedData
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:ReadResourceTimephasedData
            // Create project instance
            Project project1 = new Project(dataDir + "ResourceTimephasedData.mpp");

            // Get the Resource by its ID
            Resource resource = project1.Resources.GetByUid(1);

            // Print Timephased data of ResourceWork
            Console.WriteLine("Timephased data of ResourceWork");
            foreach (TimephasedData td in resource.GetTimephasedData(project1.Get(Prj.StartDate), project1.Get(Prj.FinishDate)))
            {
                Console.Write("Start: " + td.Start.ToShortDateString());
                Console.Write(" Work: " + td.Value + Environment.NewLine);
            }

            // Print Timephased data of ResourceCost
            Console.WriteLine("Timephased data of ResourceCost");
            foreach (TimephasedData td in resource.GetTimephasedData(project1.Get(Prj.StartDate), project1.Get(Prj.FinishDate), TimephasedDataType.ResourceCost))
            {
                Console.Write("Start: " + td.Start.ToShortDateString());
                Console.Write(" Cost: " + td.Value + Environment.NewLine);
            }
            // ExEnd:ReadResourceTimephasedData
        }
    }
}
