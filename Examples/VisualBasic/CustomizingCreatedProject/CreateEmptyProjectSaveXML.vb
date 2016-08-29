Imports Aspose.Tasks.Saving

Namespace Aspose.Tasks.Examples.VisualBasic.CustomizingCreatedProject
    Public Class CreateEmptyProjectSaveXML
        Public Shared Sub Run()
            'ExStart: CreateEmptyProjectSaveXML
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CustomizingCreatedProject()
            Dim project As New Project()
            project.Save(dataDir & "saved.xml", SaveFileFormat.XML)
            'ExEnd: CreateEmptyProjectSaveXML
        End Sub
    End Class
End Namespace