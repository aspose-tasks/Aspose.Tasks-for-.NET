Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks
Imports System

Namespace Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects
    Public Class DetermineProjectVersion
        Public Shared Sub Run()
            'ExStart: DetermineProjectVersion
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Projects()
            Dim project As New Project(dataDir & "DetermineProjectVersion.mpp")
            Console.WriteLine("Project Version : " & project.Get(Prj.SaveVersion).ToString())
            Console.WriteLine("Last Saved : " & project.Get(Prj.LastSaved).ToShortDateString())
            'ExEnd:DetermineProjectVersion
        End Sub
    End Class
End Namespace