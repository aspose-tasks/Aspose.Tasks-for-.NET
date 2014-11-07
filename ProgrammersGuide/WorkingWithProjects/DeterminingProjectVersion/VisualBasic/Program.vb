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

Namespace DeterminingProjectVersion
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Create a project reader instance
			Dim rdr As New ProjectReader()

			'Call read method of project reader object to get project object
			Dim st As New FileStream(dataDir & "input.xml", FileMode.Open)
			Dim prj As Project = rdr.Read(st)
			st.Close()

			'Display project version property
			Console.WriteLine("Project Version : " & prj.SaveVersion.ToString())
			Console.WriteLine("Last Saved : " & prj.LastSaved.ToShortDateString())
		End Sub
	End Class
End Namespace