Imports System.Collections.Generic
Imports System.IO
Imports Aspose.Tasks
Imports Aspose.Tasks.Connectivity
Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects.ImportingAndExporting
    Public Class ExportProjectDataToXERFormat
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:ExportProjectDataToXERFormat
            Dim project As New Project(dataDir & Convert.ToString("Project1.mpp"))

            ' Save project in desired format
            project.Save(dataDir & Convert.ToString("ExportProjectDataToXERFormat_out.mpp"), SaveFileFormat.PrimaveraXER)
            ' ExEnd:ExportProjectDataToXERFormat
        End Sub
    End Class
End Namespace