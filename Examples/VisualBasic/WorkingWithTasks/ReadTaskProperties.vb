Imports Aspose.Tasks.Util

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithTasks
    Public Class ReadTaskProperties
        Public Shared Sub Run()
            ' ExStart:ReadTaskProperties
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' Create project instance
            Dim prj As New Project(dataDir & "ReadTaskProperties.mpp")

            ' Create a ChildTasksCollector instance
            Dim collector As New ChildTasksCollector()

            ' Collect all the tasks from RootTask using TaskUtils
            TaskUtils.Apply(prj.RootTask, collector, 0)

            ' Parse through all the collected tasks
            For Each tsk__1 As Task In collector.Tasks
                Console.WriteLine("Task Id: {0}", tsk__1.[Get](Tsk.Id))
                Console.WriteLine("Task Uid: {0}", tsk__1.[Get](Tsk.Uid))
                Console.WriteLine("Task Name: {0}", tsk__1.[Get](Tsk.Name))
                Console.WriteLine("Task Start: {0}", tsk__1.[Get](Tsk.Start))
                Console.WriteLine("Task Finish: {0}", tsk__1.[Get](Tsk.Finish))
            Next
            ' ExEnd:ReadTaskProperties
        End Sub
    End Class
End Namespace
