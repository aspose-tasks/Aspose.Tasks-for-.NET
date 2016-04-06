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

Namespace VisualBasic.Projects
	Public Class ReplaceCalendar
        Public Shared Sub Run()
            'ExStart: ReplaceCalendar
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Projects()
            Dim project As New Project(dataDir & "ReplaceCalendar.mpp")

            Dim cal As New Aspose.Tasks.Calendar("New Cal")
            Dim calColl As CalendarCollection = project.Calendars
            For Each c As Aspose.Tasks.Calendar In calColl
                If c.Name = "Standard" Then
                    calColl.Remove(c)
                    calColl.Add("Standard", cal)
                    Exit For
                End If
            Next c
            'ExEnd: ReplaceCalendar

        End Sub
	End Class
End Namespace