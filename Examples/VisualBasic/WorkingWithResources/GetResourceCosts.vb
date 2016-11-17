
Namespace WorkingWithResources
    Public Class GetResourceCosts
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:GetResourceCosts
            ' Create project instance
            Dim project1 As New Project(dataDir + "ResourceCosts.mpp")

            ' Display all resources costs
            For Each res As Resource In project1.Resources
                If res.[Get](Rsc.Name) IsNot Nothing Then
                    Console.WriteLine(res.[Get](Rsc.Cost))
                    Console.WriteLine(res.[Get](Rsc.ACWP))
                    Console.WriteLine(res.[Get](Rsc.BCWS))
                    Console.WriteLine(res.[Get](Rsc.BCWP))
                End If
            Next
            ' ExEnd:GetResourceCosts
        End Sub
    End Class
End Namespace

