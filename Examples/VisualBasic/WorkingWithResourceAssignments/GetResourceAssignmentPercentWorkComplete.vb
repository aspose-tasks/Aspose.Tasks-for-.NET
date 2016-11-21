
Namespace WorkingWithResourceAssignments
    Public Class GetResourceAssignmentPercentWorkComplete
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:GetResourceAssignmentPercentWorkComplete
            ' Create project instance
            Dim project1 As New Project(dataDir + "ResourceAssignmentPercentWorkComplete.mpp")

            ' Print assignment percent completion
            For Each ra As ResourceAssignment In project1.ResourceAssignments
                Console.WriteLine(ra.[Get](asn.PercentWorkComplete).ToString())
            Next
            ' ExEnd:GetResourceAssignmentPercentWorkComplete
        End Sub
    End Class
End Namespace
