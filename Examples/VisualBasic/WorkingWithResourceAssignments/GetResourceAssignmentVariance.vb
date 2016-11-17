
Namespace WorkingWithResourceAssignments
    Public Class GetResourceAssignmentVariance
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:GetResourceAssignmentVariance
            ' Create project instance
            Dim project1 As New Project(dataDir + "ResourceAssignmentVariance.mpp")

            ' Print assignment variances
            For Each ra As ResourceAssignment In project1.ResourceAssignments
                Console.WriteLine(ra.[Get](Asn.WorkVariance))
                Console.WriteLine(ra.[Get](Asn.CostVariance))
                Console.WriteLine(ra.[Get](Asn.StartVariance))
                Console.WriteLine(ra.[Get](Asn.FinishVariance))
            Next
            ' ExEnd:GetResourceAssignmentVariance
        End Sub
    End Class
End Namespace