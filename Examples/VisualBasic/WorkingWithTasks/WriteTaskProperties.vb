Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithTasks
    Public Class WriteTaskProperties
        Public Shared Sub Run()
            ' ExStart:WriteTaskProperties
            ' Create project instance
            Dim project As New Project()

            ' Add task and set task properties
            Dim task As Task = project.RootTask.Children.Add("Task1")
            task.[Set](Tsk.Start, project.RootTask.[Get](Tsk.Start).AddDays(1))
            task.[Set](Tsk.Name, "new name")
            ' ExEnd:WriteTaskProperties

            ' Save project
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            project.Save(dataDir + "project_out.pdf", SaveFileFormat.PDF)
        End Sub
    End Class
End Namespace

