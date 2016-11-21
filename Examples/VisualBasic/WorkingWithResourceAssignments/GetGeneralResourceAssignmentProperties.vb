
Namespace WorkingWithResourceAssignments
    Public Class GetGeneralResourceAssignmentProperties
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:GetGeneralResourceAssignmentProperties
            ' Create project instance
            Dim project1 As New Project(dataDir + "GetGeneralResourceAssignmentProperties.mpp")

            ' Print general resource assignment properties
            For Each ra As ResourceAssignment In project1.ResourceAssignments
                Console.WriteLine(ra.Get(Asn.Uid))
                Console.WriteLine(ra.Get(Asn.Start).ToShortDateString())
                Console.WriteLine(ra.Get(Asn.Finish).ToShortDateString())
            Next
            ' ExEnd:GetGeneralResourceAssignmentProperties
        End Sub
    End Class
End Namespace
