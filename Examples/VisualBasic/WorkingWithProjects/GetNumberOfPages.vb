Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks

Namespace WorkingWithProjects
    Public Class GetNumberOfPages
        Public Shared Sub Run()
            ' ExStart: GetNumberOfPages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            Dim project As New Project(dataDir & "GetNumberOfPages.mpp")

            ' Read the input Project file Get number of pages, Months and ThirdsOfMonths
            Dim iPages As Integer = project.GetPageCount()
            iPages = project.GetPageCount(Visualization.Timescale.Months)
            iPages = project.GetPageCount(Visualization.Timescale.ThirdsOfMonths)
            ' ExEnd: GetNumberOfPages
        End Sub
    End Class
End Namespace