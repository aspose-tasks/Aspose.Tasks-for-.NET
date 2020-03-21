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

    internal class CreateSplitTasks
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:CreateSplitTasks
            //ExFor: ResourceAssignment.TimephasedDataFromTaskDuration(Calendar)
            //ExFor: ResourceAssignment.SplitTask(DateTime, DateTime, Calendar)
            //ExSummary: Shows how to add a split for a task.
            // Create new project
            var project = new Project();

            // Get a standard calendar
            var calendar = project.Get(Prj.Calendar);

            // Set project's calendar settings
            project.Set(Prj.StartDate, new DateTime(2000, 3, 15, 8, 0, 0));
            project.Set(Prj.FinishDate, new DateTime(2000, 4, 21, 17, 0, 0));

            // Add a new task to root task
            var task = project.RootTask.Children.Add("Task1");
            task.Set(Tsk.Duration, project.GetDuration(3));

            // Create a new resource assignment and generate timephased data
            var assignment = project.ResourceAssignments.Add(task, null);
            assignment.TimephasedDataFromTaskDuration(calendar);

            // Split the task into 3 parts.
            // Provide start date and finish date arguments to SplitTask method which will be used for split
            assignment.SplitTask(new DateTime(2000, 3, 16, 8, 0, 0), new DateTime(2000, 3, 16, 17, 0, 0), calendar);
            assignment.SplitTask(new DateTime(2000, 3, 18, 8, 0, 0), new DateTime(2000, 3, 18, 17, 0, 0), calendar);
            assignment.Set(Asn.WorkContour, WorkContourType.Contoured);

            // Save the Project
            project.Save(dataDir + "CreateSplitTasks_out.xml", SaveFileFormat.XML);
            //ExEnd:CreateSplitTasks
        }
    }
}
