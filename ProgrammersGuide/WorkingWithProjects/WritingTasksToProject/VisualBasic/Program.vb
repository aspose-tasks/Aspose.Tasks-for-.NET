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

Namespace WritingTasksToProject
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'create a project instance
			Dim prj As New Project()

			'Define Tasks
			Dim rootTsk As New Task()
			Dim tsk1 As New Task("Task1")
			tsk1.Start = DateTime.Now
			Dim tsk2 As New Task("Task2")
			tsk2.Start = DateTime.Now

			'Add tsk1 and tsk2 to the rootTsk
			rootTsk.Children.Add(tsk1)
			rootTsk.Children.Add(tsk2)

			'Set rootTsk as root task of the project
			prj.RootTask = rootTsk

			'Perform recalculations
			prj.CalcTaskIds()
			prj.CalcTaskUids()

			'Save the project as XML project file
			prj.Save(dataDir & "project.xml", Aspose.Tasks.Saving.SaveFileFormat.XML)

		End Sub
	End Class
End Namespace