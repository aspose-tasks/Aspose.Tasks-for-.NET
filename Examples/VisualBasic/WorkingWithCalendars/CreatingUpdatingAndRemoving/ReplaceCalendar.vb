Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithCalendars.CreatingUpdatingAndRemoving
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

            For Each c As Calendar In calColl
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