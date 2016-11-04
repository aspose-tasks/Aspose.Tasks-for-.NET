Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects.WorkingWithProjectProperties
    Public Class WriteDefaultProperties
        Public Shared Sub Run()
            ' ExStart:WriteDefaultProperties
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create a project instance and Set default properties
            Dim project As New Project()
            project.[Set](Prj.ScheduleFromStart, True)
            project.[Set](Prj.StartDate, DateTime.Now)
            project.[Set](Prj.DefaultStartTime, project.[Get](Prj.StartDate))
            project.[Set](Prj.DefaultTaskType, TaskType.FixedDuration)
            project.[Set](Prj.DefaultStandardRate, 15)
            project.[Set](Prj.DefaultOvertimeRate, 12)
            project.[Set](Prj.DefaultTaskEVMethod, EarnedValueMethodType.PercentComplete)
            project.[Set](Prj.DefaultFixedCostAccrual, CostAccrualType.Prorated)

            ' Save the project to XML format
            project.Save(dataDir & Convert.ToString("WriteDefaultProperties_out.xml"), SaveFileFormat.XML)
            ' ExEnd:WriteDefaultProperties
        End Sub
    End Class
End Namespace
