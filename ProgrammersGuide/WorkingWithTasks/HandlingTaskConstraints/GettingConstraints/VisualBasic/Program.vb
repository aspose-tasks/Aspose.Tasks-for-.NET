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

Namespace GettingConstraints
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			Dim rdr As New ProjectReader()
			Dim St As New FileStream(dataDir & "project.mpp", FileMode.Open)
			Dim prj As Project = rdr.Read(St)
			St.Close()

			' Create a ChildTasksCollector instance
			Dim collector As New ChildTasksCollector()

			' Collect all the tasks from RootTask using TaskUtils
			TaskUtils.Apply(prj.RootTask, collector, 0)

			' Parse through all the collected tasks
			For Each tsk As Task In collector.Tasks
				If tsk.ConstraintDate.ToShortDateString() = "1/1/2000" Then
					Console.WriteLine("NA")
				Else
					Console.WriteLine(tsk.ConstraintDate.ToShortDateString())
				End If
				Console.WriteLine(tsk.ConstraintType.ToString())

			Next tsk

		End Sub
	End Class
End Namespace