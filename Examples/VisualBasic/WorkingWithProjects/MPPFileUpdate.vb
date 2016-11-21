Imports Aspose.Tasks
Imports System
Imports Aspose.Tasks.Saving

Namespace WorkingWithProjects
    Public Class MPPFileUpdate
        Public Shared Sub Run()
            Try
                ' ExStart: MPPFileUpdate
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

                ' Read an existing project
                Dim project As New Project(dataDir & "MPPFileUpdate.mpp")

                ' Create a new task
                Dim task As Task = project.RootTask.Children.Add("Task1")

                task.Set(Tsk.Start, New System.DateTime(2012, 8, 1))
                task.Set(Tsk.Finish, New DateTime(2012, 8, 5))

                ' Save the project as MPP project file
                project.Save(dataDir & "AfterLinking_out.Mpp", SaveFileFormat.MPP)
                ' ExEnd: MPPFileUpdate
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace