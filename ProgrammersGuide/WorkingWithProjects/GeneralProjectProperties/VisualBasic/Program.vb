'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Tasks

Namespace GeneralProjectProperties
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' 1.
			' Read General Project Properties
			'Create a project reader instance
			Dim rdr As New ProjectReader()

			'Call the read method of project reader object to get project object
			Dim St As New FileStream(dataDir & "project.mpp", FileMode.Open)
			Dim prj As Project = rdr.Read(St)
			St.Close()

			If prj.IsScheduleFromStart Then
				Console.WriteLine("Project Finish Date : " & prj.StartDate.ToShortDateString())
			Else
				Console.WriteLine("Project Finish Date : " & prj.FinishDate.ToShortDateString())
			End If
			Dim strSchdl As String = If(prj.IsScheduleFromStart, "Project Start Date", "Project Finish Date")
			Console.WriteLine("Project Schedule From : " & strSchdl)
			Console.WriteLine("Current Date : " & prj.CurrentDate.ToShortDateString())
			Console.WriteLine("Status Date : " & prj.StatusDate.ToShortDateString())
			Console.WriteLine("Calendar : " & prj.Calendar.Name)

			' 2.
			' Write General Project Properties
			'Create a project instance
			Dim prj1 As New Project()

			'Set project information properties
			prj1.IsScheduleFromStart = True
			prj1.StartDate = New Date(2009, 8, 10)
			prj1.CurrentDate = New Date(2009, 8, 10)
			prj1.StatusDate = New Date(2009, 8, 10)
			Dim cal As Aspose.Tasks.Calendar = Aspose.Tasks.Calendar.MakeStandardCalendar()
			cal.Name = "Standard"
			prj1.Calendars.Add(cal)

			'Save the Project as XML
			prj1.Save(dataDir & "project.xml", Aspose.Tasks.Saving.SaveFileFormat.XML)
		End Sub
	End Class
End Namespace