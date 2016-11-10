Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithTasks
    Public Class WriteTaskCalendar
        Public Shared Sub Run()
            ' ExStart:WriteTaskCalendar
            ' Create project instance
            Dim project As New Project()

            ' Add task
            Dim tsk1 As Task = project.RootTask.Children.Add("Task1")

            ' Create calendar and assign to task
            Dim cal As Aspose.Tasks.Calendar = project.Calendars.Add("TaskCal1")
            tsk1.[Set](Tsk.Calendar, cal)
            ' ExEnd:WriteTaskCalendar
        End Sub
    End Class
End Namespace
