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
    Public Class SetConstraintFinishNoEarlierThan
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' Create project instance
            Dim project1 As Project = New Project(dataDir + "ConstraintFinishNoEarlierThan.mpp")

            ' ExStart:SetConstraintFinishNoEarlierThan
            ' Set constraint Finish No Earlier Than on task with Id 2
            Dim first As Task = project1.RootTask.Children.GetById(2)
            first.Set(Tsk.ConstraintType, ConstraintType.FinishNoEarlierThan)
            first.Set(Tsk.ConstraintDate, New DateTime(2016, 12, 1, 18, 0, 0))

            ' Save project as pdf
            Dim options As SaveOptions = New PdfSaveOptions()
            options.StartDate = project1.Get(Prj.StartDate)
            options.Timescale = Timescale.ThirdsOfMonths
            project1.Save(dataDir + "project_FinishNoEarlierThan_out.pdf", options)
            ' ExEnd:SetConstraintFinishNoEarlierThan
        End Sub
    End Class
End Namespace

