
Namespace WorkingWithResources
    Public Class GetResourceWorkVariance
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:GetResourceWorkVariance
            ' Read the input Project file
            Dim project As New Project(dataDir & "WorkVariance.mpp")

            For Each resourceAssignement1 As ResourceAssignment In project.ResourceAssignments
                Dim resource1 As Resource = resourceAssignement1.Get(Asn.Resource)
                Dim workVariance As Double = resource1.Get(Rsc.WorkVariance)
                Console.WriteLine(workVariance)
            Next
            ' ExEnd:GetResourceWorkVariance
        End Sub
    End Class
End Namespace

