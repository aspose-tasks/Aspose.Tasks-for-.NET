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

Namespace TimephasedDataGeneration
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Define a Project Reader Object
			Dim reader As New ProjectReader()

			'Read the source MPP file
			Dim project As Project = reader.Read(dataDir & "project.mpp")

			'Get the first task of the Project
			Dim task As Task = project.GetTaskById(1)

			'Get the First Resource Assignment of the Project
			Dim RA As ResourceAssignment = CType(project.ResourceAssignments(0), ResourceAssignment)

			' Flat contour is default contour
			Console.WriteLine("Flat contour")
			For Each td As TimephasedData In task.TimeScaleData(project.StartDate, project.FinishDate)
				Console.WriteLine(td.Start.ToShortDateString() & " " & td.Value)
			Next td

			' Change contour
			RA.WorkContour = WorkContourType.Turtle
			Console.WriteLine("Turtle contour")
			For Each td As TimephasedData In task.TimeScaleData(project.StartDate, project.FinishDate)
				Console.WriteLine(td.Start.ToShortDateString() & " " & td.Value)
			Next td

			' Change contour
			RA.WorkContour = WorkContourType.BackLoaded
			Console.WriteLine("BackLoaded contour")
			For Each td As TimephasedData In task.TimeScaleData(project.StartDate, project.FinishDate)
				Console.WriteLine(td.Start.ToShortDateString() & " " & td.Value)
			Next td

			' Change contour
			RA.WorkContour = WorkContourType.FrontLoaded
			Console.WriteLine("FrontLoaded contour")
			For Each td As TimephasedData In task.TimeScaleData(project.StartDate, project.FinishDate)
				Console.WriteLine(td.Start.ToShortDateString() & " " & td.Value)
			Next td

			' Change contour
			RA.WorkContour = WorkContourType.Bell
			Console.WriteLine("Bell contour")
			For Each td As TimephasedData In task.TimeScaleData(project.StartDate, project.FinishDate)
				Console.WriteLine(td.Start.ToShortDateString() & " " & td.Value)
			Next td

			' Change contour
			RA.WorkContour = WorkContourType.EarlyPeak
			Console.WriteLine("EarlyPeak contour")
			For Each td As TimephasedData In task.TimeScaleData(project.StartDate, project.FinishDate)
				Console.WriteLine(td.Start.ToShortDateString() & " " & td.Value)
			Next td

			' Change contour
			RA.WorkContour = WorkContourType.LatePeak
			Console.WriteLine("LatePeak contour")
			For Each td As TimephasedData In task.TimeScaleData(project.StartDate, project.FinishDate)
				Console.WriteLine(td.Start.ToShortDateString() & " " & td.Value)
			Next td
			' Change contour
			RA.WorkContour = WorkContourType.DoublePeak
			Console.WriteLine("DoublePeak contour")
			For Each td As TimephasedData In task.TimeScaleData(project.StartDate, project.FinishDate)
				Console.WriteLine(td.Start.ToShortDateString() & " " & td.Value)
			Next td

		End Sub
	End Class
End Namespace