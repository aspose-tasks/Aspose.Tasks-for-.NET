Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks

Namespace Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects
    Public Class ReplaceCalendar
        Public Shared Sub Run()
            'ExStart: ReplaceCalendar

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_WorkingWithProjects()
            Dim project As New Project(dataDir + "ReplaceCalendar.mpp")

            'Add a new calendar to the project's calendars collection
            project.Calendars.Add("New cal1", project.[Get](Prj.Calendar))

            'Now traverse through project calendars and replace the already added calendar with a new one
            Dim calColl As CalendarCollection = project.Calendars

            For Each c As Aspose.Tasks.Calendar In calColl
                If c.Name = "New cal1" Then
                    calColl.Remove(c)
                    calColl.Add("New cal2", project.[Get](Prj.Calendar))
                    Exit For
                End If
            Next
            'ExEnd: ReplaceCalendar

        End Sub
    End Class
End Namespace