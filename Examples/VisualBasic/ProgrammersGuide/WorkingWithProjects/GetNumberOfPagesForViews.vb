Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks
Imports System
Imports Aspose.Tasks.Visualization

Namespace Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects
    Public Class GetNumberOfPagesForViews
        Public Shared Sub Run()
            'ExStart: GetNumberOfPagesForViews
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Projects()

            'Read the source Project
            Dim project As New Project(dataDir & "GetNumberOfPagesForViews.mpp")


            'Get number of pages
            Console.WriteLine(String.Format("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.Days)))

            'Get number of pages (Months)
            Console.WriteLine(String.Format("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.Months)))

            'Get number of pages (ThirdsOfMonths)
            Console.WriteLine(String.Format("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.ThirdsOfMonths)))
            'ExEnd: GetNumberOfPagesForViews
        End Sub
    End Class
End Namespace