
Namespace KnowledgeBase
    Public Class ReadCriticalPath
        Public Shared Sub Run()
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:ReadCriticalPath
            ' Load MPP file
            Dim project As New Project(dataDir & "Project1.mpp")

            ' Get the critical path
            Dim criticalPath As TaskCollection = project.CriticalPath

            ' Enumerate the tasks in the critical path
            For Each task As Task In criticalPath
                Console.WriteLine(task.Get(Tsk.Id) & "  " & task.Get(Tsk.Name))
                Console.WriteLine(task.Get(Tsk.Start))
                Console.WriteLine(task.Get(Tsk.Finish) + Constants.vbLf)
            Next task
            ' ExEnd:ReadCriticalPath
        End Sub
    End Class
End Namespace