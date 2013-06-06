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
Imports System

Namespace RetrievingTaskLinks
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create a project reader instance
			Dim rdr As New ProjectReader()

			' Call read method of project reader to open the project
			Dim prj As Project = rdr.Read(dataDir & "Project.mpp")

			' Retrieve task links
			Dim alTskLnk As ArrayList = prj.TaskLinks
			For Each tskLnk As TaskLink In alTskLnk
				Console.WriteLine("Pred Task : " & tskLnk.PredTask.Name)
				Console.WriteLine("Succ Task : " & tskLnk.SuccTask.Name)
			Next tskLnk

		End Sub
	End Class
End Namespace