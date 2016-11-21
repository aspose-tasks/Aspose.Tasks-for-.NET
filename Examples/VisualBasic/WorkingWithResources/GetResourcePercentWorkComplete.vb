
Namespace WorkingWithResources
    Public Class GetResourcePercentWorkComplete
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:GetResourcePercentWorkComplete
            ' Create project instance
            Dim project1 As New Project(dataDir + "ResourcePercentWorkComplete.mpp")

            ' Display work percentage completion for all resources
            For Each res As Resource In project1.Resources
                If res.[Get](Rsc.Name) IsNot Nothing Then
                    Console.WriteLine(res.[Get](Rsc.PercentWorkComplete))
                End If
            Next
            ' ExEnd:GetResourcePercentWorkComplete
        End Sub
    End Class
End Namespace

