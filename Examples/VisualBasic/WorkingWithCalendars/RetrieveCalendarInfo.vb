Imports System
Imports Aspose.Tasks

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithCalendars
    Public Class RetrieveCalendarInfo
        Public Shared Sub Run()
            ' ExStart: RetrieveCalendarInfo
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' Create a project reader instance
            Dim project As New Project(dataDir & "RetrieveCalendarInfo.mpp")

            ' Retrieve Calendars Information
            Dim alCals As CalendarCollection = project.Calendars
            For Each cal As Calendar In alCals
                If cal.Name IsNot Nothing Then
                    Console.WriteLine("Calendar UID : " & cal.Uid)
                    Console.WriteLine("Calendar Name : " & cal.Name)

                    Dim alDays As WeekDayCollection = cal.WeekDays
                    For Each wd As WeekDay In alDays
                        Dim ts As TimeSpan = wd.GetWorkingTime()
                        If wd.DayWorking Then
                            Console.WriteLine(wd.DayType.ToString() & ":")
                            Console.WriteLine(ts.ToString())
                        End If
                    Next wd
                End If
            Next cal
            ' ExEnd: RetrieveCalendarInfo
        End Sub
    End Class
End Namespace