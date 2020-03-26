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

    using Aspose.Tasks.Saving;

    internal class UpdateProjectAndRescheduleUncompletedWork
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:UpdateProjectAndRescheduleUncompletedWork
            //ExFor: Project.UpdateProjectWorkAsComplete(DateTime,bool)
            //ExFor: Project.RescheduleUncompletedWorkToStartAfter(DateTime)
            //ExSummary: Shows how to update the project and reschedule uncomplete work.
            // Create a new project and set start date
            var project = new Project();
            project.Set(Prj.StartDate, new DateTime(2014, 1, 27, 8, 0, 0));

            // Add new tasks
            var task1 = project.RootTask.Children.Add("Task 1");
            var task2 = project.RootTask.Children.Add("Task 2");
            task2.Set(Tsk.Duration, task2.ParentProject.GetDuration(16, TimeUnitType.Hour));
            var task3 = project.RootTask.Children.Add("Task 3");
            task3.Set(Tsk.Duration, task2.ParentProject.GetDuration(24, TimeUnitType.Hour));
            var task4 = project.RootTask.Children.Add("Task 4");
            task4.Set(Tsk.Duration, task2.ParentProject.GetDuration(16, TimeUnitType.Hour));
            var task5 = project.RootTask.Children.Add("Task 5");
            task5.Set(Tsk.Duration, task2.ParentProject.GetDuration(16, TimeUnitType.Hour));

            // Add links between tasks
            project.TaskLinks.Add(task1, task2, TaskLinkType.FinishToStart);
            var link23 = project.TaskLinks.Add(task2, task3, TaskLinkType.FinishToStart);
            
            // One day lag
            link23.LinkLag = 4800; 
            project.TaskLinks.Add(task3, task4, TaskLinkType.FinishToStart);
            project.TaskLinks.Add(task4, task5, TaskLinkType.FinishToStart);
            
            // Add new tasks
            var task6 = project.RootTask.Children.Add("Task 6");
            var task7 = project.RootTask.Children.Add("Task 7");
            task7.Set(Tsk.Duration, task7.ParentProject.GetDuration(24, TimeUnitType.Hour));
            var task8 = project.RootTask.Children.Add("Task 8");
            task8.Set(Tsk.Duration, task2.ParentProject.GetDuration(16, TimeUnitType.Hour));
            var task9 = project.RootTask.Children.Add("Task 9");
            task9.Set(Tsk.Duration, task2.ParentProject.GetDuration(16, TimeUnitType.Hour));
            var task10 = project.RootTask.Children.Add("Task 10");
            
            // Add links between tasks
            project.TaskLinks.Add(task6, task7, TaskLinkType.FinishToStart);
            project.TaskLinks.Add(task7, task8, TaskLinkType.FinishToStart);
            project.TaskLinks.Add(task8, task9, TaskLinkType.FinishToStart);
            project.TaskLinks.Add(task9, task10, TaskLinkType.FinishToStart);
            task6.Set(Tsk.IsManual, true);
            task7.Set(Tsk.IsManual, true);
            task8.Set(Tsk.IsManual, true);
            task9.Set(Tsk.IsManual, true);
            task10.Set(Tsk.IsManual, true);
            
            // Save project before and after updating work as completed 
            project.Save(dataDir + "RescheduleUncompletedWork_not updated_out.xml", SaveFileFormat.XML);
            project.UpdateProjectWorkAsComplete(new DateTime(2014, 1, 28, 17, 0, 0), false);
            project.Save(dataDir + "RescheduleUncompletedWork_updated_out.xml", SaveFileFormat.XML);

            // Save project after rescheduling uncompleted work
            project.RescheduleUncompletedWorkToStartAfter(new DateTime(2014, 2, 7, 8, 0, 0));
            project.Save(dataDir + "RescheduleUncompletedWork_rescheduled_out.xml", SaveFileFormat.XML);
            //ExEnd:UpdateProjectAndRescheduleUncompletedWork
        }
    }
}