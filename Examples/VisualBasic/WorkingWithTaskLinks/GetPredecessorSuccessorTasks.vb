
Namespace WorkingWithTaskLinks
    Public Class GetPredecessorSuccessorTasks
        Public Shared Sub Run()
            ' ExStart:GetPredecessorSuccessorTasks
            ' Create project instance
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            Dim project1 As New Project(dataDir + "project.mpp")

            ' Display names of predecessor and successor tasks
            For Each tsklnk As TaskLink In project1.TaskLinks
                Console.WriteLine("Predecessor " + tsklnk.PredTask.[Get](Tsk.Name))
                Console.WriteLine("Predecessor " + tsklnk.SuccTask.[Get](Tsk.Name))
            Next
            ' ExEnd:GetPredecessorSuccessorTasks
        End Sub
    End Class
End Namespace
