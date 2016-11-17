
Namespace WorkingWithResourceAssignments
    Public Class GetResourceAssignmentOvertimes
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:GetResourceAssignmentOvertimes
            ' Create project instance
            Dim project1 As New Project(dataDir + "ResourceAssignmentOvertimes.mpp")

            ' Print assignment overtimes
            For Each ra As ResourceAssignment In project1.ResourceAssignments
                Console.WriteLine(ra.[Get](Asn.OvertimeCost))
                Console.WriteLine(ra.[Get](Asn.OvertimeWork).ToString())
                Console.WriteLine(ra.[Get](Asn.RemainingCost))
                Console.WriteLine(ra.[Get](Asn.RemainingOvertimeCost))
                Console.WriteLine(ra.[Get](Asn.RemainingOvertimeWork).ToString())
                Console.WriteLine(ra.[Get](Asn.RemainingOvertimeWork).ToString())
            Next
            ' ExEnd:GetResourceAssignmentOvertimes
        End Sub
    End Class
End Namespace
