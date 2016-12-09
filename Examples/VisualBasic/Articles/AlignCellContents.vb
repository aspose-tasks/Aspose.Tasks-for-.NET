Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization
Imports System.Drawing

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Articles
    Public Class AlignCellContents
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:AlignCellContents
            Dim project As New Project(dataDir + "Project2.mpp")
            Dim options As SaveOptions = New PdfSaveOptions()
            options.Timescale = Timescale.Months
            options.View = ProjectView.GetDefaultGanttChartView()

            Dim column1 As GanttChartColumn = TryCast(options.View.Columns(2), GanttChartColumn)
            column1.StringAlignment = StringAlignment.Center
            column1 = TryCast(options.View.Columns(3), GanttChartColumn)
            column1.StringAlignment = StringAlignment.Far
            column1 = TryCast(options.View.Columns(4), GanttChartColumn)
            column1.StringAlignment = StringAlignment.Far

            project.Save(dataDir & "AlignCellContents_GanttChart_out.pdf", options)

            options.PresentationFormat = PresentationFormat.ResourceSheet
            options.View = ProjectView.GetDefaultResourceSheetView()

            Dim column2 As ResourceViewColumn = TryCast(options.View.Columns(2), ResourceViewColumn)
            column2.StringAlignment = StringAlignment.Center
            column2 = TryCast(options.View.Columns(3), ResourceViewColumn)
            column2.StringAlignment = StringAlignment.Far
            column2 = TryCast(options.View.Columns(4), ResourceViewColumn)
            column2.StringAlignment = StringAlignment.Far

            project.Save(dataDir & "AlignCellContents_ResourceSheet_out.pdf", options)
            ' ExEnd:AlignCellContents
        End Sub
    End Class
End Namespace