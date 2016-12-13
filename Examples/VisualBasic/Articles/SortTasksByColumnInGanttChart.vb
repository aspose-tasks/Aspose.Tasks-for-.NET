Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Articles
    ' ExStart:SortTasksByColumnInGanttChart
    Public Class SortTasksByColumnInGanttChart
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            Dim project As New Project(dataDir & "Project2.mpp")
            Dim options As SaveOptions = New PdfSaveOptions()
            options.Timescale = Timescale.Months

            options.TasksComparer = New TasksNameComparer()
            project.Save(dataDir & "SortedByNames_out.pdf", options)

            options.TasksComparer = New TasksDurationComparer()
            project.Save(dataDir & "SortedByDurations_out.pdf", options)
        End Sub

        Public Class TasksNameComparer
            Implements IComparer(Of Task)

            Public Function Compare(x As Task, y As Task) As Integer Implements IComparer(Of Task).Compare
                Return x.Get(Tsk.Name).CompareTo(y.Get(Tsk.Name))
            End Function
        End Class

        Public Class TasksDurationComparer
            Implements IComparer(Of Task)

            Public Function Compare(x As Task, y As Task) As Integer Implements IComparer(Of Task).Compare
                Dim durX As Duration = x.Get(Tsk.Duration)
                Dim durY As Duration = y.Get(Tsk.Duration)
                Return durX.TimeSpan.CompareTo(durY.TimeSpan)
            End Function
        End Class
    End Class
    ' ExEnd:SortTasksByColumnInGanttChart
End Namespace

