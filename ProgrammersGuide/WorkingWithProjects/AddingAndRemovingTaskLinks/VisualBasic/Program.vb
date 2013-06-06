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
Imports System.Collections

Namespace AddingAndRemovingTaskLinks
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

			'Remove existing task links
			Dim alTskLnk As New ArrayList()
			For Each tskLnk As TaskLink In prj.TaskLinks
				alTskLnk.Add(tskLnk)
			Next tskLnk
			For Each tlnk As TaskLink In alTskLnk
				prj.RemoveLink(tlnk)
			Next tlnk

			'Define new Tasks
			Dim tsk3 As New Task("Task13")
			Dim tsk4 As New Task("Task14")

			'Add tsk3 and tsk4 to the project
			prj.RootTask.Children.Add(tsk3)
			prj.RootTask.Children.Add(tsk4)

			'Define link between tsk3 and tsk4
			Dim tskLnkNew As New TaskLink(tsk3, tsk4, TaskLinkType.FinishToFinish)

			'Add new Task link to project
			prj.AddTaskLink(tskLnkNew)

			'Perform recalculations
			prj.CalcTaskIds()
			prj.CalcTaskUids()

			'Save the project as XML project file
			prj.Save(dataDir & "project.xml", Aspose.Tasks.Saving.SaveFileFormat.XML)
		End Sub
	End Class
End Namespace