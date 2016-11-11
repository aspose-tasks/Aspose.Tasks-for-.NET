
Namespace WorkingWithTasks
    Public Class CalculateSplitTaskFinishDate
        Public Shared Sub Run()
            ' ExStart:CalculateSplitTaskFinishDate
            ' Read project
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            Dim projectName As String = "project.mpp"
            Dim project As New Project(dataDir & projectName)

            ' Find a split task
            Dim splitTask As Task = project.RootTask.Children.GetByUid(1)

            ' Find the project calendar
            Dim calendar As Calendar = project.[Get](Prj.Calendar)

            ' Calculate task's finish date with different durations
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + vbLf & "+ Duration 8 hours" & vbLf & "Finish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, New TimeSpan(8, 0, 0)))
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + vbLf & "+ Duration 16 hours" & vbLf & "Finish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, New TimeSpan(16, 0, 0)))
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + vbLf & "+ Duration 24 hours" & vbLf & "Finish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, New TimeSpan(24, 0, 0)))
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + vbLf & "+ Duration 28 hours" & vbLf & "Finish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, New TimeSpan(28, 0, 0)))
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + vbLf & "+ Duration 32 hours" & vbLf & "Finish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, New TimeSpan(32, 0, 0)))
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + vbLf & "+ Duration 46 hours" & vbLf & "Finish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, New TimeSpan(46, 0, 0)))
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + vbLf & "+ Duration 61 hours" & vbLf & "Finish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, New TimeSpan(61, 0, 0)))
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + vbLf & "+ Duration 75 hours" & vbLf & "Finish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, New TimeSpan(75, 0, 0)))
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + vbLf & "+ Duration 80 hours" & vbLf & "Finish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, New TimeSpan(80, 0, 0)))
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + vbLf & "+ Duration 120 hours" & vbLf & "Finish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, New TimeSpan(120, 0, 0)))
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + vbLf & "+ Duration 150 hours" & vbLf & "Finish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, New TimeSpan(150, 0, 0)))
            ' ExEnd:CalculateSplitTaskFinishDate
        End Sub
    End Class
End Namespace

