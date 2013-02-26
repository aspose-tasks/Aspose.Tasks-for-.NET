'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Tasks
Imports Aspose.Tasks.Util

Namespace AddRemoveTasks
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Create a project reader instance
			Dim rdr As New ProjectReader()

			'Call the Read method of project reader object to get project object
			Dim St As New FileStream(dataDir & "project.mpp", FileMode.Open)
			Dim prj As Project = rdr.Read(St)
			St.Close()

			'Remove a task
			If prj.RootTask.Children.Count > 1 Then
				prj.RootTask.Children.RemoveAt(0)
			End If

			'Add a task
			Dim tskADD As New Task("Added")
			tskADD.Start = New Date(2009, 8, 1)
			tskADD.Finish = New Date(2009, 8, 5)
			prj.RootTask.Children.Add(tskADD)

			'Display task
			' Create a ChildTasksCollector instance
			Dim collector As New ChildTasksCollector()

			' Collect all the tasks from RootTask using TaskUtils
			TaskUtils.Apply(prj.RootTask, collector, 0)

			' Parse through all the collected tasks
			For Each tsk As Task In collector.Tasks
				System.Console.WriteLine("Task Name" & tsk.Name)
				System.Console.WriteLine("Start" & tsk.Start.ToShortDateString())
				System.Console.WriteLine("Finish" & tsk.Finish.ToShortDateString())
			Next tsk

			' Display Status.
			System.Console.WriteLine("Processing completed successfully.")
		End Sub
	End Class
End Namespace