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

Namespace DefiningRootTask
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

			'Define a Task and set it as Root Task
			Dim rootTsk As New Task()
			prj.RootTask = rootTsk

			'Define Tasks
			Dim tsk1 As New Task("Task1")
			tsk1.Start = DateTime.Now
			Dim tsk2 As New Task("Task2")
			tsk2.Start = DateTime.Now

			'Add tsk1 and tsk2 to the rootTsk
			rootTsk.Children.Add(tsk1)
			rootTsk.Children.Add(tsk2)

			'Perform recalculations
			prj.CalcTaskIds()
			prj.CalcTaskUids()

			'Save the project as XML project file
			prj.Save(dataDir & "project.xml", Aspose.Tasks.Saving.SaveFileFormat.XML)
		End Sub
	End Class
End Namespace