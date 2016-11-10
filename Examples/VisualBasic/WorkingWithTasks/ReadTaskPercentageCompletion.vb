
Namespace WorkingWithTasks
    Public Class ReadTaskPercentageCompletion
        Public Shared Sub Run()
            ' ExStart:ReadTaskPercentageCompletion
            ' Create project instance
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            Dim project1 As New Project(dataDir + "project.mpp")

            ' Access tasks and display percentage completion
            Dim tasks = project1.RootTask.Children
            For Each tsk1 As Task In tasks
                Console.WriteLine(tsk1.Get(Tsk.PercentComplete))
                Console.WriteLine(tsk1.Get(Tsk.PercentWorkComplete).ToString())
                Console.WriteLine(tsk1.Get(Tsk.PhysicalPercentComplete).ToString())
            Next
            ' ExEnd:ReadTaskPercentageCompletion
        End Sub
    End Class
End Namespace
