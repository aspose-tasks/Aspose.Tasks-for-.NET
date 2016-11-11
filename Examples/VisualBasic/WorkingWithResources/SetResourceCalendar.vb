Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithResources
    Public Class SetResourceCalendar
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' ExStart:SetResourceCalendar
            ' Create project instance and add resource
            Dim project As New Project()
            Dim res As Resource = project.Resources.Add("Resource1")

            ' Add standard calendar and assign to resource
            Dim cal As Aspose.Tasks.Calendar = project.Calendars.Add("Resource1")
            res.[Set](Rsc.Calendar, cal)
            ' ExEnd:SetResourceCalendar

            ' Save project as XML
            project.Save(dataDir + "project_out.xml", SaveFileFormat.XML)
        End Sub
    End Class
End Namespace