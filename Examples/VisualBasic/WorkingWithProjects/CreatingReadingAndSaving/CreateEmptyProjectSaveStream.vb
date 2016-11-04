Imports Aspose.Tasks.Saving
Imports System.IO

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects.CreatingReadingAndSaving
    Public Class CreateEmptyProjectSaveStream
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' ExStart:CreateEmptyProjectSaveStream
            ' Create a project instance
            Dim newProject As Project = New Project()

            ' Create a file stream
            Using projectStream As FileStream = New FileStream(dataDir & "Project1_out.xml", FileMode.Create, FileAccess.Write)
                ' Write the stream into XML format
                newProject.Save(projectStream, SaveFileFormat.XML)
            End Using
            ' ExEnd: CreateEmptyProjectSaveStream
        End Sub
    End Class
End Namespace

