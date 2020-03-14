using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectProperties
{
    public class ReadWeekdayProperties
    {
        public static void Run()
        {
            //ExStart:ReadWeekdayProperties
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Create project instance
            Project project = new Project(dataDir + "ReadWeekdayProperties.mpp");

            // Display week days properties
            Console.WriteLine("Week Start Date : " + project.Get(Prj.WeekStartDay));
            Console.WriteLine("Days Per Month : " + project.Get(Prj.DaysPerMonth));
            Console.WriteLine("Minutes Per Day : " + project.Get(Prj.MinutesPerDay));
            Console.WriteLine("Minutes Per Week : " + project.Get(Prj.MinutesPerWeek));
            //ExEnd:ReadWeekdayProperties            
        }
    }
}