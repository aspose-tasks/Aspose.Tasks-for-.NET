'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Tasks

Namespace WeekdayProperties
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")


			' 1.
			' Reading Weekday Properties
			'Create a project reader instance
			Dim rdr As New ProjectReader()

			'Call the Read method of project reader object to get project object
			Dim St As New FileStream(dataDir & "project.mpp", FileMode.Open)
			Dim prj As Project = rdr.Read(St)
			St.Close()

			'Display week days properties
			Console.WriteLine("Week Start Date : " & prj.WeekStartDay.ToString())
			Console.WriteLine("Days Per Month : " & prj.DaysPerMonth.ToString())
			Console.WriteLine("Minutes Per Day : " & prj.MinutesPerDay.ToString())
			Console.WriteLine("Minutes Per Month : " & prj.MinutesPerWeek.ToString())


			' 2.
			' Writing Weekday Properties
			'Create a project instance
			Dim prj1 As New Project()

			'Set week days properties
			prj1.WeekStartDay = DayType.Monday
			prj1.DaysPerMonth = 24
			prj1.MinutesPerDay = 540
			prj1.MinutesPerWeek = 3240

			'Save the project as XML project file
			prj1.Save(dataDir & "savedProject.xml", Aspose.Tasks.Saving.SaveFileFormat.XML)
		End Sub
	End Class
End Namespace