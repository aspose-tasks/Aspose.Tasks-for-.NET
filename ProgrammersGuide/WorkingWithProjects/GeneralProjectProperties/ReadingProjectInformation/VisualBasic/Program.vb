'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO
Imports System
Imports Aspose.Tasks

Namespace ReadingProjectInformationExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Create a project reader instance
			Dim project As New Project(dataDir & "project.mpp")
			If project.Get(Prj.ScheduleFromStart) Then
				Console.WriteLine("Project Finish Date : " & project.Get(Prj.StartDate).ToShortDateString())
			Else
				Console.WriteLine("Project Finish Date : " & project.Get(Prj.FinishDate).ToShortDateString())
			End If
			Console.WriteLine(project.Get(Prj.Author))
			Console.WriteLine(project.Get(Prj.LastAuthor))
			Console.WriteLine(project.Get(Prj.Revision))
			Console.WriteLine(project.Get(Prj.Keywords))
			Console.WriteLine(project.Get(Prj.Comments))
			Console.WriteLine("The program has run successfully")

		End Sub
	End Class
End Namespace