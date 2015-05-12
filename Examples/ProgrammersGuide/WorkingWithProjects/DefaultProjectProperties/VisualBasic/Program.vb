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

Namespace DefaultProjectProperties
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			Dim prj As New Project(dataDir & "project.mpp")

			'Display default properties
			Console.WriteLine("New Task Default Start: " & prj.Get(Prj.DefaultStartTime).ToShortDateString())
			Console.WriteLine("New Task Default Type: " & prj.Get(Prj.DefaultTaskType))
			Console.WriteLine("Resouce Default Standard Rate: " & prj.Get(Prj.DefaultStandardRate).ToString())
			Console.WriteLine("Resource Default Overtime Rate: " & prj.Get(Prj.DefaultOvertimeRate).ToString())
			Console.WriteLine("Default Task EV Method: " & prj.Get(Prj.DefaultTaskEVMethod).ToString())
			Console.WriteLine("Default Cost Accrual: " & prj.Get(Prj.DefaultFixedCostAccrual).ToString())
		End Sub
	End Class
End Namespace