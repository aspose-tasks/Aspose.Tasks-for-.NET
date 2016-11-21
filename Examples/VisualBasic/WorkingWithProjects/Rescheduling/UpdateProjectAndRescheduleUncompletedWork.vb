Imports System.IO
Imports Aspose.Tasks
Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects.Rescheduling
    Public Class UpdateProjectAndRescheduleUncompletedWork
        Public Shared Sub Run()
            ' ExStart:UpdateProjectAndRescheduleUncompletedWork
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' Create a new project and set start date
            Dim project As New Project()
            project.[Set](Prj.StartDate, New DateTime(2014, 1, 27, 8, 0, 0))

            ' Add new tasks
            Dim task1 As Task = project.RootTask.Children.Add("Task 1")
            Dim task2 As Task = project.RootTask.Children.Add("Task 2")
            task2.[Set](Tsk.Duration, task2.ParentProject.GetDuration(16, TimeUnitType.Hour))
            Dim task3 As Task = project.RootTask.Children.Add("Task 3")
            task3.[Set](Tsk.Duration, task2.ParentProject.GetDuration(24, TimeUnitType.Hour))
            Dim task4 As Task = project.RootTask.Children.Add("Task 4")
            task4.[Set](Tsk.Duration, task2.ParentProject.GetDuration(16, TimeUnitType.Hour))
            Dim task5 As Task = project.RootTask.Children.Add("Task 5")
            task5.[Set](Tsk.Duration, task2.ParentProject.GetDuration(16, TimeUnitType.Hour))

            ' Add links between tasks
            Dim link12 As TaskLink = project.TaskLinks.Add(task1, task2, TaskLinkType.FinishToStart)
            Dim link23 As TaskLink = project.TaskLinks.Add(task2, task3, TaskLinkType.FinishToStart)
            ' one day lag
            link23.LinkLag = 4800
            Dim link34 As TaskLink = project.TaskLinks.Add(task3, task4, TaskLinkType.FinishToStart)
            Dim link45 As TaskLink = project.TaskLinks.Add(task4, task5, TaskLinkType.FinishToStart)

            ' Add new tasks
            Dim task6 As Task = project.RootTask.Children.Add("Task 6")
            Dim task7 As Task = project.RootTask.Children.Add("Task 7")
            task7.[Set](Tsk.Duration, task7.ParentProject.GetDuration(24, TimeUnitType.Hour))
            Dim task8 As Task = project.RootTask.Children.Add("Task 8")
            task8.[Set](Tsk.Duration, task2.ParentProject.GetDuration(16, TimeUnitType.Hour))
            Dim task9 As Task = project.RootTask.Children.Add("Task 9")
            task9.[Set](Tsk.Duration, task2.ParentProject.GetDuration(16, TimeUnitType.Hour))
            Dim task10 As Task = project.RootTask.Children.Add("Task 10")

            ' Add links between tasks
            Dim link67 As TaskLink = project.TaskLinks.Add(task6, task7, TaskLinkType.FinishToStart)
            Dim link78 As TaskLink = project.TaskLinks.Add(task7, task8, TaskLinkType.FinishToStart)
            Dim link89 As TaskLink = project.TaskLinks.Add(task8, task9, TaskLinkType.FinishToStart)
            Dim link910 As TaskLink = project.TaskLinks.Add(task9, task10, TaskLinkType.FinishToStart)
            task6.[Set](Tsk.IsManual, True)
            task7.[Set](Tsk.IsManual, True)
            task8.[Set](Tsk.IsManual, True)
            task9.[Set](Tsk.IsManual, True)
            task10.[Set](Tsk.IsManual, True)

            ' Save project before and after updating work as completed 
            project.Save(dataDir & Convert.ToString("RescheduleUncompletedWork_notUpdated_out.xml"), SaveFileFormat.XML)
            project.UpdateProjectWorkAsComplete(New DateTime(2014, 1, 28, 17, 0, 0), False)
            project.Save(dataDir & Convert.ToString("RescheduleUncompletedWork_updated_out.xml"), SaveFileFormat.XML)

            ' Save project after rescheduling uncompleted work
            project.RescheduleUncompletedWorkToStartAfter(New DateTime(2014, 2, 7, 8, 0, 0))
            project.Save(dataDir & Convert.ToString("RescheduleUncompletedWork_rescheduled_out.xml"), SaveFileFormat.XML)
            ' ExEnd:UpdateProjectAndRescheduleUncompletedWork
        End Sub
    End Class
End Namespace