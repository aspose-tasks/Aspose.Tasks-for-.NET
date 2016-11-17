
Namespace Miscellaneous
    Public Class SortResourcesByName
        Public Shared Sub Run()
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:SortResourcesByName
            Dim project As New Project(dataDir & "project-sort.mpp")

            Dim resources As List(Of Resource) = project.Resources.ToList()
            resources.Sort(New RscNameComparer())

            For Each rsc As Resource In resources
                Console.WriteLine(rsc)
            Next
            ' ExEnd:SortResourcesByName
        End Sub

        ' ExStart:ImplementIComparer
        Private Class RscNameComparer
            Implements IComparer(Of Resource)
            Public Function Compare(x As Resource, y As Resource) As Integer Implements IComparer(Of Aspose.Tasks.Resource).Compare
                If String.IsNullOrEmpty(x.[Get](Rsc.Name)) Then
                    Return 1
                End If
                If String.IsNullOrEmpty(y.[Get](Rsc.Name)) Then
                    Return -1
                End If
                Return x.[Get](Rsc.Name).CompareTo(y.[Get](Rsc.Name))
            End Function
        End Class
        '  ExEnd:ImplementIComparer
    End Class
End Namespace