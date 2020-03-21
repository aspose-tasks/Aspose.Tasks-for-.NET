/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Rescheduling
{
    using System;

    internal class RescheduleProjectFromStartDate
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            
            //ExStart:RescheduleProjectFromStartDate
            //ExFor: Prj.ScheduleFromStart
            //ExFor: Prj.StartDate
            //ExFor: Project.CriticalPath
            //ExFor: Project.Recalculate
            //ExSummary: Shows how to reschedule the project from start date instead of the finish one.
            var project = new Project(dataDir + "Project2.mpp");
            project.Set(Prj.ScheduleFromStart, true);
            project.Set(Prj.StartDate, new DateTime(2014, 1, 1));

            // Now all tasks dates (Start, Finish, EarlyStart, EarlyFinish, LateStart, LateFinish) are calculated. To get the critical path we need to calculate slacks (can be invoked in separate thread, but only after calculation of all early/late dates)
            project.Recalculate();
            var criticalPath = project.CriticalPath;
            foreach (var task in criticalPath)
            {
                Console.WriteLine(task.Get(Tsk.Id));
                Console.WriteLine(task.Get(Tsk.Name));
            }
            //ExEnd:RescheduleProjectFromStartDate
        }
    }
}