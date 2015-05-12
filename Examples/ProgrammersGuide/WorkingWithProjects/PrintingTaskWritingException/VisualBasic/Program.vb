'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Tasks
Imports System

Namespace PrintingTaskWritingExceptionExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			Dim project As New Project(dataDir & "project.mpp")

			Try
				project.Save("project.MPP", Aspose.Tasks.Saving.SaveFileFormat.MPP)
			Catch ex As TasksWritingException
				Console.WriteLine(ex.LogText)
			End Try

		End Sub
	End Class
End Namespace