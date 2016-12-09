Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization
Imports System.IO

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Articles
    Public Class RenderGanttChartWithBarsNotRolledUp
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)
            Dim fileName As String = "Project2.mpp"

            ' ExStart:RenderGanttChartWithBarsNotRolledUp
            Dim options As PdfSaveOptions = New PdfSaveOptions()
            options.PresentationFormat = PresentationFormat.GanttChart
            options.FitContent = True
            options.RollUpGanttBars = False
            options.DrawNonWorkingTime = False
            options.PageSize = PageSize.A3

            Dim file As String = Path.Combine(dataDir, fileName)
            Dim resultFile As String = Path.Combine(dataDir, "RenderGanttChartWithBarsNotRolledUp_out.pdf")
            Dim project As New Project(file)
            project.Save(resultFile, options)
            ' ExEnd:RenderGanttChartWithBarsNotRolledUp
        End Sub
    End Class
End Namespace

