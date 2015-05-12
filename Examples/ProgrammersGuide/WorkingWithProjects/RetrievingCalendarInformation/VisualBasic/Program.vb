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
Imports System.Collections.Generic

Namespace RetrievingCalendarInformation
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Create a project reader instance
			Dim project As New Project(dataDir & "project.mpp")

			'Retrieve Calendars Information
			Dim alCals As CalendarCollection = project.Calendars
			For Each cal As Aspose.Tasks.Calendar In alCals
				If cal.Name IsNot Nothing Then
					Console.WriteLine("Calendar UID : " & cal.Uid)
					Console.WriteLine("Calendar Name : " & cal.Name)

					Dim alDays As WeekDayCollection = cal.WeekDays
					For Each wd As WeekDay In alDays
						Dim ts As TimeSpan = wd.GetWorkingTime()
						If wd.DayWorking Then
							Console.WriteLine(wd.DayType.ToString() & ":")
							Console.WriteLine(ts.ToString())
						End If
					Next wd
				End If


			Next cal
		End Sub
	End Class
End Namespace