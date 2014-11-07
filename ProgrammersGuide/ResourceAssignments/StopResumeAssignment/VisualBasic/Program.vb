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

Namespace StopResumeAssignment
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			Dim rdr As New ProjectReader()
			Dim St As New FileStream(dataDir & "project.mpp", FileMode.Open)
			Dim prj As Project = rdr.Read(St)
			St.Close()
			Dim alra As ArrayList = prj.ResourceAssignments
			For Each ra As ResourceAssignment In alra
				If ra.Stop.ToShortDateString() = "1/1/2000" Then
					Console.WriteLine("NA")
				Else
					Console.WriteLine(ra.Stop.ToShortDateString())
				End If
				If ra.Resume.ToShortDateString() = "1/1/2000" Then
					Console.WriteLine("NA")
				Else
					Console.WriteLine(ra.Resume.ToShortDateString())
				End If
			Next ra

		End Sub
	End Class
End Namespace