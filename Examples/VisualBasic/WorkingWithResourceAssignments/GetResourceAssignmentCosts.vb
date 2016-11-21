
Namespace WorkingWithResourceAssignments
    Public Class GetResourceAssignmentCosts
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:GetResourceAssignmentCosts
            ' Create project instance
            Dim project1 As New Project(dataDir + "ResourceAssignmentCosts.mpp")

            ' Print resource assignment costs
            For Each ra As ResourceAssignment In project1.ResourceAssignments
                Console.WriteLine(ra.[Get](Asn.Cost))
                Console.WriteLine(ra.[Get](Asn.ACWP))
                Console.WriteLine(ra.[Get](Asn.BCWP))
                Console.WriteLine(ra.[Get](Asn.BCWS))
            Next
            ' ExEnd:GetResourceAssignmentCosts
        End Sub
    End Class
End Namespace

