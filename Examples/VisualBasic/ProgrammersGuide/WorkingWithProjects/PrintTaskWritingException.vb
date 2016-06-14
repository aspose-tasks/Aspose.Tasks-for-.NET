Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks
Imports System

Namespace Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects
    Public Class PrintTaskWritingException
        Public Shared Sub Run()
            'ExStart: PrintTaskWritingException
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Projects()

            Dim project As New Project(dataDir & "PrintTaskWritingException.mpp")

            Try
                project.Save("project.MPP", Aspose.Tasks.Saving.SaveFileFormat.MPP)
            Catch ex As TasksWritingException
                Console.WriteLine(ex.LogText)
            End Try
            'ExEnd: PrintTaskWritingException
        End Sub
    End Class
End Namespace