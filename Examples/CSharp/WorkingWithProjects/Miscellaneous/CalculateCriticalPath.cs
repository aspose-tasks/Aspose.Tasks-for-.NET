namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Miscellaneous
{
    using System;

    public class CalculateCriticalPath
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:CalculateCriticalPath
            var project = new Project(dataDir + "CalculateCriticalPath.mpp");
            project.CalculationMode = CalculationMode.Automatic;

            var subtask1 = project.RootTask.Children.Add("1");
            var subtask2 = project.RootTask.Children.Add("2");
            project.TaskLinks.Add(subtask1, subtask2, TaskLinkType.FinishToStart);

            project.RootTask.Children.Add("3");

            // Display the critical path now
            foreach (var task in project.CriticalPath)
            {
                Console.WriteLine(task.Get(Tsk.Name));
            }
            //ExEnd:CalculateCriticalPath
        }
    }
}