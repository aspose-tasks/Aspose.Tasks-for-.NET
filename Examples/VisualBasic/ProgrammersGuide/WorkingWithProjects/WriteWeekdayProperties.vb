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

Namespace VisualBasic.Projects
	Public Class WriteWeekdayProperties
        Public Shared Sub Run()
            'ExStart: WriteWeekdayProperties
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Projects()
            'Create a project instance
            Dim project As New Project(dataDir & "WriteWeekdayProperties.mpp")

            'Set week days properties
            project.Set(Prj.WeekStartDay, DayType.Monday)
            project.Set(Prj.DaysPerMonth, 24)
            project.Set(Prj.MinutesPerDay, 540)
            project.Set(Prj.MinutesPerWeek, 3240)

            project.Save(dataDir & "saved.xml", SaveFileFormat.XML)
            'ExEnd: WriteWeekdayProperties
        End Sub
	End Class
End Namespace