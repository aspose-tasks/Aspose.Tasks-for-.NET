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

Namespace GettingGeneralProperties
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			Dim rdr As New ProjectReader()
			Dim St As New FileStream(dataDir & "project.mpp", FileMode.Open)
			Dim prj As Project = rdr.Read(St)
			St.Close()


			' Create a ChildTasksCollector instance
			Dim collector As New ChildTasksCollector()

			' Collect all the tasks from RootTask using TaskUtils
			TaskUtils.Apply(prj.RootTask, collector, 0)

			' Parse through all the collected tasks
			For Each tskCh As Task In collector.Tasks
				'code to display task properties
				Console.WriteLine("Task Id: " & tskCh.Id)
				Console.WriteLine("Task Uid: " & tskCh.Uid)
				Console.WriteLine("Task Name: " & tskCh.Name)
				Console.WriteLine("Task Start: " & tskCh.Start)
				Console.WriteLine("Task Finish: " & tskCh.Finish)
			Next tskCh

		End Sub
	End Class
End Namespace