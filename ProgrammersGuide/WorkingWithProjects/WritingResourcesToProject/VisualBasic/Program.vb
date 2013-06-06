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

Namespace WritingResourcesToProject
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Create a project instance
			Dim prj As New Project()

			'Define Resources
			Dim rec As New Resource()
			Dim rec1 As New Resource("Res1")
			rec1.Type = ResourceType.Work
			Dim rec2 As New Resource("Res2")
			rec2.Type = ResourceType.Material

			'Add to the project
			prj.Resources.Add(rec)
			prj.Resources.Add(rec1)
			prj.Resources.Add(rec2)

			'Perform recalculations
			prj.CalcResourceIds()
			prj.CalcResourceUids()
			prj.CalcResourceFields()

			'Save the project as XML project file
			prj.Save(dataDir & "project.xml", Aspose.Tasks.Saving.SaveFileFormat.XML)
		End Sub
	End Class
End Namespace