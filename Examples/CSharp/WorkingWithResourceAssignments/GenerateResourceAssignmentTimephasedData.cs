namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    using System;

    internal class GenerateResourceAssignmentTimephasedData
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:GenerateResourceAssignmentTimephasedData
            // Create project instance
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
            firstRA.Set(Asn.WorkContour, WorkContourType.Turtle);
            Console.WriteLine("Turtle contour");
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            firstRA.Set(Asn.WorkContour, WorkContourType.BackLoaded);
            Console.WriteLine("BackLoaded contour");
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            firstRA.Set(Asn.WorkContour, WorkContourType.FrontLoaded);
            Console.WriteLine("FrontLoaded contour");
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            firstRA.Set(Asn.WorkContour, WorkContourType.Bell);
            Console.WriteLine("Bell contour");
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            firstRA.Set(Asn.WorkContour, WorkContourType.EarlyPeak);
            Console.WriteLine("EarlyPeak contour");
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            firstRA.Set(Asn.WorkContour, WorkContourType.LatePeak);
            Console.WriteLine("LatePeak contour");
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }
            
            // Change contour
            firstRA.Set(Asn.WorkContour, WorkContourType.DoublePeak);
            Console.WriteLine("DoublePeak contour");
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }
            //ExEnd:GenerateResourceAssignmentTimephasedData
        }
    }
}