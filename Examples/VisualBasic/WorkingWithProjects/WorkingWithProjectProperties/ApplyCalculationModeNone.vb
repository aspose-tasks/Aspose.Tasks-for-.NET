
Namespace WorkingWithProjects.WorkingWithProjectProperties
    Public Class ApplyCalculationModeNone
        Public Shared Sub Run()
            ' ExStart:ApplyCalculationModeNone
            ' Create empty project and set calculation mode to None
            Dim project As Project = New Project()
            project.CalculationMode = CalculationMode.None

            ' Add a new task
            Dim task As Task = project.RootTask.Children.Add("Task")

            ' Note that even ids were not calculated            
            Console.WriteLine("Task.Id Equals 0 : {0} ", task.Get(Tsk.Id).Equals(0))
            Console.WriteLine("Task.OutlineLevel Equals 0 : {0} ", task.Get(Tsk.OutlineLevel).Equals(0))
            Console.WriteLine("Task Start Equals DateTime.MinValue : {0} ", task.Get(Tsk.Start).Equals(DateTime.MinValue))
            Console.WriteLine("Task Finish Equals DateTime.MinValue : {0} ", task.Get(Tsk.Finish).Equals(DateTime.MinValue))
            Console.WriteLine("Task Duration Equals 0 mins : {0} ", task.Get(Tsk.Duration).ToString().Equals("0 mins"))

            ' Set duration property
            task.Set(Tsk.Duration, project.GetDuration(2, TimeUnitType.Day))
            Console.WriteLine("Task Duration Equals 2 days : {0} ", task.Get(Tsk.Duration).ToString().Equals("2 days"))
            Console.WriteLine("Task Start Equals DateTime.MinValue  : {0} ", task.Get(Tsk.Start).Equals(DateTime.MinValue))
            Console.WriteLine("Task Finish Equals DateTime.MinValue  : {0} ", task.Get(Tsk.Finish).Equals(DateTime.MinValue))
            ' ExEnd:ApplyCalculationModeNone
        End Sub
    End Class
End Namespace

