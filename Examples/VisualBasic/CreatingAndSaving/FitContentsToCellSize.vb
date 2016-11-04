Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace CreatingAndSaving
    Public Class FitContentsToCellSize
        Public Shared Sub Run()
            ' ExStart:FitContentsToCellSize
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreatingAndSaving()
            Dim project As New Project(dataDir & Convert.ToString("Project2.mpp"))
            Dim saveOptions As SaveOptions = New PdfSaveOptions()
            ' Set the row height to fit cell content
            saveOptions.FitContent = True
            saveOptions.Timescale = Timescale.Months
            saveOptions.PresentationFormat = PresentationFormat.TaskUsage
            project.Save(dataDir & Convert.ToString("FitContentsToCellSize_out.pdf"), saveOptions)
            ' ExEnd:FitContentsToCellSize
        End Sub
    End Class
End Namespace