
Namespace WorkingWithResources
    Public Class GetResourceCalendar
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:GetResourceCalendar
            ' Create project instance
            Dim project1 As New Project(dataDir + "ResourceCalendar.mpp")

            ' Display base calendar name for all resources 
            For Each res As Resource In project1.Resources
                If res.Get(Rsc.Name) IsNot Nothing Then
                    Console.WriteLine(res.Get(Rsc.Calendar).BaseCalendar.Name)
                End If
            Next
            ' ExEnd:GetResourceCalendar
        End Sub
    End Class
End Namespace
