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
Imports Aspose.Tasks.Visualization

Namespace RenderXAMLwithOptionsExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'Load project
			Dim project As New Project(dataDir & "NewProductDev.mpp")
			Dim resFile As String = dataDir & "NewProductDev.xaml"
			Dim options As SaveOptions = New XamlOptions()
			options.FitContent = True
			options.LegendOnEachPage = False
			options.Timescale = Timescale.ThirdsOfMonths
			project.Save(resFile, options)


		End Sub
	End Class
End Namespace