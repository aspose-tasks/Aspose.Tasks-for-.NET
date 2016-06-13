'''///////////////////////////////////////////////////////////////////////
' Copyright 2001-2016 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'''///////////////////////////////////////////////////////////////////////
Imports Aspose.Tasks
Imports Aspose.Tasks.Saving
Imports VisualBasic
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Examples.VisualBasic

Namespace Examples.ProgrammersGuide.WorkingWithCalendars
    Class WriteUpdatedCalendarDataToMPP
        Public Shared Sub Run()
            'ExStart: WriteUpdatedCalendarDataToMPP
            Dim resultFile As String = "OutputMPP.mpp"
            Dim newFile As String = "SampleMPP.mpp"
            Dim dataDir As String = RunExamples.GetDataDir_Projects()

            Dim project As New Project(dataDir & newFile)

            Dim cal As Calendar = project.Calendars.GetByUid(3)

            'Update the calendar information
            Calendar.MakeStandardCalendar(cal)
            cal.Name = "Test calendar"
            Dim exc As New CalendarException()
            exc.FromDate = Date.Now
            exc.ToDate = Date.Now.AddDays(2)
            exc.DayWorking = True

            Dim wt1 As New WorkingTime()
            wt1.FromTime = New Date(10, 1, 1, 9, 0, 0)
            wt1.ToTime = New Date(10, 1, 1, 13, 0, 0)

            Dim wt2 As New WorkingTime()
            wt2.FromTime = New Date(10, 1, 1, 14, 0, 0)
            wt2.ToTime = New Date(10, 1, 1, 19, 0, 0)

            Dim wt3 As New WorkingTime()
            wt3.FromTime = New Date(10, 1, 1, 20, 0, 0)
            wt3.ToTime = New Date(10, 1, 1, 21, 0, 0)

            exc.WorkingTimes.Add(wt1)
            exc.WorkingTimes.Add(wt2)
            exc.WorkingTimes.Add(wt3)
            cal.Exceptions.Add(exc)

            Dim exc2 As New CalendarException()
            exc2.FromDate = Date.Now.AddDays(7)
            exc2.ToDate = exc2.FromDate
            exc2.DayWorking = False
            cal.Exceptions.Add(exc2)

            project.[Set](Prj.Calendar, cal)

            project.Save(dataDir & resultFile, SaveFileFormat.MPP)
            'ExEnd: WriteUpdatedCalendarDataToMPP
        End Sub
    End Class
End Namespace