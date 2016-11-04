Imports Aspose.Tasks
Imports Aspose.Tasks.Saving
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

Namespace WorkingWithCalendars.CreatingUpdatingAndRemoving
    Class WriteUpdatedCalendarDataToMPP
        Public Shared Sub Run()
            ' ExStart:WriteUpdatedCalendarDataToMPP
            Dim resultFile As String = "result_out.mpp"
            Dim newFile As String = "project_test.mpp"
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            Try
                ' Create project instance and access calendar
                Dim project As New Project(dataDir + newFile)
                Dim cal As Calendar = project.Calendars.GetByUid(3)

                ' Update the calendar information
                Calendar.MakeStandardCalendar(cal)
                cal.Name = "Test calendar"
                Dim exc As New CalendarException()
                exc.FromDate = DateTime.Now
                exc.ToDate = DateTime.Now.AddDays(2)
                exc.DayWorking = True

                Dim wt1 As New WorkingTime()
                wt1.FromTime = New DateTime(10, 1, 1, 9, 0, 0)
                wt1.ToTime = New DateTime(10, 1, 1, 13, 0, 0)

                Dim wt2 As New WorkingTime()
                wt2.FromTime = New DateTime(10, 1, 1, 14, 0, 0)
                wt2.ToTime = New DateTime(10, 1, 1, 19, 0, 0)

                Dim wt3 As New WorkingTime()
                wt3.FromTime = New DateTime(10, 1, 1, 20, 0, 0)
                wt3.ToTime = New DateTime(10, 1, 1, 21, 0, 0)

                exc.WorkingTimes.Add(wt1)
                exc.WorkingTimes.Add(wt2)
                exc.WorkingTimes.Add(wt3)
                cal.Exceptions.Add(exc)

                Dim exc2 As New CalendarException()
                exc2.FromDate = DateTime.Now.AddDays(7)
                exc2.ToDate = exc2.FromDate
                exc2.DayWorking = False
                cal.Exceptions.Add(exc2)

                project.[Set](Prj.Calendar, cal)

                ' Save project
                project.Save(dataDir + resultFile, SaveFileFormat.MPP)
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try
            ' ExEnd:WriteUpdatedCalendarDataToMPP
        End Sub
    End Class
End Namespace