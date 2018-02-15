using Aspose.Tasks.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    class CreateSplitTasks
    {
        public static void Run()
        {
            // ExStart:CreateSplitTasks
            // Create new project
            Project splitTaskProject = new Project();

            // Get a standard calendar
            Calendar calendar = splitTaskProject.Get(Prj.Calendar);

            // Set project's calendar settings
            splitTaskProject.Set(Prj.StartDate, new DateTime(2000, 3, 15, 8, 0, 0));
            splitTaskProject.Set(Prj.FinishDate, new DateTime(2000, 4, 21, 17, 0, 0));

            // Add a new task to root task
            Task rootTask = splitTaskProject.RootTask;
            rootTask.Set(Tsk.Name, "Root");
            Task taskToSplit = rootTask.Children.Add("Task1");
            taskToSplit.Set(Tsk.Duration, splitTaskProject.GetDuration(3));

            // Create a new resource assignment and generate timephased data
            ResourceAssignment splitResourceAssignment = splitTaskProject.ResourceAssignments.Add(taskToSplit, null);
            splitResourceAssignment.TimephasedDataFromTaskDuration(calendar);

            // Split the task into 3 parts.
            // Provide start date and finish date arguments to SplitTask method which will be used for split
            splitResourceAssignment.SplitTask(new DateTime(2000, 3, 16, 8, 0, 0), new DateTime(2000, 3, 16, 17, 0, 0), calendar);
            splitResourceAssignment.SplitTask(new DateTime(2000, 3, 18, 8, 0, 0), new DateTime(2000, 3, 18, 17, 0, 0), calendar);
            splitResourceAssignment.Set(Asn.WorkContour, WorkContourType.Contoured);

            // Save the Project
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            splitTaskProject.Save(dataDir + "CreateSplitTasks_out.xml", SaveFileFormat.XML);
            // ExEnd:CreateSplitTasks
        }
    }
}
