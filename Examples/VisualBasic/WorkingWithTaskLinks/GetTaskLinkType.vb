
Namespace WorkingWithTaskLinks
    Public Class GetTaskLinkType
        Public Shared Sub Run()
            ' ExStart:GetTaskLinkType
            ' Create project instance
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            Dim project1 As New Project(dataDir + "project.mpp")

            ' Display task link types 
            Dim allinks = project1.TaskLinks
            For Each tsklnk As TaskLink In allinks
                Console.WriteLine(tsklnk.LinkType.ToString())
            Next
            ' ExEnd:GetTaskLinkType
        End Sub
    End Class
End Namespace
