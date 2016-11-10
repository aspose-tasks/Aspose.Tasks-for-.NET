Imports Aspose.Tasks.Util

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithTasks
    Public Class ReadActualTaskProperties
        Public Shared Sub Run()
            ' ExStart:ReadActualTaskProperties
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            Dim project As New Project(dataDir & "TestProject.mpp")

            ' Create a ChildTasksCollector instance
            Dim collector As New ChildTasksCollector()

            ' Collect all the tasks from RootTask using TaskUtils
            TaskUtils.Apply(project.RootTask, collector, 0)

            ' Parse through all the collected tasks
            For Each task As Task In collector.Tasks
                Console.WriteLine("Task Name : " + task.[Get](Tsk.Name))
                Console.WriteLine("Actual Start: " + task.[Get](Tsk.ActualStart).ToLongDateString())
                Console.WriteLine("Actual Finish: " + task.[Get](Tsk.ActualFinish).ToLongDateString())
                Console.WriteLine("Actual Duration: " + task.[Get](Tsk.ActualDuration).TimeSpan.Hours.ToString())
                Console.WriteLine("Actual Cost: " + task.[Get](Tsk.ActualCost).ToString())
                Console.WriteLine("---------------------------------------------")
            Next
            ' ExEnd:ReadActualTaskProperties
        End Sub
    End Class
End Namespace

