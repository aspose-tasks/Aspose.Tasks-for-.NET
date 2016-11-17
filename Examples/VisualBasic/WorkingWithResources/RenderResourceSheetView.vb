Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithResources
    Public Class RenderResourceSheetView
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:RenderResourceSheetView
            ' Create project instance
            Dim project1 As New Project(dataDir + "ResourceSheetView.mpp")

            ' Set the Presentation Format to Resource Sheet
            Dim format As PresentationFormat = PresentationFormat.ResourceSheet

            ' Define rendering options
            Dim options As New PdfSaveOptions()
            options.PresentationFormat = format
            project1.Save(dataDir & "ResourceSheetView_out.pdf", options)
            ' ExEnd:RenderResourceSheetView
        End Sub
    End Class
End Namespace