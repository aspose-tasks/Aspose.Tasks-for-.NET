'''///////////////////////////////////////////////////////////////////////
' Copyright 2001-2016 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'''///////////////////////////////////////////////////////////////////////using Aspose.Tasks;
Imports Aspose.Tasks
Imports VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Examples.ProgrammersGuide.WorkingWithCalendars
    Class GeneralCalendarProperties
        Public Shared Sub Run()
            'ExStart: ReadCalendarProps
            'This example shows how the API can be used to read calendars information from a MPP/XML file

            'load an existing project
            Dim dataDir As String = RunExamples.GetDataDir_Projects()
            Dim project As New Project("Existing Project.mpp")

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