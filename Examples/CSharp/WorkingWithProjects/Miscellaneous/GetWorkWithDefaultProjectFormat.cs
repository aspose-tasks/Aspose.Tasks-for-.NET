namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Miscellaneous
{
    using System;
    using System.Reflection;

    internal class GetWorkWithDefaultProjectFormat
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(MethodBase.GetCurrentMethod());
            
            //ExStart:GetWorkWithDefaultProjectFormat
            //ExFor: Project.GetWork(Double)
            //ExFor: Prj.WorkFormat
            //ExSummary: Shows how to get a duration with default work format.
            var project = new Project(dataDir + "Blank2010.mpp");

            Console.WriteLine("Project's work format: " + project.Get(Prj.WorkFormat));

            // create a work value with project's default work format
            var work = project.GetWork(2);
            Console.WriteLine("Work: " + work.TimeSpan);
            Console.WriteLine("Time unit: " + work.TimeUnit);
            //ExEnd:GetWorkWithDefaultProjectFormat
        }
    }
}