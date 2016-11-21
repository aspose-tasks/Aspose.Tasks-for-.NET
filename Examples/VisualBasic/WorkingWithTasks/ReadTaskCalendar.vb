Imports Aspose.Tasks.Util

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithTasks
    Public Class ReadTaskCalendar
        Public Shared Sub Run()
            ' ExStart:ReadTaskCalendar
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' Create project instance
            Dim prj As New Project(dataDir & "ReadTaskCalendar.mpp")

            ' Declare ChildTasksCollector class object
            Dim collector As New ChildTasksCollector()

            ' Use TaskUtils to get all children tasks in RootTask
            TaskUtils.Apply(prj.RootTask, collector, 0)

            ' Parse all the recursive children
            For Each tsk__1 As Task In collector.Tasks
                Dim tskCal As Calendar = tsk__1.[Get](Tsk.Calendar)
                Console.WriteLine("Task calendar name: {0}", If(tskCal Is Nothing, "None", tskCal.Name))
            Next
            ' ExEnd:ReadTaskCalendar
        End Sub
    End Class
End Namespace

