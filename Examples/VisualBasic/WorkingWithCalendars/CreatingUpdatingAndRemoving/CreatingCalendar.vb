Imports System
Imports Aspose.Tasks
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Aspose.Tasks.Examples.VisualBasic
Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithCalendars.CreatingUpdatingAndRemoving
    Class CreatingCalendar
        Public Shared Sub Run()
            ' ExStart: CreatingCalendar
            ' Create a project instance
            Dim project As New Project()

            ' New calendar can be added to a project's calendar collection using the collection's Add method.
            Dim cal1 As Calendar = project.Calendars.Add("New Info")
            Dim cal2 As Calendar = project.Calendars.Add("no name")
            Dim cal3 As Calendar = project.Calendars.Add("cal3")

            ' Save the Project
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)
            project.Save(dataDir & Convert.ToString("CreatingCalendar_out.Xml"), SaveFileFormat.XML)
            ' ExEnd: CreatingCalendar
        End Sub
    End Class
End Namespace
