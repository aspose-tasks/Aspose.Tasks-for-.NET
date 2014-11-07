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

Namespace OvertimeRemainingCostsWork
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Create a project reader instance
			Dim rdr As New ProjectReader()
			'Call read method of project reader object to get project object
			Dim St As New FileStream(dataDir & "project.mpp", FileMode.Open)
			Dim prj As Project = rdr.Read(St)
			St.Close()

			Dim alra As ArrayList = prj.ResourceAssignments
			For Each ra As ResourceAssignment In alra
				Console.WriteLine(ra.OvertimeCost)
				Console.WriteLine(ra.OvertimeWork.ToString())
				Console.WriteLine(ra.RemainingCost)
				Console.WriteLine(ra.RemainingOvertimeCost)
				Console.WriteLine(ra.RemainingOvertimeWork.ToString())
				Console.WriteLine(ra.RemainingOvertimeWork.ToString())
			Next ra



		End Sub
	End Class
End Namespace