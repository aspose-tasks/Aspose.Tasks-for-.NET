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
Imports System.Collections.Generic

Namespace ResourceCost
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

			Dim alRes As List(Of Resource) = prj.Resources
			For Each res As Resource In alRes
				If res.Name IsNot Nothing Then
					Console.WriteLine(res.Cost)
					Console.WriteLine(res.Acwp)
					Console.WriteLine(res.Bcwp)
					Console.WriteLine(res.Bcws)
					Console.WriteLine(res.AccrueAt.ToString())
				End If
			Next res



		End Sub
	End Class
End Namespace