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
Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization
Imports System.Drawing
Imports System.Collections.Generic

Namespace CustomizeTextWithTaskBarsExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			Dim project As New Project()

			Dim task1 As Task = project.AddTask("Task 1")
			Dim task2 As Task = project.AddTask("Task 2")

			task2.Duration = TimeSpan.FromDays(1)
			task1.Duration = task2.Duration

			Dim link As New TaskLink(task1, task2, TaskLinkType.FinishToStart)
			project.AddTaskLink(link)

			Dim task3 As Task = project.AddTask("Task 3")

			Dim rsc1 As Resource = project.AddResource("Resource 1")
			Dim rsc2 As Resource = project.AddResource("Resource 2")
			Dim rsc3 As Resource = project.AddResource("Resource 3")

			project.AddResourceAssignment(task1, rsc1)
			project.AddResourceAssignment(task2, rsc2)
			project.AddResourceAssignment(task3, rsc3)

			Dim options As SaveOptions = New PdfSaveOptions()
			options.Timescale = Timescale.ThirdsOfMonths

			Dim style As New BarStyle()
			style.ItemType = BarItemType.CriticalTask

			style.BarTextConverter = AddressOf AnonymousMethod1

			Dim style2 As New BarStyle()
			style2.BarColor = Color.DarkOrchid
			style2.ItemType = BarItemType.Task

			options.BarStyles = New List(Of BarStyle)()
			options.BarStyles.Add(style)
			options.BarStyles.Add(style2)

			project.Save(dataDir & "result2.pdf", options)


		End Sub
		'TODO: INSTANT VB TODO TASK: The return type of this anonymous method could not be determined by Instant VB:
		Private Shared Function AnonymousMethod1(ByVal t As Task) As Object
			Return String.Format("task ""{0}"" is on critical path", t.Name)
		End Function
	End Class
End Namespace