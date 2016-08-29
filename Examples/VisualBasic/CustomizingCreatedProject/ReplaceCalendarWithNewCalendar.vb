Imports Aspose.Tasks

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Tasks.Examples.VisualBasic.CustomizingCreatedProject
    Public Class ReplaceCalendarWithNewCalendar
        Public Shared Sub Run()
            ' ExStart:ReplaceCalendarWithNewCalendar
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CustomizingCreatedProject()
            Dim project As New Project(dataDir & Convert.ToString("Project5.mpp"))
            Dim calendar As New Calendar("New Cal")
            Dim calColl As CalendarCollection = project.Calendars
            For Each getcalendar As Calendar In calColl
                If getcalendar.Name = "Standard" Then
                    calColl.Remove(getcalendar)
                    calColl.Add("Standard", getcalendar)
                    Exit For
                End If
            Next
            ' ExEnd:ReplaceCalendarWithNewCalendar
        End Sub
    End Class
End Namespace