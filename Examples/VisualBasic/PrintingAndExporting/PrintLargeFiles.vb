Imports System.IO
Imports Aspose.Tasks
Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Tasks.Examples.VisualBasic.PrintingAndExporting
    Public Class PrintLargeFiles
        Public Shared Sub Run()
            ' ExStart:PrintLargeFiles
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Projects()
            ' Read the input Project file
            Dim project As New Project(dataDir & Convert.ToString("Project2.mpp"))
            Dim options As New PrintOptions()
            options.Timescale = Timescale.ThirdsOfMonths
            If project.GetPageCount(Timescale.ThirdsOfMonths) <= 280 Then
                project.Print(options)
            End If
            ' ExEnd:PrintLargeFiles
        End Sub
    End Class
End Namespace