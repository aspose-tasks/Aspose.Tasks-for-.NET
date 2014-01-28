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

Namespace DefiningWeekdays
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			'Create a project instance
			Dim prj As New Project()

			'Define Calendar
			Dim cal As New Aspose.Tasks.Calendar()
			cal.Uid = 1
			cal.Name = "Calendar1"
			prj.Calendars.Add(cal)

			'Add working days monday through thursday with default timings
			cal.Days.Add(WeekDay.CreateDefaultWorkingDay(DayType.Monday))
			cal.Days.Add(WeekDay.CreateDefaultWorkingDay(DayType.Tuesday))
			cal.Days.Add(WeekDay.CreateDefaultWorkingDay(DayType.Wednesday))
			cal.Days.Add(WeekDay.CreateDefaultWorkingDay(DayType.Thursday))
			cal.Days.Add(New WeekDay(DayType.Saturday))
			cal.Days.Add(New WeekDay(DayType.Sunday))

			'Set friday as short working day
			Dim myWeekDay As New WeekDay(DayType.Friday)

			'Sets working time. Only time part of DateTime is important
			Dim wt1 As New WorkingTime()
			wt1.FromTime = New DateTime(1, 1, 1, 9, 0, 0, 0)
			wt1.ToTime = New DateTime(1, 1, 1, 12, 0, 0, 0)
			Dim wt2 As New WorkingTime()
			wt2.FromTime = New DateTime(1, 1, 1, 13, 0, 0, 0)
			wt2.ToTime = New DateTime(1, 1, 1, 16, 0, 0, 0)
			myWeekDay.WorkingTimes.Add(wt1)
			myWeekDay.WorkingTimes.Add(wt2)
			myWeekDay.DayWorking = True
			cal.Days.Add(myWeekDay)
			prj.CalcCalendarUids()

			'Save the Project
			prj.Save(dataDir & "Project.Xml", Aspose.Tasks.Saving.SaveFileFormat.XML)


		End Sub
	End Class
End Namespace