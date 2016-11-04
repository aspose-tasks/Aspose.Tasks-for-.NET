Imports Aspose.Tasks
Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithCalendars
    Class ReadWorkWeeksInformation
        Public Shared Sub Run()
            ' ExStart: ReadWorkWeeksInformation
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create project instance and access calendar and work weeks collection
            Dim project As New Project(dataDir & Convert.ToString("project.mpp"))
            Dim calendar As Calendar = project.Calendars.GetByUid(3)
            Dim collection As WorkWeekCollection = calendar.WorkWeeks

            For Each workWeek As WorkWeek In collection
                ' Display work week name, from and to dates
                Dim Name As String = workWeek.Name
                Dim fromDate As Date = workWeek.FromDate
                Dim toDate As Date = workWeek.ToDate

                ' This data is all about "Details.." button you can set special working times for special WeekDay or even make nonworking
                Dim weekDays As WeekDayCollection = workWeek.WeekDays
                For Each day As WeekDay In weekDays
                    ' You can further traverse through working times and display these
                    Dim workingTimes As WorkingTimeCollection = day.WorkingTimes
                Next
            Next
            ' ExEnd: ReadWorkWeeksInformation
        End Sub
    End Class
End Namespace