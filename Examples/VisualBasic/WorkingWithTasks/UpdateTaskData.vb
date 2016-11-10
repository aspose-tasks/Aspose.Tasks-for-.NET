Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithTasks
    Public Class UpdateTaskData
        Public Shared Sub Run()
            Try
                ' ExStart:UpdateTaskData
                Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
                Dim newProject As String = "project.mpp"
                Dim project As New Project(dataDir + newProject)

                ' Set project start date
                project.Set(Prj.StartDate, New DateTime(2012, 7, 29, 8, 0, 0))

                ' Add summary task, first sub task and set its properties
                Dim summary As Task = project.RootTask.Children.Add("Summary task")
                Dim task1 As Task = summary.Children.Add("First task")
                task1.Set(Tsk.Duration, project.GetDuration(3))
                task1.Set(Tsk.Deadline, task1.Get(Tsk.Start).AddDays(10))
                task1.Set(Tsk.NotesText, "The first task.")
                task1.Set(Tsk.DurationFormat, TimeUnitType.MinuteEstimated)
                task1.Set(Tsk.ConstraintType, ConstraintType.FinishNoLaterThan)
                task1.Set(Tsk.ConstraintDate, task1.Get(Tsk.Deadline).AddDays(-1))

                ' Create 10 new sub tasks for summary task
                For i = 0 To 9
                    Dim subTask As Task = summary.Children.Add(String.Format("Task{0}", i + 2))
                    subTask.Set(Tsk.Duration, task1.Get(Tsk.Duration).Add(project.GetDuration(i + 1)))
                    subTask.Set(Tsk.DurationFormat, TimeUnitType.Day)
                    subTask.Set(Tsk.Deadline, task1.Get(Tsk.Deadline).AddDays(i + 1))
                Next

                ' Save the Project
                project.Save(dataDir + "project_updated_out.mpp", SaveFileFormat.MPP)
                ' ExEnd:UpdateTaskData
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace

