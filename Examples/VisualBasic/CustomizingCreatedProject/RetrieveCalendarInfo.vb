Imports System

Namespace Aspose.Tasks.Examples.VisualBasic.CustomizingCreatedProject
    Public Class RetrieveCalendarInfo

        Public Shared Sub Run()
            'ExStart: RetrieveCalendarInfo
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CustomizingCreatedProject()

            ' Create a project reader instance
            Dim project As New Project(dataDir & "RetrieveCalendarInfo.mpp")

            ' Retrieve Calendars Information
            Dim alCals As CalendarCollection = project.Calendars
            For Each cal As Aspose.Tasks.Calendar In alCals
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