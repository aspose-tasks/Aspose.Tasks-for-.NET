Imports Aspose.Tasks.Connectivity

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects.CreatingReadingAndSaving
    Public Class ImportProjectDataFromMPDFile
        Public Shared Sub Run()
            ' ExStart:ImportProjectDataFromMPDFile 
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Projects()
            Dim settings As DbSettings = New MpdSettings((Convert.ToString("Provider=Microsoft.Jet.OLEDB.4.0 Data Source=") & dataDir) + "MpdFileToRead.mpd", 1)
            Dim project As New Project(settings)
            ' ExEnd:ImportProjectDataFromMPDFile
        End Sub
    End Class
End Namespace
