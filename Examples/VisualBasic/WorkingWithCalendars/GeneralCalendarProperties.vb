
Imports Aspose.Tasks
Imports VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Examples.VisualBasic

Namespace Aspose.Tasks.Examples.VisualBasic.WorkingWithCalendars
    Class GeneralCalendarProperties
        Public Shared Sub Run()
            'ExStart: ReadCalendarProps

            'load an existing project
            Dim dataDir As String = RunExamples.GetDataDir_WorkingWithCalendars()
            Dim project As New Project(dataDir & Convert.ToString("Project.xml"))


            For Each cal As Aspose.Tasks.Calendar In project.Calendars
                If cal.Name IsNot Nothing Then
                    Console.WriteLine("UID : " + cal.Uid.ToString() + " Name: " + cal.Name)

                    'Show if it is has a base calendar
                    Console.Write("Base Calendar : ")
                    If cal.IsBaseCalendar Then
                        Console.WriteLine("Self")
                    Else
                        Console.WriteLine(cal.BaseCalendar.Name)
                    End If

                    'Get Time in hours on each working day
                    For Each wd As WeekDay In cal.WeekDays
                        Dim ts As TimeSpan = wd.GetWorkingTime()
                        Console.WriteLine("Day Type: " + wd.DayType.ToString() + " Hours: " + ts.ToString())
                    Next
                End If
            Next
            'ExEnd: ReadCalendarProps
        End Sub
    End Class
End Namespace