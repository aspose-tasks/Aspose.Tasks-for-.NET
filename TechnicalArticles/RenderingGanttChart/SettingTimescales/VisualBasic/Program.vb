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
Imports System.Drawing

Namespace SettingTimescalesExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			Dim project As Project = New ProjectReader().Read(dataDir & "NewProductDev.mpp")

			' Save to one page image (Timescale.days by default)
			project.Save(dataDir & "NewProductDevDays.jpeg", New ImageSaveOptions(SaveFileFormat.JPEG))


			' Save to one page image (Timescale.ThirdsOfMonths)
			Dim options As New ImageSaveOptions(SaveFileFormat.JPEG)
			options.Timescale = Timescale.ThirdsOfMonths

			project.Save(dataDir & "NewProductDevThirdsOfMonths.jpeg", options)

			' Save to one page image (Timescale.Months)
			options.Timescale = Timescale.Months
			project.Save(dataDir & "NewProductDevMonths.jpeg", options)

			' There is IRender property for compliance with Project.Export interface
			options.RenderParam = New BaseImageRenderParam(Nothing, Point.Empty, New Size(800, 600), 100, 0, True)

			project.Save(dataDir & "NewProductDevRenderOptions.jpeg", options)



		End Sub
	End Class
End Namespace