Imports Aspose.Tasks
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithCalendars.CreatingUpdatingAndRemoving
    Class MakeAStandardCalendar
        Public Shared Sub Run()
            ' ExStart: MakeAStandardCalendar
            ' Create a project instance
            Dim project As New Project()

            ' Define Calendar and make it standard
            Dim cal1 As Calendar = project.Calendars.Add("My Cal")
            Calendar.MakeStandardCalendar(cal1)

            ' Save the Project
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            project.Save(dataDir & "Project_out.xml", SaveFileFormat.XML)
            ' ExEnd: MakeAStandardCalendar
        End Sub
    End Class
End Namespace