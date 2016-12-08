Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace ConvertingProjectData
    Public Class HideLegendsDuringSave
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            Dim project As New Project(dataDir & Convert.ToString("CreateProject2.mpp"))

            ' ExStart:HideLegendsDuringSave
            Dim saveOptions As SaveOptions = New PdfSaveOptions()

            ' Set the LegendOnEachPage property to false to hide legends
            saveOptions.LegendOnEachPage = False
            ' ExEnd:HideLegendsDuringSave

            project.Save(dataDir & Convert.ToString("HideLegendsDuringSave_out.pdf"), saveOptions)
        End Sub
    End Class
End Namespace
