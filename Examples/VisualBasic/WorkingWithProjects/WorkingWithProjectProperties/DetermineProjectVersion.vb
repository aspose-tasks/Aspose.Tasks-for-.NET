Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks
Imports System

Namespace WorkingWithProjects.WorkingWithProjectProperties
    Public Class DetermineProjectVersion
        Public Shared Sub Run()
            ' ExStart: DetermineProjectVersion
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' Read project from template file
            Dim project As New Project(dataDir & "DetermineProjectVersion.mpp")

            ' Display project version
            Console.WriteLine("Project Version : " & project.Get(Prj.SaveVersion).ToString())
            Console.WriteLine("Last Saved : " & project.Get(Prj.LastSaved).ToShortDateString())
            ' ExEnd:DetermineProjectVersion
        End Sub
    End Class
End Namespace