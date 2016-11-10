Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithTasks.WorkingWithTaskConstraints
    Public Class SetConstraintMustFinishOn
        Public Shared Sub Run()
            ' ExStart:SetConstraintMustFinishOn
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create project instance
            Dim project1 As Project = New Project(dataDir + "TestProject.mpp")

            ' Set constraint Must Finish On for task with Id 15
            Dim interiorFixtures As Task = project1.RootTask.Children.GetById(15)
            interiorFixtures.Set(Tsk.ConstraintType, ConstraintType.MustFinishOn)
            interiorFixtures.Set(Tsk.ConstraintDate, New DateTime(2017, 3, 1, 18, 0, 0))

            ' TODO: Replace latest 
            'Task.Recalculate(project.RootTask);

            ' Save project as pdf
            Dim options As SaveOptions = New PdfSaveOptions()
            options.StartDate = project1.Get(Prj.StartDate)
            options.Timescale = Timescale.ThirdsOfMonths
            project1.Save(dataDir + "project_MustFinishOn_out.pdf", options)
            ' ExEnd:SetConstraintMustFinishOn
        End Sub
    End Class
End Namespace

