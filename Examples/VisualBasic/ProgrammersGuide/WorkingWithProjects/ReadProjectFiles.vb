Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks
Imports System

Namespace Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects
    Public Class ReadProjectFiles
        Public Shared Sub Run()
            'ExStart: ReadProjectFiles
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Projects()

            Dim project As New Project(dataDir & "ReadProjectFiles.mpp")
            'ExEnd: ReadProjectFiles
        End Sub
    End Class
End Namespace