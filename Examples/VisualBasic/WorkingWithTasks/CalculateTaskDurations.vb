
Namespace WorkingWithTasks
    Public Class CalculateTaskDurations
        Public Shared Sub Run()
            ' ExStart:CalculateTaskDurations
            ' Create project instance
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)
            Dim project1 As New Project(dataDir & "TaskDurations.mpp")

            ' Get a task to calculate its duration in different formats
            Dim task As Task = project1.RootTask.Children.GetById(1)

            ' Get the duration in Minutes, Days, Hours, Weeks and Months
            Dim mins As Double = task.[Get](Tsk.Duration).Convert(TimeUnitType.Minute).ToDouble()
            Console.WriteLine("Duration in Mins: {0}", mins)
            Dim days As Double = task.[Get](Tsk.Duration).Convert(TimeUnitType.Day).ToDouble()
            Console.WriteLine("Duration in Days: {0}", days)
            Dim hours As Double = task.[Get](Tsk.Duration).Convert(TimeUnitType.Hour).ToDouble()
            Console.WriteLine("Duration in Hours: {0}", hours)
            Dim weeks As Double = task.[Get](Tsk.Duration).Convert(TimeUnitType.Week).ToDouble()
            Console.WriteLine("Duration in Weeks: {0}", weeks)
            Dim months As Double = task.[Get](Tsk.Duration).Convert(TimeUnitType.Month).ToDouble()
            Console.WriteLine("Duration in Months: {0}", months)
            ' ExEnd:CalculateTaskDurations
        End Sub
    End Class
End Namespace
