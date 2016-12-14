Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace KnowledgeBase
    Public Class LinkTasks
        Public Shared Sub Run()
            Try
                Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

                ' ExStart:LinkTasks            
                Dim project As New Project(dataDir + "SampleProject.mpp")

                Dim task1 As Task = project.RootTask.Children.GetById(1)
                Dim task2 As Task = project.RootTask.Children.GetById(2)
                Dim task3 As Task = project.RootTask.Children.GetById(3)
                Dim task4 As Task = project.RootTask.Children.GetById(4)
                Dim task5 As Task = project.RootTask.Children.GetById(5)

                ' Link the tasks
                Dim tsklnk As TaskLink = project.TaskLinks.Add(task1, task2, TaskLinkType.FinishToStart)
                tsklnk = project.TaskLinks.Add(task2, task3, TaskLinkType.FinishToStart)
                tsklnk = project.TaskLinks.Add(task3, task4, TaskLinkType.FinishToStart)
                tsklnk = project.TaskLinks.Add(task4, task5, TaskLinkType.FinishToStart)
                tsklnk = project.TaskLinks.Add(task2, task5, TaskLinkType.FinishToStart)

                ' Display links among the tasks
                Dim allinks As TaskLinkCollection = project.TaskLinks
                For Each tasklnk As TaskLink In allinks
                    Console.WriteLine("From ID = " & tasklnk.PredTask.Get(Tsk.Id) & "=>To ID = " & tasklnk.SuccTask.Get(Tsk.Id))
                    Console.WriteLine("________________________________________")
                Next

                ' Save the project
                project.Save(dataDir & "LinkTasks_out.mpp", SaveFileFormat.MPP)
                ' ExEnd:LinkTasks
            Catch ex As NotSupportedException
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace