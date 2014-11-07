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

Namespace SettingProperties
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			Dim prj As New Project()

			Dim tskRoot As New Task()
			Dim tsk1 As New Task("Task1")
			Dim tsk2 As New Task("Task2")

			Dim res As New Resource()
			Dim res1 As New Resource("Resource1")

			Dim ra1 As New ResourceAssignment(tsk1, res1)
			ra1.Start = DateTime.Parse("18-Aug-2009 8:00 AM")
			ra1.Finish = DateTime.Parse("18-Aug-2009 5:00 PM")
			ra1.Uid = 1

			Dim ra2 As New ResourceAssignment(tsk2, res1)
			ra2.Start = DateTime.Parse("19-Aug-2009 8:00 AM")
			ra2.Finish = DateTime.Parse("19-Aug-2009 5:00 PM")
			ra2.Uid = 2

			prj.RootTask = tskRoot
			prj.RootTask.Children.Add(tsk1)
			prj.RootTask.Children.Add(tsk2)

			prj.Resources.Add(res)
			prj.Resources.Add(res1)

			prj.ResourceAssignments.Add(ra1)
			prj.ResourceAssignments.Add(ra2)

			prj.CalcResourceUids()
			prj.CalcTaskIds()
			prj.CalcTaskUids()
			prj.CalcResourceUids()
			prj.CalcResourceStartFinish()
			prj.CalcResourceIds()
			prj.CalcResourceFields()
			prj.CalcResourceAssignmentUids()
			prj.CalcResourceAssignmentIds()

			'Save the Project
			prj.Save(dataDir & "Project.Xml", Aspose.Tasks.Saving.SaveFileFormat.XML)

		End Sub
	End Class
End Namespace