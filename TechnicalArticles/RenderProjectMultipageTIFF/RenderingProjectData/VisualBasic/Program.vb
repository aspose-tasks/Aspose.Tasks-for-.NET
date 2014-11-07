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
Imports System
Imports Aspose.Tasks.Saving

Namespace RenderingProjectDataExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Source File to Render
			Dim file As String = dataDir & "RenderMe.mpp"

			Dim reader As New ProjectReader()

			'Read the Project
			Dim project As Project = reader.Read(file)

			'Select a Presentation format - Any other can be selected as well
			Dim format As PresentationFormat = PresentationFormat.GanttChart

			'Render the project to all Pre-Defined page sizes
			For Each pageSize As PageSize In CType(System.Enum.GetValues(GetType(PageSize)), PageSize())
				Dim options As New PdfSaveOptions()
				options.PresentationFormat = format
				options.FitContent = True
				options.PageSize = pageSize
				Dim resFile As String = dataDir & "result_" & format.ToString() & "_" & pageSize.ToString() & ".pdf"
				project.Save(resFile, options)
			Next pageSize


		End Sub
	End Class
End Namespace