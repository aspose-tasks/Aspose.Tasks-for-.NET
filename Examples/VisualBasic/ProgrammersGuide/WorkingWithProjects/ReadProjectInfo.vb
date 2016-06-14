Imports Microsoft.VisualBasic
Imports System.IO
Imports System
Imports Aspose.Tasks

Namespace Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects
    Public Class ReadProjectInfo
        Public Shared Sub Run()
            'ExStart: ReadProjectInfo
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Projects()

            'Create a project reader instance
            Dim project As New Project(dataDir & "ReadProjectInfo.mpp")
            If project.Get(Prj.ScheduleFromStart) Then
                Console.WriteLine("Project Finish Date : " & project.Get(Prj.StartDate).ToShortDateString())
            Else
                Console.WriteLine("Project Finish Date : " & project.Get(Prj.FinishDate).ToShortDateString())
            End If
            Console.WriteLine(project.Get(Prj.Author))
            Console.WriteLine(project.Get(Prj.LastAuthor))
            Console.WriteLine(project.Get(Prj.Revision))
            Console.WriteLine(project.Get(Prj.Keywords))
            Console.WriteLine(project.Get(Prj.Comments))
            Console.WriteLine("The program has run successfully")
            'ExEnd: ReadProjectInfo
        End Sub
    End Class
End Namespace