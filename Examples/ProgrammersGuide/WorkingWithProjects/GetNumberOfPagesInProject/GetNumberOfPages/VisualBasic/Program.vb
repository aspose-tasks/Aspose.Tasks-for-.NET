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

Namespace GetNumberOfPagesExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")



			'Read the input Project file
			Dim project As New Project(dataDir & "project.mpp")

			'Get number of pages
			Dim iPages As Integer = project.GetPageCount()

			'Get number of pages (Timescale.Months)
			iPages = project.GetPageCount(Aspose.Tasks.Visualization.Timescale.Months)

			'Get number of pages (Timescale.ThirdsOfMonths)
			iPages = project.GetPageCount(Aspose.Tasks.Visualization.Timescale.ThirdsOfMonths)


		End Sub
	End Class
End Namespace