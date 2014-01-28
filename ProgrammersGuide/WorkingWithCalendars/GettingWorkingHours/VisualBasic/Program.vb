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

Namespace GettingWorkingHours
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			Dim reader As New ProjectReader()
			Dim project As Project = reader.Read(dataDir & "Project.mpp")

			Dim task As Task = project.GetTaskById(1)

			Dim taskCalendar As Aspose.Tasks.Calendar = task.Calendar
			Dim startDate As DateTime = task.Start
			Dim endDate As DateTime = task.Finish
			Dim tempDate As DateTime = startDate

			Dim resource As Resource = project.GetResourceByUid(1)
			Dim resourceCalendar As Aspose.Tasks.Calendar = resource.Calendar

			Dim timeSpan As TimeSpan

			'Get Duration in Minutes
			Dim durationInMins As Double = 0

			Do While tempDate < endDate
				If taskCalendar.IsDayWorking(tempDate) AndAlso resourceCalendar.IsDayWorking(tempDate) Then
					timeSpan = taskCalendar.GetWorkingHours(tempDate)
					durationInMins = durationInMins + timeSpan.TotalMinutes
				End If
				tempDate = tempDate.AddDays(1)
			Loop
			tempDate = startDate

			'Get Duration in Hours

			Dim durationInHours As Double = 0

			Do While tempDate < endDate
				If taskCalendar.IsDayWorking(tempDate) AndAlso resourceCalendar.IsDayWorking(tempDate) Then
					timeSpan = taskCalendar.GetWorkingHours(tempDate)
					durationInHours = durationInHours + timeSpan.TotalHours
				End If
				tempDate = tempDate.AddDays(1)
			Loop
			tempDate = startDate

			'Get Duration in Days
			Dim durationInDays As Double = 0

			Do While tempDate < endDate
				If taskCalendar.IsDayWorking(tempDate) AndAlso resourceCalendar.IsDayWorking(tempDate) Then
					timeSpan = taskCalendar.GetWorkingHours(tempDate)
					If timeSpan.TotalHours > 0 Then
						durationInDays = durationInDays + timeSpan.TotalDays * (24 / (timeSpan.TotalHours))
					End If
				End If
				tempDate = tempDate.AddDays(1)
			Loop
			tempDate = startDate

			Console.WriteLine("Duration in Minutes = " & durationInMins)
			Console.WriteLine("Duration in Hours = " & durationInHours)
			Console.WriteLine("Duration in Days = " & durationInDays)
			Console.ReadLine()

		End Sub
	End Class
End Namespace