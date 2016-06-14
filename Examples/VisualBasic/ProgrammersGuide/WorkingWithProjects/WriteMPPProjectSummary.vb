Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks
Imports System
Imports Aspose.Tasks.Saving

Namespace Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects
    Public Class WriteMPPProjectSummary
        Public Shared Sub Run()
            'ExStart: WriteMPPProjectSummary
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Projects()

            'Instantiate ProjectReader class
            Dim project As New Project(dataDir & "WriteMPPProjectSummary.mpp")
            project.Set(Prj.Author, "Author")
            project.Set(Prj.LastAuthor, "Last Author")
            project.Set(Prj.Revision, 15)
            project.Set(Prj.Keywords, "MSP Aspose")
            project.Set(Prj.Comments, "Comments")

            project.Save(dataDir & "saved.mpp", SaveFileFormat.MPP)
            'ExEnd: WriteMPPProjectSummary
        End Sub
    End Class
End Namespace