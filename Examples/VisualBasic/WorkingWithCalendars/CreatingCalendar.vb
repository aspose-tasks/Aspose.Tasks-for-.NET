Imports System
Imports Aspose.Tasks
Imports VisualBasic
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Examples.VisualBasic

Namespace Aspose.Tasks.Examples.VisualBasic.WorkingWithCalendars
    Class CreatingCalendar
        Public Shared Sub Run()
            'ExStart: CreatingCalendar
            'New calendar can be added to a project's calendar collection using the collection's Add method.

            'Create a project instance
            Dim project As New Project()

            'Define Calendar
            Dim cal1 As Aspose.Tasks.Calendar = project.Calendars.Add("New Info")
            Dim cal2 As Aspose.Tasks.Calendar = project.Calendars.Add("no name")
            Dim cal3 As Aspose.Tasks.Calendar = project.Calendars.Add("cal3")

            'Save the Project
            Dim dataDir As String = RunExamples.GetDataDir_WorkingWithCalendars()
            project.Save(dataDir & Convert.ToString("CreatingCalendar_out.Xml"), Aspose.Tasks.Saving.SaveFileFormat.XML)
            'ExEnd: CreatingCalendar
        End Sub
    End Class
End Namespace
