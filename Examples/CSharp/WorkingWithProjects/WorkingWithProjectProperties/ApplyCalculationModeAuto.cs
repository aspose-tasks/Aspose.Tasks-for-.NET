using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectProperties
{
    class ApplyCalculationModeAuto
    {
        public static void Run()
        {
            // ExStart:ApplyCalculationModeAuto
            // Create empty project and set calculation mode to Automatic
            Project project = new Project();
            project.CalculationMode = CalculationMode.Automatic;

            // Set project start date and add new tasks
            project.Set(Prj.StartDate, new DateTime(2015, 4, 15));
            Task task1 = project.RootTask.Children.Add("Task 1");
            Task task2 = project.RootTask.Children.Add("Task 2");

            // Link tasks
            TaskLink link = project.TaskLinks.Add(task1, task2, TaskLinkType.FinishToStart);

            // Verify dates have been recalculated
            Console.WriteLine("Task1 Start + 1 Equals Task2 Start : {0} ", task1.Get(Tsk.Start).AddDays(1).Equals(task2.Get(Tsk.Start)));
            Console.WriteLine("Task1 Finish + 1 Equals Task2 Finish : {0} ", task1.Get(Tsk.Finish).AddDays(1).Equals(task2.Get(Tsk.Finish)));
            Console.WriteLine("RootTask Finish Equals Task2 Finish : {0} ", task2.Get(Tsk.Finish).Equals(project.RootTask.Get(Tsk.Finish)));
            Console.WriteLine("Project Finish Date Equals Task2 Finish : {0} ", task2.Get(Tsk.Finish).Equals(project.Get(Prj.FinishDate))); 
            // ExEnd:ApplyCalculationModeAuto
        }
    }
}
