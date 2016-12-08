Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace ConvertingProjectData
    Public Class SaveProjectDataAsHTML
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:SaveProjectDataAsHTML
            Dim project As New Project(dataDir & Convert.ToString("CreateProject2.mpp"))
            Dim [option] As New HtmlSaveOptions()
            project.Save(dataDir & Convert.ToString("SaveProjectDataAsHTML_out.html"), [option])

            ' OR

            ' Adding only one page (page number 2)
            [option] = New HtmlSaveOptions()
            [option].Pages.Add(2)
            project.Save(dataDir & Convert.ToString("SaveProjectDataAsHTML2_out.html"), [option])
            ' ExEnd:SaveProjectDataAsHTML
        End Sub
    End Class
End Namespace