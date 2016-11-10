
Namespace WorkingWithCalendarExceptions
    Public Class DefineWeekdayExceptions
        Public Shared Sub Run()
            ' ExStart:DefineWeekdayExceptions
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create a project instance
            Dim prj As New Project()

            ' Define Calendar
            Dim cal As Aspose.Tasks.Calendar = prj.Calendars.Add("Calendar1")

            ' Define week days exception for a holiday
            Dim except As New CalendarException()
            except.EnteredByOccurrences = False
            except.FromDate = New DateTime(2009, 12, 24, 0, 0, 0)
            except.ToDate = New DateTime(2009, 12, 31, 23, 59, 0)
            except.Type = CalendarExceptionType.Daily
            except.DayWorking = False
            cal.Exceptions.Add(except)

            ' Save the Project
            prj.Save(dataDir & "Project_out.xml", Aspose.Tasks.Saving.SaveFileFormat.XML)
            ' ExEnd:DefineWeekdayExceptions
        End Sub
    End Class
End Namespace

