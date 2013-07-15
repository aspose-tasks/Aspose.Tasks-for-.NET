'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Tasks
Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization
Imports System

Namespace SettingConstraints
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Reading a project file
			Dim rdr As New ProjectReader()
			Dim St As New FileStream(dataDir & "project.mpp", FileMode.Open)
			Dim project As Project = rdr.Read(St)
			St.Close()

			'Setting Save Option
			Dim o As SaveOptions = New PdfSaveOptions()
			o.StartDate = project.StartDate
			o.Timescale = Timescale.ThirdsOfMonths

			'Get Task by ID
			Dim summary As Task = project.GetTaskById(7)

			'Set Constraint
			summary.ConstraintType = ConstraintType.StartNoEarlierThan
			summary.ConstraintDate = New DateTime(2013, 6, 3, 9, 0, 0)
			Task.Recalculate(project.RootTask)

			'Save to PDF file
			project.Save(dataDir & "summary SNET June 3.pdf", o)
		End Sub
	End Class
End Namespace