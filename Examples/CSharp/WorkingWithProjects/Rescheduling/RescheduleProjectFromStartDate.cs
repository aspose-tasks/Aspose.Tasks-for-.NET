using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Rescheduling
{
    public class RescheduleProjectFromStartDate
    {
        public static void Run()
        {
            // ExStart:ReschedueProjectFromStartDate
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            Project project = new Project(dataDir + "Project2.mpp");
            project.Set(Prj.ScheduleFromStart, true);
            project.Set(Prj.StartDate, new DateTime(2014, 1, 1));

            // Now all tasks dates (Start, Finish, EarlyStart, EarlyFinish, LateStart, LateFinish) are calculated. To get the critical path we need to calculate slacks (can be invoked in separate thread, but only after calculation of all early/late dates)
            project.Recalculate();
            TaskCollection criticalPath = project.CriticalPath;
            // ExEnd:ReschedueProjectFromStartDate
        }
    }
}