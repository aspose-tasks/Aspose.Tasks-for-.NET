Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace ConvertingProjectData
    Public Class ControlHeaderNameDuringHTMLExport
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:ControlHeaderNameDuringHTMLExport
            Dim project As New Project(dataDir & Convert.ToString("CreateProject2.mpp"))
            Dim htmlSaveOptions As New HtmlSaveOptions()

            ' Determines whether to include project name in HTML title (true by default)
            htmlSaveOptions.IncludeProjectNameInTitle = False

            ' Determines whether to include project name in HTML page header  (true by default)
            htmlSaveOptions.IncludeProjectNameInPageHeader = False

            htmlSaveOptions.Pages = New List(Of Integer)()
            htmlSaveOptions.Pages.Add(1)
            project.Save(dataDir & "ControlHeaderNameDuringHTMLExport_out.html", htmlSaveOptions)
            ' ExEnd:ControlHeaderNameDuringHTMLExport
        End Sub
    End Class
End Namespace