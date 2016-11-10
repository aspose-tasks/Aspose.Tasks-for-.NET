Imports System.IO
Imports Aspose.Tasks.Util

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithTasks
    Public Class ReadTaskOutlineProperties
        Public Shared Sub Run()
            ' ExStart:ReadTaskOutlineProperties
            ' Read project from file stream
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            Dim fs As New FileStream(dataDir & "project.mpp", FileMode.Open)
            Dim prj As New Project(fs)
            fs.Close()

            ' Create a ChildTasksCollector instance
            Dim collector As New ChildTasksCollector()

            ' Collect all the tasks from RootTask using TaskUtils
            TaskUtils.Apply(prj.RootTask, collector, 0)

            ' Parse through all the collected tasks
            For Each tsk1 As Task In collector.Tasks
                Console.WriteLine(tsk1.Get(Tsk.Name) & " - Outline Level : " & tsk1.[Get](Tsk.OutlineLevel))
                Console.WriteLine(tsk1.Get(Tsk.Name) & " - Outline Number : " & tsk1.[Get](Tsk.OutlineNumber))
            Next
            ' ExEnd:ReadTaskOutlineProperties
        End Sub
    End Class
End Namespace

