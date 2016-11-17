Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithResources
    Public Class RenderResourceUsageView
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:RenderResourceUsageView
            ' Create project instance
            Dim project1 As New Project(dataDir + "ResourceUsageView.mpp")

            ' Define the SaveOptions with required TimeScale settings as Days
            Dim options As SaveOptions = New PdfSaveOptions()
            options.Timescale = Timescale.Days

            ' Set the Presentation format to ResourceUsage
            options.PresentationFormat = PresentationFormat.ResourceUsage

            ' Save the Project
            Dim outputFile As String = "result_ResourceUsageView_days_out.pdf"
            project1.Save(dataDir & outputFile, options)

            ' Set the Tiemscale settings to ThirdsOfMonths and save the Project
            options.Timescale = Timescale.ThirdsOfMonths
            outputFile = "result_ResourceUsageView_thirdsOfMonths_out.pdf"
            project1.Save(dataDir & outputFile, options)

            ' Set the Timescale settings to Months and save the Project
            options.Timescale = Timescale.Months
            outputFile = "result_ResourceUsageView_months_out.pdf"
            project1.Save(dataDir & outputFile, options)
            ' ExEnd:RenderResourceUsageView
        End Sub
    End Class
End Namespace


