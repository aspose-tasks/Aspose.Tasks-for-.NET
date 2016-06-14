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
    Class ReadWorkWeeksInformation
        Public Shared Sub Run()
            'ExStart: ReadWorkWeeksInformation
            'This example demonstrates how to read calendar work weeks infomraiton from a Project file

            Dim dataDir As String = RunExamples.GetDataDir_Projects()

            Dim project As New Project("TestWorkWeek.mpp")

            Dim calendar As Calendar = project.Calendars.GetByUid(3)

            Dim collection As WorkWeekCollection = calendar.WorkWeeks

            For Each workWeek As WorkWeek In collection
                Dim Name As String = workWeek.Name
                'name
                Dim fromDate As Date = workWeek.FromDate
                'start
                Dim toDate As Date = workWeek.ToDate
                'finish
                'This data is all about "Details.." button you can set special working times for special WeekDay or even make nonworking
                Dim weekDays As WeekDayCollection = workWeek.WeekDays
                'Aspose.Tasks.WeekDayCollection
                For Each day As WeekDay In weekDays
                    'Aspose.Tasks.WeekDay
                    'Aspose.Tasks.WorkingTimeCollection
                    'You can further traverse through working times and display these
                    Dim workingTimes As WorkingTimeCollection = day.WorkingTimes
                Next
            Next
            'ExEnd: ReadWorkWeeksInformation
        End Sub
    End Class
End Namespace