using Aspose.Tasks.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    class UpdateTaskData
    {
        public static void Run()
        {
            try
            {
                // ExStart:UpdateTaskData
                // Create project instance
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
                string newProject = "UpdateTaskData.mpp";
                Project project = new Project(dataDir + newProject);

                // Set project start date
                project.Set(Prj.StartDate, new DateTime(2012, 07, 29, 8, 0, 0));

                // Add summary task and set its properties
                Task summary = project.RootTask.Children.Add("Summary task");
                Task task1 = summary.Children.Add("First task");
                task1.Set(Tsk.Duration, project.GetDuration(3));
                task1.Set(Tsk.Deadline, task1.Get(Tsk.Start).AddDays(10));
                task1.Set(Tsk.NotesText, "The first task.");
                task1.Set(Tsk.DurationFormat, TimeUnitType.MinuteEstimated);
                task1.Set(Tsk.ConstraintType, ConstraintType.FinishNoLaterThan);
                task1.Set(Tsk.ConstraintDate, task1.Get(Tsk.Deadline).AddDays(-1));


                // Create 10 new sub tasks for summary task
                for (int i = 0; i < 10; i++)
                {
                    Task subTask = summary.Children.Add(string.Format("Task{0}", i + 2));
                    subTask.Set(Tsk.Duration, task1.Get(Tsk.Duration).Add(project.GetDuration(i + 1)));
                    subTask.Set(Tsk.DurationFormat, TimeUnitType.Day);
                    subTask.Set(Tsk.Deadline, task1.Get(Tsk.Deadline).AddDays(i + 1));
                }

                // Save the Project
                project.Save(dataDir + "project_UpdateTaskData_updated_out.mpp", SaveFileFormat.MPP);
                // ExEnd:UpdateTaskData
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
