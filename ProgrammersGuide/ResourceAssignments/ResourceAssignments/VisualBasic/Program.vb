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
Imports System

Namespace ResourceAssignments
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			Dim prj As New Project()

			'Set project Start and Finish Date
			prj.StartDate = New DateTime(2012, 07, 16)
			prj.FinishDate = New DateTime(2012, 07, 20)

			'Add root task
			Dim root As New Task()
			prj.RootTask = root

			'Add child task
			Dim task As New Task("Task1")
			task.ActualStart = DateTime.Parse("16-Jul-2012 9:00 AM")

			'Set duration in hours
			task.Duration = New TimeSpan(24, 0, 0)
			task.DurationFormat = TimeUnitType.Day
			root.Children.Add(task)

			Dim ra As New ResourceAssignment()
			Dim res As New Resource("Resource1")
			prj.Resources.Add(res)
			ra.Task = task
			ra.Resource = res

			prj.Save(dataDir & "Project.Xml", Aspose.Tasks.Saving.SaveFileFormat.XML)

		End Sub
	End Class
End Namespace