'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Tasks

Namespace DefaultProjectProperties
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' 1.
			' Reading Default Properties
			'Create a project reader instance
			Dim rdr As New ProjectReader()

			'Call the Read method of project reader object to get project object
			Dim St As New FileStream(dataDir & "project.mpp", FileMode.Open)
			Dim prj As Project = rdr.Read(St)
			St.Close()

			'Display default properties
			Console.WriteLine("New Task Default Start: " & prj.DefaultStartTime.ToShortDateString())
			Console.WriteLine("New Task Default Type: " & prj.DefaultTaskType.ToString())
			Console.WriteLine("Resource Default Standard Rate: " & prj.DefaultStandardRate.ToString())
			Console.WriteLine("Resource Default Overtime Rate: " & prj.DefaultOvertimeRate.ToString())
			Console.WriteLine("Default Task EV Method: " & prj.DefaultTaskEVMethod.ToString())
			Console.WriteLine("Default Cost Accrual: " & prj.DefaultFixedCostAccrual.ToString())



			' 2.
			' Writing Default Properties
			'Create a project instance
			Dim prj1 As New Project()

			'Set default properties
			prj1.IsScheduleFromStart = True
			prj1.StartDate = Date.Now
			prj1.DefaultStartTime = prj.StartDate
			prj1.DefaultTaskType = TaskType.FixedDuration
			prj1.DefaultStandardRate = 15
			prj1.DefaultOvertimeRate = 12
			prj1.DefaultTaskEVMethod = EarnedValueMethodType.PercentComplete
			prj1.DefaultFixedCostAccrual = CostAccrualType.Prorated

			'Save the project to XML format
			prj1.Save(dataDir & "project.xml", Aspose.Tasks.Saving.SaveFileFormat.XML)
		End Sub
	End Class
End Namespace