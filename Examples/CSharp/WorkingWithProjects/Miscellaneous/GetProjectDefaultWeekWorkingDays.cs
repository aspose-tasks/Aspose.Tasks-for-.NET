namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Miscellaneous
{
    using System;

    internal class GetProjectDefaultWeekWorkingDays
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:GetProjectDefaultWeekWorkingDays
            //ExFor: Project.DefaultWeekWorkingDays
            //ExSummary: Shows how to get default week working day.
            var project = new Project(dataDir + "Project2003.mpp");
            foreach (var weekDay in project.DefaultWeekWorkingDays)
            {
                Console.WriteLine("From: " + weekDay.FromDate);
                Console.WriteLine("From: " + weekDay.ToDate);
                Console.WriteLine("Day type: " + weekDay.DayType);
                Console.WriteLine("Is day working:" + weekDay.DayWorking);
            }
            //ExEnd:GetProjectDefaultWeekWorkingDays
        }
    }
}