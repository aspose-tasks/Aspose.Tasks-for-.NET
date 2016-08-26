Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Tasks.Examples.VisualBasic.CustomizingCreatedProject
    Public Class ReschedueProjectFromFinishDate
        Public Shared Sub Run()
            ' ExStart:ReschedueProjectFromFinishDate
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CustomizingCreatedProject()
            Dim project As New Project(dataDir & Convert.ToString("Project1.mpp"))
            project.[Set](Prj.ScheduleFromStart, False)
            project.[Set](Prj.FinishDate, New DateTime(2020, 1, 1))
            ' Now all tasks dates (Start, Finish, EarlyStart, EarlyFinish, LateStart, LateFinish) are calculated. To get the critical path we need to calculate slacks (can be invoked in separate thread, but only after calculation of all early/late dates)
            project.Recalculate()
            Dim criticalPath As TaskCollection = project.CriticalPath
            ' ExEnd:ReschedueProjectFromFinishDate
        End Sub
    End Class
End Namespace
