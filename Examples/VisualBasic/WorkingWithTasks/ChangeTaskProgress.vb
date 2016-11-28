
Namespace WorkingWithTasks
    Public Class ChangeTaskProgress
        Public Shared Sub Run()
            ' ExStart:ChangeTaskProgress
            Dim project As New Project()
            Console.WriteLine("Project Calculation mode is Automatic: {0}", project.CalculationMode.Equals(CalculationMode.Automatic))

            Dim task As Task = project.RootTask.Children.Add("Task")
            task.[Set](Tsk.Duration, project.GetDuration(2))
            task.[Set](Tsk.PercentComplete, 50)
            ' ExEnd:ChangeTaskProgress
        End Sub
    End Class
End Namespace