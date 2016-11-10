
Namespace WorkingWithTasks
    Public Class ViewSplitTasks
        Public Shared Sub Run()
            ' ExStart:ViewSplitTasks
            ' Create project instance
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            Dim project1 As New Project(dataDir & "project.mpp")

            ' Access Task
            Dim splitTask As Task = project1.RootTask.Children.GetById(4)

            ' Display split parts of task
            Dim collection As SplitPartCollection = splitTask.SplitParts
            For Each splitPart As SplitPart In collection
                Console.WriteLine("Index: " & splitPart.Index & Constants.vbLf & "Start: " & splitPart.Start & Constants.vbLf & "Finish: " & splitPart.Finish & Constants.vbLf)
            Next splitPart
            ' ExEnd:ViewSplitTasks
        End Sub
    End Class

End Namespace
