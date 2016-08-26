Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Tasks.Examples.VisualBasic.PrintingAndExporting
    Public Class ExportProjectDataToPrimaveraMPXFormat
        Public Shared Sub Run()
            ' ExStart:ExportProjectDataToPrimaveraMPXFormat
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_PrintingAndExporting()

            Dim project As New Project(dataDir & Convert.ToString("Project1.mpp"))
            project.Save(dataDir & Convert.ToString("ExportProjectDataToPrimaveraMPXFormat_out.xml"), SaveFileFormat.MPX)
            ' ExEnd:ExportProjectDataToPrimaveraMPXFormat
        End Sub
    End Class
End Namespace
