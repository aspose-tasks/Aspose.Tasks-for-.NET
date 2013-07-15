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

Namespace SettingTaskCalendar
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			Dim project As New Project()
			project.MinutesPerDay = 60 * 8

			'Set project Start and Finish Date
			project.StartDate = New DateTime(2012, 07, 16)
			project.FinishDate = New DateTime(2012, 07, 20)

			'Add root task
			Dim root As New Task()
			project.RootTask = root

			' Add task and set Calendar
			Dim tsk As New Task("Task1")
			Dim cal As New Aspose.Tasks.Calendar("TaskCal1")
			Aspose.Tasks.Calendar.MakeStandardCalendar(cal)
			tsk.Calendar = cal


			root.Children.Add(tsk)

			'We need to recalculate the IDs only as UIDs were set correctly.
			project.CalcTaskIds()
			project.CalcTaskUids()


			project.UpdateReferences()

			'Save the Project
			project.Save(dataDir & "Project.Xml", Aspose.Tasks.Saving.SaveFileFormat.XML)

		End Sub
	End Class
End Namespace