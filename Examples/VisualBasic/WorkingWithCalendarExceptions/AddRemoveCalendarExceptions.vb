Imports System.IO

Namespace WorkingWithCalendarExceptions
    Public Class AddRemoveCalendarExceptions
        Public Shared Sub Run()
            ' ExStart:AddRemoveCalendarExceptions
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            Using fs As New FileStream(dataDir + "project_test.mpp", FileMode.Open)
                ' Create project instance
                Dim prj As New Project(fs)

                ' Remove an exception
                Dim cal As Aspose.Tasks.Calendar = prj.Calendars.ToList()(0)
                If cal.Exceptions.Count > 1 Then
                    Dim exc As CalendarException = cal.Exceptions.ToList()(0)
                    cal.Exceptions.Remove(exc)
                End If

                ' Add an exception
                Dim calExc As New CalendarException()
                calExc.FromDate = New System.DateTime(2009, 1, 1)
                calExc.ToDate = New System.DateTime(2009, 1, 3)
                cal.Exceptions.Add(calExc)

                ' Display exceptions
                For Each calExc1 As CalendarException In cal.Exceptions
                    Console.WriteLine("From" + calExc1.FromDate.ToShortDateString())
                    Console.WriteLine("To" + calExc1.ToDate.ToShortDateString())
                Next
            End Using
            ' ExEnd:AddRemoveCalendarExceptions
        End Sub
    End Class
End Namespace
