
Namespace WorkingWithResourceAssignments
    Public Class GetResourceAssignmentStopResumeDates
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:GetResourceAssignmentStopResumeDates
            ' Create project instance
            Dim project1 As New Project(dataDir + "ResourceAssignmentStopResumeDates.mpp")

            ' Print resource assignment's stop and resume dates
            For Each ra As ResourceAssignment In project1.ResourceAssignments
                If ra.[Get](Asn.[Stop]).ToShortDateString() = "1/1/2000" Then
                    Console.WriteLine("NA")
                Else
                    Console.WriteLine(ra.[Get](Asn.[Stop]).ToShortDateString())
                End If

                If ra.[Get](Asn.[Resume]).ToShortDateString() = "1/1/2000" Then
                    Console.WriteLine("NA")
                Else
                    Console.WriteLine(ra.[Get](Asn.[Resume]).ToShortDateString())
                End If
            Next
            ' ExEnd:GetResourceAssignmentStopResumeDates
        End Sub
    End Class
End Namespace
