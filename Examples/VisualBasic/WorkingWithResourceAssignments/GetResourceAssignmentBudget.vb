
Namespace WorkingWithResourceAssignments
    Public Class GetResourceAssignmentBudget
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:GetResourceAssignmentBudget
            ' Create project instance
            Dim project1 As New Project(dataDir + "ResourceAssignmentBudget.mpp")

            ' Print assignment budget cost and budget work
            For Each ra As ResourceAssignment In project1.ResourceAssignments
                Console.WriteLine(ra.[Get](Asn.BudgetCost))
                Console.WriteLine(ra.[Get](Asn.BudgetWork).ToString())
            Next
            ' ExEnd:GetResourceAssignmentBudget
        End Sub
    End Class
End Namespace