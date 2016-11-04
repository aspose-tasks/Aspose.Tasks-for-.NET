Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks
Imports System

Namespace WorkingWithProjects.CreatingReadingAndSaving
    Public Class ReadProjectFiles
        Public Shared Sub Run()
            ' ExStart: ReadProjectFiles
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Read existing project template file
            Dim project As New Project(dataDir & "ReadProjectFiles.mpp")
            ' ExEnd: ReadProjectFiles
        End Sub
    End Class
End Namespace