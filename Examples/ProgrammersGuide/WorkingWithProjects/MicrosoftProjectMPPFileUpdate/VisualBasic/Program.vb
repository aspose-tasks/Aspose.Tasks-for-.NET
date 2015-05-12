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

Namespace MicrosoftProjectMPPFileUpdateExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'Read an existing project
			Dim project As New Project(dataDir & "project.mpp")

			'create a new task
			Dim task As Task = project.RootTask.Children.Add("Task1")

			task.Set(Tsk.Start, New System.DateTime(2012, 8, 1))
			task.Set(Tsk.Finish, New DateTime(2012, 8, 5))

			'Save the project as MPP project file
			project.Save(dataDir & "AfterLinking.Mpp", Aspose.Tasks.Saving.SaveFileFormat.MPP)

		End Sub
	End Class
End Namespace