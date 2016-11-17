Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithTasks
    Public Class RenderTaskUsageView
        Public Shared Sub Run()
            ' ExStart:RenderTaskUsageView
            ' Create project instance
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)
            Dim project1 As New Project(dataDir + "TaskUsageView.mpp")

            ' Define the SaveOptions with required TimeScale settings as Days
            Dim options As New PdfSaveOptions()
            options.Timescale = Timescale.Days

            ' Set the Presentation format to ResourceUsage
            options.PresentationFormat = PresentationFormat.TaskUsage

            ' Save the Project
            Dim outputProject As String = "project_TaskUsageView_result_days_out.pdf"
            project1.Save(dataDir & outputProject, options)

            ' Set the Tiemscale settings to ThirdsOfMonths
            options.Timescale = Timescale.ThirdsOfMonths

            ' Save the Project
            outputProject = "project_TaskUsageView_result_thirdsOfMonths_out.pdf"
            project1.Save(dataDir & outputProject, options)

            ' Set the Timescale settings to Months
            options.Timescale = Timescale.Months

            ' Save the project
            outputProject = "project_TaskUsageView_result_months_out.pdf"
            project1.Save(dataDir & outputProject, options)
            ' ExEnd:RenderTaskUsageView
        End Sub
    End Class
End Namespace

