Imports System

Namespace WorkingWithProjects.Miscellaneous
    Public Class CalculateCriticalPath
        Public Shared Sub Run()
            ' ExStart: CalculateCriticalPath
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            Dim project As New Project(dataDir & "CalculateCriticalPath.mpp")
            project.CalculationMode = CalculationMode.Automatic

            Dim subtask1 As Task = project.RootTask.Children.Add("1")
            Dim subtask2 As Task = project.RootTask.Children.Add("2")
            Dim subtask3 As Task = project.RootTask.Children.Add("3")
            project.TaskLinks.Add(subtask1, subtask2, TaskLinkType.FinishToStart)

            ' Display the critical path now
            For Each task As Task In project.CriticalPath
                Console.WriteLine(task.Get(Tsk.Name))
            Next task
            ' ExEnd: CalculateCriticalPath
        End Sub
    End Class
End Namespace