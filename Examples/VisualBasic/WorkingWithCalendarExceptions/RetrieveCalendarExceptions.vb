
Namespace WorkingWithCalendarExceptions
    Public Class RetrieveCalendarExceptions
        Public Shared Sub Run()
            ' ExStart:RetrieveCalendarExceptions
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' Create project instance
            Dim project1 As New Project(dataDir + "project_RetrieveExceptions_test.mpp")

            ' Access calendars
            For Each cal As Calendar In project1.Calendars
                ' Access calendar exceptions
                For Each calExc As CalendarException In cal.Exceptions
                    Console.WriteLine("From: " + calExc.FromDate.ToShortDateString())
                    Console.WriteLine("To: " + calExc.ToDate.ToShortDateString())
                Next
            Next
            ' ExEnd:RetrieveCalendarExceptions
        End Sub
    End Class
End Namespace

