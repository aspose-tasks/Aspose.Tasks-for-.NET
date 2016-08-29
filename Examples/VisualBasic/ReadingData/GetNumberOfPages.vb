Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks

Namespace Aspose.Tasks.Examples.VisualBasic.ReadingData
    Public Class GetNumberOfPages
        Public Shared Sub Run()
            'ExStart: GetNumberOfPages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ReadingData()
            Dim project As New Project(dataDir & "GetNumberOfPages.mpp")

            ' Read the input Project file Get number of pages, Months and ThirdsOfMonths
            Dim iPages As Integer = project.GetPageCount()
            iPages = project.GetPageCount(Aspose.Tasks.Visualization.Timescale.Months)
            iPages = project.GetPageCount(Aspose.Tasks.Visualization.Timescale.ThirdsOfMonths)
            'ExEnd: GetNumberOfPages
        End Sub
    End Class
End Namespace