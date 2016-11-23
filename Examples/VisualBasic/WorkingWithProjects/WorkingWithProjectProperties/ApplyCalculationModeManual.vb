
Namespace WorkingWithProjects.WorkingWithProjectProperties
    Public Class ApplyCalculationModeManual
        Public Shared Sub Run()
            ' ExStart:ApplyCalculationModeManual
            ' Create empty project and set calculation mode to Manual
            Dim project As Project = New Project()
            project.CalculationMode = CalculationMode.Manual

            ' Set project start date and add new tasks
            project.Set(Prj.StartDate, New DateTime(2015, 4, 15))
            Dim task1 As Task = project.RootTask.Children.Add("Task 1")
            Dim task2 As Task = project.RootTask.Children.Add("Task 2")

            ' The necessary properties are set in manual mode
            Console.WriteLine("Task1.Id Equals 1 : {0} ", task1.Get(Tsk.Id).Equals(1))
            Console.WriteLine("Task1 OutlineLevel Equals 1 : {0} ", task1.Get(Tsk.OutlineLevel).Equals(1))
            Console.WriteLine("Task1 Start Equals 15/04/2015 08:00 AM : {0} ", task1.Get(Tsk.Start).Equals(New DateTime(2015, 4, 15, 8, 0, 0)))
            Console.WriteLine("Task1 Finish Equals 15/04/2015 05:00 PM : {0} ", task1.Get(Tsk.Finish).Equals(New DateTime(2015, 4, 15, 17, 0, 0)))
            Console.WriteLine("Task1 Duration Equals 1 day : {0} ", task1.Get(Tsk.Duration).ToString().Equals("1 day"))
            Console.WriteLine("Task2 Start Equals 15/04/2015 08:00 AM : {0} ", task2.Get(Tsk.Start).Equals(New DateTime(2015, 4, 15, 8, 0, 0)))
            Console.WriteLine("Task2 Finish Equals 15/04/2015 05:00 PM : {0} ", task2.Get(Tsk.Finish).Equals(New DateTime(2015, 4, 15, 17, 0, 0)))
            Console.WriteLine("Task2 Duration Equals 1 day : {0} ", task2.Get(Tsk.Duration).ToString().Equals("1 day"))

            ' When we link two tasks together their dates are not recalculated in manual mode
            Dim link As TaskLink = project.TaskLinks.Add(task1, task2, TaskLinkType.FinishToStart)

            ' Task 2 Start has not been changed
            Console.WriteLine("Task1 Start Equals Task2 Start : {0} ", task1.Get(Tsk.Start).Equals(task2.Get(Tsk.Start)))
            Console.WriteLine("Task1 Finish Equals Task2 Finish : {0} ", task1.Get(Tsk.Finish).Equals(task2.Get(Tsk.Finish)))
            ' ExEnd:ApplyCalculationModeManual
        End Sub
    End Class
End Namespace

