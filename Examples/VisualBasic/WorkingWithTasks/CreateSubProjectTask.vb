Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithTasks
    Public Class CreateSubProjectTask
        Public Shared Sub Run()
            Try
                ' ExStart:CreateSubProjectTask
                ' Create project instance
                Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
                Dim project As New Project(dataDir & "project.mpp")

                ' Add Task
                Dim task As Task = project.RootTask.Children.Add("New Task 1")

                ' Setting new subproject link
                task.[Set](Tsk.SubprojectName, dataDir & "subProject.mpp")

                ' Save project
                project.Save(dataDir & "Link_out.mpp", SaveFileFormat.MPP)
                ' ExEnd:CreateSubProjectTask
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose.Tasks License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace
