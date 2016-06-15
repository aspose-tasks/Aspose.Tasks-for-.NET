Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks

Namespace Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects
    Public Class GetNumberOfPages
        Public Shared Sub Run()
            'ExStart: GetNumberOfPages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Projects()



            'Read the input Project file
            Dim project As New Project(dataDir & "GetNumberOfPages.mpp")

            'Get number of pages
            Dim iPages As Integer = project.GetPageCount()

            'Get number of pages (Timescale.Months)
            iPages = project.GetPageCount(Aspose.Tasks.Visualization.Timescale.Months)

            'Get number of pages (Timescale.ThirdsOfMonths)
            iPages = project.GetPageCount(Aspose.Tasks.Visualization.Timescale.ThirdsOfMonths)
            'ExEnd: GetNumberOfPages
        End Sub
    End Class
End Namespace