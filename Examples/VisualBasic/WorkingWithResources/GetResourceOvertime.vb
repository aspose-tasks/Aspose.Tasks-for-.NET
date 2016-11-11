
Namespace WorkingWithResources
    Public Class GetResourceOvertime
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' ExStart:GetResourceOvertime
            ' Create project instance
            Dim project1 As New Project(dataDir + "project_test.mpp")

            ' Display overtime related parameters for all resources
            For Each res As Resource In project1.Resources
                If res.[Get](Rsc.Name) IsNot Nothing Then
                    Console.WriteLine(res.[Get](Rsc.OvertimeCost))
                    Console.WriteLine(res.[Get](Rsc.OvertimeWork).ToString())
                    Console.WriteLine(res.[Get](Rsc.OvertimeRateFormat).ToString())
                End If
            Next
            ' ExEnd:GetResourceOvertime
        End Sub
    End Class
End Namespace
