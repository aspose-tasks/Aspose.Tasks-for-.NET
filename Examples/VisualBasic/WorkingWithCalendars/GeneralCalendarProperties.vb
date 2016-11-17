Imports Aspose.Tasks
Imports System
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
    Class GeneralCalendarProperties
        Public Shared Sub Run()
            ' ExStart: ReadCalendarProps
            ' Load an existing project
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)
            Dim project As New Project(dataDir & Convert.ToString("Project_GeneralCalendarProperties.xml"))

            For Each cal As Calendar In project.Calendars
                If cal.Name IsNot Nothing Then
                    Console.WriteLine("UID : " + cal.Uid.ToString() + " Name: " + cal.Name)

                    ' Show if it is has a base calendar
                    Console.Write("Base Calendar : ")
                    If cal.IsBaseCalendar Then
                        Console.WriteLine("Self")
                    Else
                        Console.WriteLine(cal.BaseCalendar.Name)
                    End If

                    ' Get Time in hours on each working day
                    For Each wd As WeekDay In cal.WeekDays
                        Dim ts As TimeSpan = wd.GetWorkingTime()
                        Console.WriteLine("Day Type: " + wd.DayType.ToString() + " Hours: " + ts.ToString())
                    Next
                End If
            Next
            ' ExEnd: ReadCalendarProps
        End Sub
    End Class
End Namespace