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
Imports Aspose.Tasks.Util
Imports System

Namespace RetrievingTaskInformation
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create a project reader instance
			Dim reader As New ProjectReader()

			' Read the project file
			Dim project As Project = reader.Read(dataDir & "Project.mpp")

			' Create a ChildTasksCollector instance
			Dim collector As New ChildTasksCollector()

			' Collect all the tasks from RootTask using TaskUtils 
			TaskUtils.Apply(project.RootTask, collector, 0)

			' Parse through all the collected tasks
			For Each task As Task In collector.Tasks
				Console.WriteLine("Task Name : " & task.Name)
				Console.WriteLine("Start : " & task.Start.ToShortDateString())
				Console.WriteLine("Finish : " & task.Finish.ToShortDateString())
			Next task

		End Sub
	End Class
End Namespace