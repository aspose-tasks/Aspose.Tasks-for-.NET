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

Namespace ManagingDurations
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			'Create a project instance
			Dim prj As New Project()
			prj.MinutesPerDay = 480
			'Define Tasks
			Dim rootTsk As New Task()
			Dim tsk1 As New Task("Task1")

			tsk1.ActualStart = DateTime.Parse("01-Jun-00 8:00 AM")
			tsk1.Duration = New TimeSpan(8, 0, 0)
			tsk1.DurationFormat = TimeUnitType.Day

			'Add tsk1 to the rootTsk
			rootTsk.Children.Add(tsk1)
			'Set rootTsk as root task of the project
			prj.RootTask = rootTsk
			'Perform recalculations
			prj.CalcTaskIds()
			prj.CalcTaskUids()

			'Save the Project
			prj.Save(dataDir & "Project.Xml", Aspose.Tasks.Saving.SaveFileFormat.XML)

		End Sub
	End Class
End Namespace