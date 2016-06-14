using System.IO;
using Aspose.Tasks;
using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class ReadWeekdayProperties
    {
        public static void Run()
        {
            //ExStart: ReadWeekdayProperties
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();
            Project project = new Project(dataDir+ "ReadWeekdayProperties.mpp");

            //Display week days properties
            Console.WriteLine("Week Start Date : " + project.Get(Prj.WeekStartDay).ToString());
            Console.WriteLine("Days Per Month : " + project.Get(Prj.DaysPerMonth).ToString());
            Console.WriteLine("Minutes Per Day : " + project.Get(Prj.MinutesPerDay).ToString());
            Console.WriteLine("Minutes Per Week : " + project.Get(Prj.MinutesPerWeek).ToString());
            //ExEnd: ReadWeekdayProperties            
        }
    }
}