namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExCalculationMode : ApiExampleBase
    {
        [Test]
        public void ApplyCalculationModeAuto()
        {
            //ExStart:ApplyCalculationModeAuto
            //ExFor: CalculationMode.Automatic
            //ExSummary: Shows how to use auto calculation mode.
            var project = new Project();
            project.CalculationMode = CalculationMode.Automatic;

            // Set project start date and add new tasks
            project.Set(Prj.StartDate, new DateTime(2015, 4, 15));
            var task1 = project.RootTask.Children.Add("Task 1");
            var task2 = project.RootTask.Children.Add("Task 2");

            // Link tasks
            project.TaskLinks.Add(task1, task2, TaskLinkType.FinishToStart);

            // Verify dates have been recalculated
            Console.WriteLine("Task1 Start + 1 Equals Task2 Start : {0} ", task1.Get(Tsk.Start).AddDays(1).Equals(task2.Get(Tsk.Start)));
            Console.WriteLine("Task1 Finish + 1 Equals Task2 Finish : {0} ", task1.Get(Tsk.Finish).AddDays(1).Equals(task2.Get(Tsk.Finish)));
            Console.WriteLine("RootTask Finish Equals Task2 Finish : {0} ", task2.Get(Tsk.Finish).Equals(project.RootTask.Get(Tsk.Finish)));
            Console.WriteLine("Project Finish Date Equals Task2 Finish : {0} ", task2.Get(Tsk.Finish).Equals(project.Get(Prj.FinishDate))); 
            //ExEnd:ApplyCalculationModeAuto
        }
        
        [Test]
        public void ApplyCalculationModeManual()
        {
            //ExStart:ApplyCalculationModeManual
            //ExFor: CalculationMode
            //ExFor: CalculationMode.Manual
            //ExSummary: Shows how to use manual calculation mode.
            var project = new Project();
            project.CalculationMode = CalculationMode.Manual;

            // Set project start date and add new tasks
            project.Set(Prj.StartDate, new DateTime(2015, 4, 15));           
            var task1 = project.RootTask.Children.Add("Task 1");
            var task2 = project.RootTask.Children.Add("Task 2");

            // The necessary properties are set in manual mode
            Console.WriteLine("Task1.Id Equals 1 : {0} ", task1.Get(Tsk.Id).Equals(1));
            Console.WriteLine("Task1 OutlineLevel Equals 1 : {0} ", task1.Get(Tsk.OutlineLevel).Equals(1));
            Console.WriteLine("Task1 Start Equals 15/04/2015 08:00 AM : {0} ", task1.Get(Tsk.Start).Equals(new DateTime(2015, 4, 15, 8, 0, 0)));
            Console.WriteLine("Task1 Finish Equals 15/04/2015 05:00 PM : {0} ", task1.Get(Tsk.Finish).Equals(new DateTime(2015, 4, 15, 17, 0, 0)));
            Console.WriteLine("Task1 Duration Equals 1 day : {0} ", task1.Get(Tsk.Duration).ToString().Equals("1 day"));
            Console.WriteLine("Task2 Start Equals 15/04/2015 08:00 AM : {0} ", task2.Get(Tsk.Start).Equals(new DateTime(2015, 4, 15, 8, 0, 0)));
            Console.WriteLine("Task2 Finish Equals 15/04/2015 05:00 PM : {0} ", task2.Get(Tsk.Finish).Equals(new DateTime(2015, 4, 15, 17, 0, 0)));
            Console.WriteLine("Task2 Duration Equals 1 day : {0} ", task2.Get(Tsk.Duration).ToString().Equals("1 day"));
            
            // When we link two tasks together their dates are not recalculated in manual mode
            project.TaskLinks.Add(task1, task2, TaskLinkType.FinishToStart);

            // Task 2 Start has not been changed
            Console.WriteLine("Task1 Start Equals Task2 Start : {0} ", task1.Get(Tsk.Start).Equals(task2.Get(Tsk.Start)));
            Console.WriteLine("Task1 Finish Equals Task2 Finish : {0} ", task1.Get(Tsk.Finish).Equals(task2.Get(Tsk.Finish)));
            //ExEnd:ApplyCalculationModeManual
        }
        
        [Test]
        public void ApplyCalculationModeNone()
        {
            //ExStart:ApplyCalculationModeNone
            //ExFor: CalculationMode.None
            //ExSummary: Shows how to use none calculation mode.
            var project = new Project();
            project.CalculationMode = CalculationMode.None;

            // Add a new task
            var task = project.RootTask.Children.Add("Task");

            // Note that even ids were not calculated            
            Console.WriteLine("Task.Id Equals 0 : {0} ",  task.Get(Tsk.Id).Equals(0));
            Console.WriteLine("Task.OutlineLevel Equals 0 : {0} ", task.Get(Tsk.OutlineLevel).Equals(0));
            Console.WriteLine("Task Start Equals DateTime.MinValue : {0} ", task.Get(Tsk.Start).Equals(DateTime.MinValue));
            Console.WriteLine("Task Finish Equals DateTime.MinValue : {0} ", task.Get(Tsk.Finish).Equals(DateTime.MinValue));
            Console.WriteLine("Task Duration Equals 0 mins : {0} ", task.Get(Tsk.Duration).ToString().Equals("0 mins"));

            // Set duration property
            task.Set(Tsk.Duration, project.GetDuration(2, TimeUnitType.Day));
            Console.WriteLine("Task Duration Equals 2 days : {0} ", task.Get(Tsk.Duration).ToString().Equals("2 days"));
            Console.WriteLine("Task Start Equals DateTime.MinValue  : {0} ", task.Get(Tsk.Start).Equals(DateTime.MinValue));
            Console.WriteLine("Task Finish Equals DateTime.MinValue  : {0} ", task.Get(Tsk.Finish).Equals(DateTime.MinValue));
            //ExEnd:ApplyCalculationModeNone
        }
    }
}