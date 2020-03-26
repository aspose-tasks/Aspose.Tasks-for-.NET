namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    using System;

    internal class GenerateResourceAssignmentTimephasedData
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:GenerateResourceAssignmentTimephasedData
            //ExFor: Asn.WorkContour
            //ExSummary: Shows how to set different timephased data contours for resource assignments.
            var project = new Project(dataDir + "ResourceAssignmentTimephasedData.mpp");

            // Get the first task of the Project
            var task = project.RootTask.Children.GetById(1);

            // Get the First Resource Assignment of the Project
            var firstRA = project.ResourceAssignments.ToList()[0];

            // Flat contour is default contour
            Console.WriteLine("Flat contour");

            var collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            Console.WriteLine("Turtle contour");
            firstRA.Set(Asn.WorkContour, WorkContourType.Turtle);
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            Console.WriteLine("BackLoaded contour");
            firstRA.Set(Asn.WorkContour, WorkContourType.BackLoaded);
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            Console.WriteLine("FrontLoaded contour");
            firstRA.Set(Asn.WorkContour, WorkContourType.FrontLoaded);
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            Console.WriteLine("Bell contour");
            firstRA.Set(Asn.WorkContour, WorkContourType.Bell);
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            Console.WriteLine("EarlyPeak contour");
            firstRA.Set(Asn.WorkContour, WorkContourType.EarlyPeak);
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            Console.WriteLine("LatePeak contour");
            firstRA.Set(Asn.WorkContour, WorkContourType.LatePeak);
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }
            
            // Change contour
            Console.WriteLine("DoublePeak contour");
            firstRA.Set(Asn.WorkContour, WorkContourType.DoublePeak);
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }
            //ExEnd:GenerateResourceAssignmentTimephasedData
        }
    }
}