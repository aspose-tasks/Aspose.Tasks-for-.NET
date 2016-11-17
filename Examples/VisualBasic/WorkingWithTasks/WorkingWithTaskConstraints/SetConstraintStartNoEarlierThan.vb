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
    Public Class SetConstraintStartNoEarlierThan
        Public Shared Sub Run()
            ' ExStart:SetConstraintMustStartOn
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' Create project instance
            Dim project As New Project(dataDir & "ConstraintStartNoEarlierThan.mpp")

            ' Set constraint Start No Earlier Than on task with Id 1
            Dim summary As Task = project.RootTask.Children.GetById(1)
            summary.[Set](Tsk.ConstraintType, ConstraintType.StartNoEarlierThan)
            summary.[Set](Tsk.ConstraintDate, New DateTime(2013, 6, 3, 9, 0, 0))

            ' Save project as pdf
            Dim o As SaveOptions = New PdfSaveOptions()
            o.StartDate = project.Get(Prj.StartDate)
            o.Timescale = Timescale.ThirdsOfMonths
            project.Save(dataDir & "project_StartNoEarlierThan_out.pdf", o)
            ' ExEnd:SetConstraintMustStartOn
        End Sub
    End Class
End Namespace

