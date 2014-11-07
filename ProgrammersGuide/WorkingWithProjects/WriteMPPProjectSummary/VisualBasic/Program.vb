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
Imports Aspose.Tasks.Saving

Namespace WriteMPPProjectSummary
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Instantiate ProjectReader class
			Dim reader As New ProjectReader()

			'Load an existing MPP file
			Dim project As Project = reader.Read(dataDir & "project.mpp")

			'Set some summary information about the project
			project.Author = "Muhammad Sabir"
			project.LastAuthor = "Sergey Polshkov"
			project.Revision = 15
			project.CreationDate = New DateTime(2010, 4, 15)
			project.LastSaved = New DateTime(2010, 4, 15)
			project.Keywords = "MPP Aspose"
			project.LastPrinted = New DateTime(2010, 4, 16)
			project.Subject = "Aspose Subject"
			project.Template = "Aspose Template"
			project.Comments = "Aspose Comments"

			'Save the Project back in MPP format
			project.Save(dataDir & "MPPAspose.xml", SaveFileFormat.XML)
		End Sub
	End Class
End Namespace