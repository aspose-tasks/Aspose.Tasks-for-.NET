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

Namespace IdentifyCrossProjectTasks
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")


			Dim reader As New ProjectReader()
Dim externalProject As Project = reader.Read(dataDir & "External.mpp")

Dim externalTask As Task = externalProject.GetTaskByUid(4)
'ID of the task in the external project
Console.WriteLine(externalTask.Id.ToString())
'ID of the task in the original project
Console.WriteLine(externalTask.ExternalId.ToString())
		End Sub
	End Class
End Namespace