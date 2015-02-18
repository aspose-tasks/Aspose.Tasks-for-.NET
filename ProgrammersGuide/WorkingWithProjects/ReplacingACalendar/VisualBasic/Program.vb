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

Namespace ReplacingACalendarExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			Dim project As Project = New Project(dataDir & "project.mpp")

			Dim cal As Aspose.Tasks.Calendar = New Aspose.Tasks.Calendar("New Cal")
			Dim calColl As CalendarCollection = project.Calendars
			For Each c As Aspose.Tasks.Calendar In calColl
				If c.Name = "Standard" Then
					calColl.Remove(c)
					calColl.Add("Standard", cal)
					Exit For
				End If
			Next c


		End Sub
	End Class
End Namespace