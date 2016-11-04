Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks
Imports System
Imports Aspose.Tasks.Saving

Namespace WorkingWithProjects.Miscellaneous
    Public Class PrintTaskWritingException
        Public Shared Sub Run()
            ' ExStart: PrintTaskWritingException
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            Try
                Dim project As New Project(dataDir & "PrintTaskWritingException.mpp")
                Console.Write("This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.")
                project.Save(dataDir & "project_out.MPP", SaveFileFormat.MPP)
            Catch ex As TasksWritingException
                Console.WriteLine(ex.LogText)
            End Try
            ' ExEnd: PrintTaskWritingException
        End Sub
    End Class
End Namespace