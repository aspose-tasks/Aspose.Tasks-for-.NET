using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    class GenerateResourceAssignmentTimephasedData
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:GenerateResourceAssignmentTimephasedData
            // Create project instance
            Project project1 = new Project(dataDir + "ResourceAssignmentTimephasedData.mpp");

            // Get the first task of the Project
            Task task = project1.RootTask.Children.GetById(1);

            // Get the First Resource Assignment of the Project
            ResourceAssignment firstRA = project1.ResourceAssignments.ToList()[0];

            // Flat contour is default contour
            Console.WriteLine("Flat contour");

            var tdList = task.GetTimephasedData(project1.Get(Prj.StartDate), project1.Get(Prj.FinishDate));
            foreach (TimephasedData td in tdList)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            firstRA.Set(Asn.WorkContour, WorkContourType.Turtle);
            Console.WriteLine("Turtle contour");
            tdList = task.GetTimephasedData(project1.Get(Prj.StartDate), project1.Get(Prj.FinishDate));
            foreach (TimephasedData td in tdList)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            firstRA.Set(Asn.WorkContour, WorkContourType.BackLoaded);
            Console.WriteLine("BackLoaded contour");
            tdList = task.GetTimephasedData(project1.Get(Prj.StartDate), project1.Get(Prj.FinishDate));
            foreach (TimephasedData td in tdList)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            firstRA.Set(Asn.WorkContour, WorkContourType.FrontLoaded);
            Console.WriteLine("FrontLoaded contour");
            tdList = task.GetTimephasedData(project1.Get(Prj.StartDate), project1.Get(Prj.FinishDate));
            foreach (TimephasedData td in tdList)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            firstRA.Set(Asn.WorkContour, WorkContourType.Bell);
            Console.WriteLine("Bell contour");
            tdList = task.GetTimephasedData(project1.Get(Prj.StartDate), project1.Get(Prj.FinishDate));
            foreach (TimephasedData td in tdList)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            firstRA.Set(Asn.WorkContour, WorkContourType.EarlyPeak);
            Console.WriteLine("EarlyPeak contour");
            tdList = task.GetTimephasedData(project1.Get(Prj.StartDate), project1.Get(Prj.FinishDate));
            foreach (TimephasedData td in tdList)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            firstRA.Set(Asn.WorkContour, WorkContourType.LatePeak);
            Console.WriteLine("LatePeak contour");
            tdList = task.GetTimephasedData(project1.Get(Prj.StartDate), project1.Get(Prj.FinishDate));
            foreach (TimephasedData td in tdList)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }
            
            // Change contour
            firstRA.Set(Asn.WorkContour, WorkContourType.DoublePeak);
            Console.WriteLine("DoublePeak contour");
            tdList = task.GetTimephasedData(project1.Get(Prj.StartDate), project1.Get(Prj.FinishDate));
            foreach (TimephasedData td in tdList)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }
            // ExEnd:GenerateResourceAssignmentTimephasedData
        }
    }
}
    