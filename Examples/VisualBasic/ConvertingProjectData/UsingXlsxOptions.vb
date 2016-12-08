Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace ConvertingProjectData
    Public Class UsingXlsxOptions
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:UsingXlsxOptions
            ' Read the input Project file
            Dim project As New Project(dataDir & Convert.ToString("CreateProject2.mpp"))
            
            Dim options As New XlsxOptions()

            ' Add desired Gantt Chart columns
            Dim col As New GanttChartColumn("WBS", 100, Function(task As Task) task.Get(Tsk.WBS))
            options.View.Columns.Add(col)

            ' Add desired resource view columns
            Dim rscCol As New ResourceViewColumn("Cost center", 100, Function(resource As Resource) resource.Get(Rsc.CostCenter))
            options.ResourceView.Columns.Add(rscCol)

            ' Add desired assignment view columns
            Dim assnCol As New AssignmentViewColumn("Notes", 200, Function(assignment As ResourceAssignment) assignment.Get(Asn.Notes))
            options.AssignmentView.Columns.Add(assnCol)

            project.Save(dataDir & Convert.ToString("UsingXlsxOptions_out.xlsx"), options)
            ' ExEnd:UsingXlsxOptions
        End Sub
    End Class
End Namespace
