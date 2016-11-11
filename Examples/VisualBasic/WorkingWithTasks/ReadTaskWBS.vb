Imports System.IO
Imports Aspose.Tasks.Util
Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithTasks
    Public Class ReadTaskWBS
        Public Shared Sub Run()
            ' ExStart:ReadTaskWBS
            ' Read project
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            Dim project1 As New Project(dataDir & "project.mpp")

            ' Create a ChildTasksCollector instance
            Dim collector As New ChildTasksCollector()

            ' Collect all the tasks from RootTask using TaskUtils
            TaskUtils.Apply(project1.RootTask, collector, 0)

            ' Parse through all the collected tasks
            For Each tsk1 As Task In collector.Tasks
                Console.WriteLine(tsk1.[Get](Tsk.WBS))
                Console.WriteLine(tsk1.[Get](Tsk.WBSLevel))

                ' Set custom WBS
                tsk1.[Set](Tsk.WBS, "custom wbs" & tsk1.Get(Tsk.WBS))
            Next
            ' ExEnd:ReadTaskWBS

            ' Save project as PDF
            project1.Save(dataDir + "project_out.pdf", SaveFileFormat.PDF)
        End Sub
    End Class
End Namespace

