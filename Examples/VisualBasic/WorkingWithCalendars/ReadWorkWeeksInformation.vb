Imports Aspose.Tasks
Imports VisualBasic
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Examples.VisualBasic

Namespace Aspose.Tasks.Examples.VisualBasic.WorkingWithCalendars
    Class ReadWorkWeeksInformation
        Public Shared Sub Run()
            'ExStart: ReadWorkWeeksInformation

            Dim dataDir As String = RunExamples.GetDataDir_WorkingWithCalendars()
            Dim project As New Project(dataDir & Convert.ToString("project.mpp"))
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