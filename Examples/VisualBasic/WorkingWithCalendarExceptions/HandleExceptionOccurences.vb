
Namespace WorkingWithCalendarExceptions
    Public Class HandleExceptionOccurences
        Public Shared Sub Run()
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create a project instance
            Dim prj As New Project()

            ' Define Calendar
            Dim cal As Aspose.Tasks.Calendar = prj.Calendars.Add("Calendar1")

            ' ExStart:HandleExceptionOccurences
            ' Define exception and specify occurences
            Dim except As New CalendarException()
            except.EnteredByOccurrences = True
            except.Occurrences = 5
            except.Type = CalendarExceptionType.YearlyByDay
            ' ExEnd:HandleExceptionOccurences

            ' Add exception to calendar and save the Project
            cal.Exceptions.Add(except)
            prj.Save(dataDir & "Project_out.xml", Aspose.Tasks.Saving.SaveFileFormat.XML)
        End Sub
    End Class
End Namespace

