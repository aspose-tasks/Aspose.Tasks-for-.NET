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
Imports Aspose.Tasks.Saving

Namespace WritingProjectInformationExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			Dim project As New Project(dataDir & "project.mpp")
			project.Set(Prj.Author, "Author")
			project.Set(Prj.LastAuthor, "Last Author")
			project.Set(Prj.Revision, 15)
			project.Set(Prj.Keywords, "MSP Aspose")
			project.Set(Prj.Comments, "Comments")

			project.Save(dataDir & "saved.mpp", SaveFileFormat.MPP)

		End Sub
	End Class
End Namespace