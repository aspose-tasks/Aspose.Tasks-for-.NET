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

Namespace RenderProjectToMultipageTIFFExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Source file to be converted to TIFF
		Dim file As String = dataDir & "RenderMe.mpp"
		Dim project As Project = New ProjectReader().Read(file)

		'Save the project to TIFF
		project.Save(dataDir & "RenderMe.tif", SaveFileFormat.TIFF)

		'Save the project with CCITT4 compression
		Dim options As New ImageSaveOptions(SaveFileFormat.TIFF)
		options.TiffCompression = TiffCompression.Ccitt4
		project.Save(dataDir & "RenderMe_options.tif", options)

		'Remove the compression
		options.TiffCompression = TiffCompression.None
		project.Save(dataDir & "RenderMe_comp_none.tif", options)

		End Sub
	End Class
End Namespace