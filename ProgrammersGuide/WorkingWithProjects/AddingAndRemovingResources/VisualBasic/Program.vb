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

Namespace AddingAndRemovingResources
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Create a project reader instance
			Dim rdr As New ProjectReader()

			'Call the Read method of project reader object to get project object
			Dim St As New FileStream(dataDir & "project.mpp", FileMode.Open)
			Dim prj As Project = rdr.Read(St)
			St.Close()

			'Remove a resource
			If prj.Resources.Count > 1 Then
				prj.Resources.RemoveAt(0)
			End If

			'Add a resource
			Dim recADD As New Resource("Added")
			recADD.Type = ResourceType.Work
			prj.Resources.Add(recADD)

			'Display resources
			Dim alRecs As ArrayList = prj.Resources

			For Each rec As Resource In alRecs
				If rec.Name IsNot Nothing Then
					Console.WriteLine("Res Name" & rec.Name)
					Console.WriteLine("Res Type" & rec.Type.ToString())
				End If
			Next rec

		End Sub
	End Class
End Namespace