Imports Aspose.Tasks.Util

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Miscellaneous
    Public Class SortTasksByName
        Public Shared Sub Run()
            ' ExStart:SortTasksByName
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)
            Dim project As New Project(dataDir + "project-sort.mpp")
            Dim coll As New ChildTasksCollector()
            TaskUtils.Apply(project.RootTask, coll, 0)
            Dim tasks As List(Of Task) = coll.Tasks

            tasks.Sort(New TaskNameComparer())

            For Each task As Task In tasks
                Console.WriteLine(task)
            Next
            ' ExEnd:SortTasksByName
        End Sub

        ' ExStart:ImplementIComparer
        Private Class TaskNameComparer
            Implements IComparer(Of Task)
            Public Function Compare(x As Task, y As Task) As Integer Implements IComparer(Of Aspose.Tasks.Task).Compare
                If String.IsNullOrEmpty(x.[Get](Tsk.Name)) Then
                    Return 1
                End If
                If String.IsNullOrEmpty(y.[Get](Tsk.Name)) Then
                    Return -1
                End If
                Return x.[Get](Tsk.Name).CompareTo(y.[Get](Tsk.Name))
            End Function
        End Class
        ' ExEnd:ImplementIComparer
    End Class
End Namespace