Imports System
Imports Aspose.Tasks.Visualization

Namespace WorkingWithProjects
    Public Class GetNumberOfPagesForViews
        Public Shared Sub Run()
            ' ExStart: GetNumberOfPagesForViews
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            '  Read the source Project Get number of pages, Months and ThirdsOfMonths
            Dim project As New Project(dataDir & "GetNumberOfPagesForViews.mpp")
            Console.WriteLine(String.Format("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.Days)))
            Console.WriteLine(String.Format("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.Months)))
            Console.WriteLine(String.Format("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.ThirdsOfMonths)))
            ' ExEnd: GetNumberOfPagesForViews
        End Sub
    End Class
End Namespace