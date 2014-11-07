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

Namespace SavingUpdatedResource
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			Dim reader As New ProjectReader()

			' This is a project with one task and one resource without assignments
			Dim project As Project = reader.Read(dataDir & "project.mpp")

			Dim task As Task = TryCast(project.RootTask.Children(0), Task)
			Dim resource As Resource = TryCast(project.Resources(1), Resource)

			' Add new assignment and recalculate project
			project.ResourceAssignments = New ArrayList(1)
			Dim ra As New ResourceAssignment()
			ra.Units = 1R
			ra.Start = task.Start
			ra.Resume = ra.Start
			ra.Stop = ra.Resume
			ra.Task = task
			ra.Resource = resource
			ra.RemainingWork = New TimeSpan(16, 0, 0)
			ra.RegularWork = ra.RemainingWork
			ra.Work = ra.RegularWork

			ra.Finish = task.Calendar.GetFinishDateByStartAndWork(ra.Start, New TimeSpan(16, 0, 0))
			project.ResourceAssignments.Add(ra)

			task.RemainingWork = ra.Work
			task.Duration = task.RemainingWork
			task.Finish = project.Calendar.GetFinishDateByStartAndWork(task.Start, task.Duration)

			'Recalculate the Project now
			project.CalcTaskIds()
			project.CalcTaskUids()
			project.CalcResourceIds()
			project.CalcResourceUids()
			project.CalcResourceAssignmentIds()
			project.CalcResourceAssignmentUids()
			project.CalcCalendarUids()
			project.UpdateReferences()

			'Update the Resource Assignment data now
			ra.WorkContour = WorkContourType.Flat
			ra.TimephasedData = New ArrayList()
			Dim td As New TimephasedData()
			td.Uid = 1
			td.Start = ra.Start
			td.Finish = ra.Start.AddHours(9)
			td.Value = "PT8H0M0S"
			td.Unit = TimeUnitType.Day
			td.TimephasedDataType = TimephasedDataType.AssignmentRemainingWork
			ra.TimephasedData.Add(td)
			td = New TimephasedData()
			td.Uid = 2
			td.Start = ra.Start.AddDays(1)
			td.Finish = ra.Start.AddDays(1).AddHours(9)
			td.Value = "PT8H0M0S"
			td.Unit = TimeUnitType.Day
			td.TimephasedDataType = TimephasedDataType.AssignmentRemainingWork
			ra.TimephasedData.Add(td)

			'Save the Project
			project.Save(dataDir & "Project1.Mpp", Aspose.Tasks.Saving.SaveFileFormat.MPP)

		End Sub
	End Class
End Namespace