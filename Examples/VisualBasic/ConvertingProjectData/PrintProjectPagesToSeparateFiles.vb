Imports System.Collections.Generic
Imports System.Drawing
Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace ConvertingProjectData
    Public Class PrintProjectPagesToSeparateFiles
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:PrintProjectPagesToSeparateFiles
            Dim project As New Project(dataDir & Convert.ToString("CreateProject2.mpp"))
            Dim saveOptions As New ImageSaveOptions(SaveFileFormat.PNG)
            saveOptions.StartDate = project.[Get](Prj.StartDate).AddDays(-3)
            saveOptions.EndDate = project.[Get](Prj.FinishDate)

            saveOptions.MarkCriticalTasks = True
            saveOptions.LegendOnEachPage = False

            saveOptions.Gridlines = New List(Of Gridline)()

            Dim gridline As New Gridline()
            gridline.GridlineType = GridlineType.GanttRow
            gridline.Color = Color.CornflowerBlue
            gridline.Pattern = LinePattern.Dashed
            saveOptions.Gridlines.Add(gridline)

            ' Save the whole project layout to one file
            project.Save(dataDir & Convert.ToString("PrintProjectPagesToSeparateFiles1_out.png"), saveOptions)

            ' Save project layout to separate files
            saveOptions.SaveToSeparateFiles = True
            project.Save(dataDir & Convert.ToString("PrintProjectPagesToSeparateFiles2_out.png"), saveOptions)
            ' ExEnd:PrintProjectPagesToSeparateFiles
        End Sub
    End Class
End Namespace