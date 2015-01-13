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
Imports System

Namespace CalculateCriticalPathExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			Dim project As New Project(dataDir & "project.mpp")
			project.CalculationMode = CalculationMode.Automatic

			Dim subtask1 As Task = project.RootTask.Children.Add("1")
			Dim subtask2 As Task = project.RootTask.Children.Add("2")
			Dim subtask3 As Task = project.RootTask.Children.Add("3")

			project.TaskLinks.Add(subtask1, subtask2, TaskLinkType.FinishToStart)

			'Display the critical path now
			For Each task As Task In project.CriticalPath
				Console.WriteLine(task.Get(Tsk.Name))
			Next task
		End Sub
	End Class
End Namespace