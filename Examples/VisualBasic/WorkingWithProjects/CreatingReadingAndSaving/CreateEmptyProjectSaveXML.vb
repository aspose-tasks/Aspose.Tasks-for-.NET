Imports Aspose.Tasks.Saving

Namespace WorkingWithProjects.CreatingReadingAndSaving
    Public Class CreateEmptyProjectSaveXML
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' ExStart:CreateEmptyProjectSaveXML
            ' Create empty project 
            Dim project As New Project()

            ' Save project as xml 
            project.Save(dataDir & "saved_out.xml", SaveFileFormat.XML)
            ' ExEnd: CreateEmptyProjectSaveXML
        End Sub
    End Class
End Namespace