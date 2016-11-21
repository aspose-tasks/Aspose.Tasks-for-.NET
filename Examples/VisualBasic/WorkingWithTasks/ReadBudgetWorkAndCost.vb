
Namespace WorkingWithTasks
    Public Class ReadBudgetWorkAndCost
        Public Shared Sub Run()
            ' ExStart:ReadBudgetWorkAndCost
            ' Create project instance
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)
            Dim project1 As New Project(dataDir & "BudgetWorkAndCost.mpp")

            ' Display budget work and budget cost for project summary task
            Dim projSummary As Task = project1.RootTask
            Console.WriteLine("projSummary.BudgetWork = " & projSummary.[Get](Tsk.BudgetWork).ToString())
            Console.WriteLine("projSummary.BudgetCost = " & projSummary.[Get](Tsk.BudgetCost).ToString())

            ' Display resource budget work
            Dim rsc1 As Resource = project1.Resources.GetByUid(6)
            Console.WriteLine("Resource BudgetWork = " & rsc1.[Get](Rsc.BudgetWork).ToString())

            ' Display resource budget cost
            rsc1 = project1.Resources.GetByUid(7)
            Console.WriteLine("Resource BudgetCost = " & rsc1.[Get](Rsc.BudgetCost).ToString())

            ' Display assignment budget work and budget cost
            For Each assn As ResourceAssignment In projSummary.Assignments
                If assn.[Get](Asn.Resource).[Get](Rsc.Type) = ResourceType.Work Then
                    Console.WriteLine("Assignment BudgetWork = " & assn.[Get](Asn.BudgetWork).ToString())
                Else
                    Console.WriteLine("Assignment BudgetCost = " & assn.[Get](Asn.BudgetCost).ToString())
                End If
            Next
            ' ExEnd:ReadBudgetWorkAndCost
        End Sub
    End Class
End Namespace
