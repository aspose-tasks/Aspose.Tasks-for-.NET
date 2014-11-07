'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Aspose.Tasks
Imports Aspose.Tasks.Visualization
Imports System.Collections
Imports System.Drawing
Imports System.IO


Namespace DisplayMultipleColumnsExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
				Dim prg As New Program()
				Dim reader As New ProjectReader()
				Dim project As Project = reader.Read(dataDir & "Project1.mpp")
				'Create the view columns
				Dim columns As New ArrayList()
				columns.Add(New GanttChartColumn("Name", 100, New TaskToColumnTextConverter(AddressOf prg.TaskName)))
				columns.Add(New GanttChartColumn("Notes", 100, New TaskToColumnTextConverter(AddressOf prg.TaskNotes)))
				columns.Add(New GanttChartColumn("Resources", 200, New TaskToColumnTextConverter(AddressOf prg.TaskResources)))
				'Create the view
				Dim view As New ProjectView(columns)
				'Render to image
				Dim res As IRenderResult = project.Export(RenderFormat.Image, PresentationFormat.GanttChart, "project.tiff", New BaseImageRenderParam(Nothing, New Point(), New Size(1200, 800), 100, 0, True), True, Nothing, view)

				'Create a new view
				Dim columns2 As New ArrayList()
				columns2.Add(New GanttChartColumn("Name", 100, New TaskToColumnTextConverter(AddressOf prg.TaskNameHtml)))
				columns2.Add(New GanttChartColumn("Notes", 100, New TaskToColumnTextConverter(AddressOf prg.TaskNotes)))
				columns2.Add(New GanttChartColumn("Resources", 200, New TaskToColumnTextConverter(AddressOf prg.TaskResources)))
				'Create the view
				Dim view2 As New ProjectView(columns2)
				'Render to html
				project.Export(RenderFormat.Html, PresentationFormat.GanttChart, dataDir & "project.html", New BaseImageRenderParam(Nothing, New Point(), New Size(1200, 800), 100, 0, False), True, Nothing, view2)
		End Sub


		''' <summary>
		''' Forms task's name column.
		''' </summary>
		''' <param name="task">Current task.</param>
		''' <returns>Column's text.</returns>
		Private Function TaskName(ByVal task As Task) As String
			Dim res As New StringBuilder()
			For i As Integer = 1 To task.OutlineLevel - 1
				res.Append("  ")
			Next i
			res.AppendFormat("{0}. {1}", task.Id, task.Name)
			Return res.ToString()
		End Function


		''' <summary>
		''' Forms task's name column.
		''' </summary>
		''' <param name="task">Current task.</param>
		''' <returns>Column's text.</returns>
		Private Function TaskNameHtml(ByVal task As Task) As String
			Dim res As New StringBuilder()
			For i As Integer = 1 To task.OutlineLevel - 1
				res.Append("&nbsp;&nbsp;")
			Next i
			res.AppendFormat("{0}. {1}", task.Id, task.Name)
			Return res.ToString()
		End Function


		''' <summary>
		''' Forms task's notes column.
		''' </summary>
		''' <param name="task">Current task.</param>
		''' <returns>Column's text.</returns>
		Private Function TaskNotes(ByVal task As Task) As String
			If task.NotesText IsNot Nothing Then
				Return task.NotesText
			Else
				Return String.Empty
			End If
		End Function


		''' <summary>
		''' Forms task's resources column.
		''' </summary>
		''' <param name="task">Current task.</param>
		''' <returns>Column's text.</returns>
		Private Function TaskResources(ByVal task As Task) As String
			Dim res As New StringBuilder()
			Dim project As Project = task.ParentProject
			Dim bFirst As Boolean = True


			For Each assignment As ResourceAssignment In project.GetResourceAssignmentsByTask(task)
				If assignment.Resource IsNot Nothing Then
					If (Not bFirst) Then
						res.Append(", ")
					End If
					res.Append(assignment.Resource.Name)
					bFirst = False
				End If
			Next assignment
			Return res.ToString()
		End Function
	End Class
End Namespace


