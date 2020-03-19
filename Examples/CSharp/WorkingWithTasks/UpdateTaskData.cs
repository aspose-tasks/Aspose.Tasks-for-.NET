/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using System;

    using Aspose.Tasks.Saving;

    internal class UpdateTaskData
    {
        public static void Run()
        {
            try
            {
                var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                //ExStart:UpdateTaskData
                //ExFor: Task.Children.Add(String)
                //ExSummary: Shows how to build parent-child relation of tasks.
                var project = new Project(dataDir + "UpdateTaskData.mpp");

                // Set project start date
                project.Set(Prj.StartDate, new DateTime(2012, 07, 29, 8, 0, 0));

                // Add summary task and set its properties
                var summary = project.RootTask.Children.Add("Summary task");
                var task = summary.Children.Add("First task");
                task.Set(Tsk.Duration, project.GetDuration(3));
                task.Set(Tsk.Deadline, task.Get(Tsk.Start).AddDays(10));
                task.Set(Tsk.NotesText, "The first task.");
                task.Set(Tsk.DurationFormat, TimeUnitType.MinuteEstimated);
                task.Set(Tsk.ConstraintType, ConstraintType.FinishNoLaterThan);
                task.Set(Tsk.ConstraintDate, task.Get(Tsk.Deadline).AddDays(-1));

                // Create 10 new sub tasks for summary task
                for (var i = 0; i < 10; i++)
                {
                    var child = summary.Children.Add(string.Format("Task {0}", i + 2));
                    child.Set(Tsk.Duration, task.Get(Tsk.Duration).Add(project.GetDuration(i + 1)));
                    child.Set(Tsk.DurationFormat, TimeUnitType.Day);
                    child.Set(Tsk.Deadline, task.Get(Tsk.Deadline).AddDays(i + 1));
                }

                // Save the Project
                project.Save(dataDir + "project_UpdateTaskData_updated_out.mpp", SaveFileFormat.MPP);
                //ExEnd:UpdateTaskData
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
