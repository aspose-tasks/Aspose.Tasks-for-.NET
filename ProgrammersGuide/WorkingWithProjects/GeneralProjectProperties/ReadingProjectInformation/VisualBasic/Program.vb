'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO
Imports System
Imports Aspose.Tasks

Namespace ReadingProjectInformationExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Create a project reader instance
			Dim rdr As New ProjectReader()

			'Call the read method of project reader object to get project object
			Dim St As New FileStream(dataDir & "input.xml", FileMode.Open)
			Dim prj As Project = rdr.Read(St)
			St.Close()
			Dim cal As Aspose.Tasks.Calendar = Aspose.Tasks.Calendar.Make24HourCalendar()

			If prj.IsScheduleFromStart Then
				Console.WriteLine("Project Finish Date : " & prj.StartDate.ToShortDateString())
			Else
				Console.WriteLine("Project Finish Date : " & prj.FinishDate.ToShortDateString())
			End If
			Dim strSchdl As String = If((prj.IsScheduleFromStart), "Project Start Date", "Project Finish Date")
			Console.WriteLine("Project Schedule From : " & strSchdl)
			Console.WriteLine("Current Date : " & prj.CurrentDate.ToShortDateString())
			Console.WriteLine("Status Date : " & prj.StatusDate.ToShortDateString())
			Console.WriteLine("Calendar : " & cal.Name)
			Console.WriteLine("The program has run successfully")

		End Sub
	End Class
End Namespace