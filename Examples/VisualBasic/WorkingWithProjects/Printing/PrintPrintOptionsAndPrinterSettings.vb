Imports System.Drawing.Printing
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

Namespace WorkingWithProjects.Printing
    Public Class PrintPrintOptionsAndPrinterSettings
        Public Shared Sub Run()
            ' ExStart:PrintPrintOptionsAndPrinterSettings
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Read the input Project file
            Dim project As New Project(dataDir & "Project2.mpp")
            Dim options As New PrintOptions()
            options.Timescale = Timescale.Months

            ' Print first ten pages
            Dim printerSettings As New PrinterSettings()
            printerSettings.PrintRange = PrintRange.SomePages
            printerSettings.FromPage = 1
            printerSettings.ToPage = 2

            Dim pageSettings As System.Drawing.Printing.PageSettings = printerSettings.DefaultPageSettings
            pageSettings.PaperSize = New PaperSize(dataDir & Convert.ToString("Custom Size"), 1000, 700)
            project.Print(printerSettings, options)
            ' ExEnd:PrintPrintOptionsAndPrinterSettings
        End Sub
    End Class
End Namespace