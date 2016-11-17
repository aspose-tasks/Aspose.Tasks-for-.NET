
Namespace WorkingWithCalendarExceptions
    Public Class HandleExceptionOccurences
        Public Shared Sub Run()
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' Create a project instance
            Dim project1 As New Project()

            ' Define Calendar
            Dim cal As Aspose.Tasks.Calendar = project1.Calendars.Add("Calendar1")

            ' ExStart:HandleExceptionOccurences
            ' Define exception and specify occurences
            Dim except As New CalendarException()
            except.EnteredByOccurrences = True
            except.Occurrences = 5
            except.Type = CalendarExceptionType.YearlyByDay
            ' ExEnd:HandleExceptionOccurences

            ' Add exception to calendar and save the Project
            cal.Exceptions.Add(except)
            project1.Save(dataDir & "Project_HandleExceptionOccurences_out.xml", Aspose.Tasks.Saving.SaveFileFormat.XML)
        End Sub
    End Class
End Namespace

