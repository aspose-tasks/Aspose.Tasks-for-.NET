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

Namespace CreateEmptyProjectSavetoStreamExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'Create a project instance
			Dim newProject As New Project()

			'Create a file stream
			Dim projectStream As New FileStream(dataDir & "Project1.xml", FileMode.Create, FileAccess.Write)

			'Write the stream into XML format
			newProject.Save(projectStream, Aspose.Tasks.Saving.SaveFileFormat.XML)

			projectStream.Close()



		End Sub
	End Class
End Namespace