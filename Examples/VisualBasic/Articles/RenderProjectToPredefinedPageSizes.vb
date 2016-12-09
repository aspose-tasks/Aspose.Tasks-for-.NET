Imports Aspose.Tasks.Visualization
Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Articles
    Public Class RenderProjectToPredefinedPageSizes
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:RenderProjectToPredefinedPageSizes
            ' Source File to Render
            Dim fileName As String = "Project2.mpp"

            ' Read the Project
            Dim project1 As New Project(dataDir & fileName)

            ' Select a Presentation format
            Dim format As PresentationFormat = PresentationFormat.GanttChart

            ' Render the project to all Pre-Defined page sizes
            For Each pageSize As PageSize In DirectCast([Enum].GetValues(GetType(PageSize)), PageSize())
                Dim options As New PdfSaveOptions()
                options.PresentationFormat = format
                options.FitContent = True
                options.PageSize = pageSize
                Dim resultFile As String = "result_PredefinedPageSizes_" & format.ToString() & "_" & pageSize.ToString() & "_out.pdf"
                project1.Save(dataDir & resultFile, options)
            Next
            ' ExEnd:RenderProjectToPredefinedPageSizes
        End Sub
    End Class
End Namespace

