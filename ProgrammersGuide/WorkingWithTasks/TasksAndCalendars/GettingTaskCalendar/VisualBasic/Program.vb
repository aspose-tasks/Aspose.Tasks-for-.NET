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

Namespace GettingTaskCalendar
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			Dim rdr As New ProjectReader()
			Dim St As New FileStream(dataDir & "project.mpp", FileMode.Open)
			Dim prj As Project = rdr.Read(St)
			St.Close()
			Dim alTasks As ArrayList = prj.RootTask.Children
			For Each tskCh As Task In alTasks
				'code to display tskCh.Calendar properties
				Console.WriteLine("Calendar Name: " & tskCh.Calendar.Name)
				Console.WriteLine("Calendar Uid: " & tskCh.Calendar.Uid)

			Next tskCh

		End Sub
	End Class
End Namespace