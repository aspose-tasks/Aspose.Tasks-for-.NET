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

Namespace FiscalYearProperties
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' 1.
			' Reading Fiscal Year Properties
			'Create a project reader instance
			Dim rdr As New ProjectReader()

			'Call the Read method of project reader object to get project object
			Dim St As New FileStream(dataDir & "project.mpp", FileMode.Open)
			Dim prj As Project = rdr.Read(St)
			St.Close()

			'Display fiscal year properties
			Console.WriteLine("Fiscal Year Start Date : " & prj.FyStartDate.ToString())
			Console.WriteLine("Fiscal Year Numbering : " & prj.FiscalYearStart.ToString())



			' 2.
			' Writing Fiscal Year Properties
			'Create a project instance
			Dim prj1 As New Project()

			'Set fiscal year properties
			prj1.FyStartDate = Month.July
			prj1.FiscalYearStart = True

			'Save the project as XML project file
			prj1.Save(dataDir & "savedProject.xml", Aspose.Tasks.Saving.SaveFileFormat.XML)
		End Sub
	End Class
End Namespace