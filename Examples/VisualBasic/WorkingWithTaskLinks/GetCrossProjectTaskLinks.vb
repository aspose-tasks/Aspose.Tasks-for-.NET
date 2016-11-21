
Namespace WorkingWithTaskLinks
    Public Class GetCrossProjectTaskLinks
        Public Shared Sub Run()
            ' ExStart:GetCrossProjectTaskLinks
            ' Create project instance
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)
            Dim project1 As New Project(dataDir + "GetCrossProjectTaskLinks.mpp")

            ' Check cross project task links
            For Each tsklnk As TaskLink In project1.TaskLinks
                If tsklnk.IsCrossProject Then
                    Console.WriteLine(tsklnk.CrossProjectName)
                End If
            Next
            ' ExEnd:GetCrossProjectTaskLinks
        End Sub
    End Class
End Namespace
