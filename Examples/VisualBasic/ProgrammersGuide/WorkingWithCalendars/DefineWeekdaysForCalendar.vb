'''///////////////////////////////////////////////////////////////////////
' Copyright 2001-2016 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'''///////////////////////////////////////////////////////////////////////
Imports Aspose.Tasks
Imports VisualBasic
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Examples.VisualBasic

Namespace Aspose.Tasks.Examples.VisualBasic.ProgrammersGuide.WorkingWithCalendars
    Class DefineWeekdaysForCalendar
        Public Shared Sub Run()
            'ExStart: DefineWeekdaysForCalendar
            'This example shows how Aspose.Tasks API can be used to define a new Calendar, add week days to it and define working times for days
            'Create a project instance
            Dim project As New Project()

            'Define Calendar
            Dim cal As Aspose.Tasks.Calendar = project.Calendars.Add("Calendar1")

            'Add working days monday through thursday with default timings
            cal.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Monday))
            cal.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Tuesday))
            cal.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Wednesday))
            cal.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Thursday))
            cal.WeekDays.Add(New WeekDay(DayType.Saturday))
            cal.WeekDays.Add(New WeekDay(DayType.Sunday))

            'Set friday as short working day
            Dim myWeekDay As New WeekDay(DayType.Friday)

            'Sets working time. Only time part of DateTime is important
            Dim wt1 As New WorkingTime()
            wt1.FromTime = New Date(1, 1, 1, 9, 0, 0, _
                0)
            wt1.ToTime = New Date(1, 1, 1, 12, 0, 0, _
                0)
            Dim wt2 As New WorkingTime()
            wt2.FromTime = New Date(1, 1, 1, 13, 0, 0, _
                0)
            wt2.ToTime = New Date(1, 1, 1, 16, 0, 0, _
                0)
            myWeekDay.WorkingTimes.Add(wt1)
            myWeekDay.WorkingTimes.Add(wt2)
            myWeekDay.DayWorking = True
            cal.WeekDays.Add(myWeekDay)


            'Save the Project
            Dim dataDir As String = RunExamples.GetDataDir_Projects()
            project.Save("Project.Xml", Aspose.Tasks.Saving.SaveFileFormat.XML)
            'ExEnd: DefineWeekdaysForCalendar
        End Sub
    End Class
End Namespace
