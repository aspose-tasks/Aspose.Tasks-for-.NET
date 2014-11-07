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

Namespace WritingProjectInformationExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'Create a project instance
			Dim prj As New Project()

			'Set project information properties
			prj.IsScheduleFromStart = True
			prj.StartDate = New System.DateTime(2009, 8, 10)
			prj.CurrentDate = New System.DateTime(2009, 8, 10)
			prj.StatusDate = New System.DateTime(2009, 8, 10)
			Dim cal As Aspose.Tasks.Calendar = Aspose.Tasks.Calendar.MakeStandardCalendar()
			cal.Name = "Standard"
			prj.Calendars.Add(cal)

			'Save the Project as XML
			prj.Save(dataDir & "project3.xml", Aspose.Tasks.Saving.SaveFileFormat.XML)

		End Sub
	End Class
End Namespace