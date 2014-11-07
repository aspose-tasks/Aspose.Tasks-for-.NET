'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Tasks
Imports Aspose.Tasks.Visualization
Imports Aspose.Tasks.Saving
Imports System.Drawing

Namespace AlignCellContentsExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			Dim project As New Project(dataDir & "RenderMe.mpp") ' attached test project
			Dim options As SaveOptions = New PdfSaveOptions()
			options.Timescale = Timescale.Months
			options.View = ProjectView.GetDefaultGanttChartView()

			Dim col As GanttChartColumn = TryCast(options.View.Columns(2), GanttChartColumn)
			col.StringAlignment = StringAlignment.Center
			col = TryCast(options.View.Columns(3), GanttChartColumn)
			col.StringAlignment = StringAlignment.Far
			col = TryCast(options.View.Columns(4), GanttChartColumn)
			col.StringAlignment = StringAlignment.Far

			project.Save(dataDir & "result GanttChart.pdf", options)

			options.PresentationFormat = PresentationFormat.ResourceSheet

			Dim col1 As ResourceViewColumn = TryCast(options.View.Columns(2), ResourceViewColumn)
			col1.StringAlignment = StringAlignment.Center
			col1 = TryCast(options.View.Columns(3), ResourceViewColumn)
			col1.StringAlignment = StringAlignment.Far
			col1 = TryCast(options.View.Columns(4), ResourceViewColumn)
			col1.StringAlignment = StringAlignment.Far

			project.Save(dataDir & "result ResourceSheet.pdf", options)

		End Sub
	End Class
End Namespace