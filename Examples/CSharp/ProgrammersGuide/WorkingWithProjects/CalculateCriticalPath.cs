using System.IO;
using Aspose.Tasks;
using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class CalculateCriticalPath
    {
        public static void Run()
        {
            //Exstart: CalculateCriticalPath
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();

            Project project = new Project(dataDir+ "CalculateCriticalPath.mpp");
            project.CalculationMode = CalculationMode.Automatic;

            Task subtask1 = project.RootTask.Children.Add("1");
            Task subtask2 = project.RootTask.Children.Add("2");
            Task subtask3 = project.RootTask.Children.Add("3");

            project.TaskLinks.Add(subtask1, subtask2, TaskLinkType.FinishToStart);

            //Display the critical path now
            foreach (Task task in project.CriticalPath)
            {
                Console.WriteLine(task.Get(Tsk.Name));
            }
            //ExEnd: CalculateCriticalPath
        }
    }
}