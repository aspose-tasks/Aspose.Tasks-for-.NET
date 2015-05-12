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

Namespace ReadingFiscalYearPropertiesExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'Create a project reader instance
			Dim project As New Project(dataDir & "project.mpp")

			'Display fiscal year properties
			Console.WriteLine("Fiscal Year Start Date : " & project.Get(Prj.FyStartDate).ToString())
			Console.WriteLine("Fiscal Year Numbering : " & project.Get(Prj.FiscalYearStart).ToString())

		End Sub
	End Class
End Namespace