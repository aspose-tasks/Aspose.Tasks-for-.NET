Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithTasks
    Public Class RenderTaskSheetView
        Public Shared Sub Run()
            ' ExStart:RenderTaskSheetView
            ' Create project instance
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            Dim project1 As New Project(dataDir & "project.mpp")

            ' Set presentation format Task Sheet and save project as PDF
            Dim options As SaveOptions = New PdfSaveOptions()
            options.PresentationFormat = PresentationFormat.TaskSheet
            project1.Save(dataDir & "taskSheet_out.pdf", options)
            ' ExEnd:RenderTaskSheetView
        End Sub
    End Class
End Namespace

