Imports Aspose.Tasks.Saving

Namespace Aspose.Tasks.Examples.VisualBasic.HandlingBasicProperties
    Public Class WriteProjectInfo
        Public Shared Sub Run()
            'ExStart: WriteProjectInfo
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_HandlingBasicProperties()
            Dim project As New Project(dataDir & "WriteProjectInfo.mpp")
            project.Set(Prj.Author, "Author")
            project.Set(Prj.LastAuthor, "Last Author")
            project.Set(Prj.Revision, 15)
            project.Set(Prj.Keywords, "MSP Aspose")
            project.Set(Prj.Comments, "Comments")
            project.Save(dataDir & "saved.mpp", SaveFileFormat.MPP)
            'ExEnd: WriteProjectInfo
        End Sub
    End Class
End Namespace