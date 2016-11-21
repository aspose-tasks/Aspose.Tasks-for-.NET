Imports System.IO
Imports Aspose.Tasks
Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects.CreatingReadingAndSaving
    Public Class ReadProjectFileFromStream
        Public Shared Sub Run()
            ' ExStart:ReadProjectFileFromStream
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' Read project xml into file stream
            Using filesStream As Stream = New FileStream(dataDir & Convert.ToString("ReadProjectFileFromStream.xml"), FileMode.Open)
                ' Create project using file stream
                Dim project As New Project(filesStream)
            End Using
            ' ExEnd:ReadProjectFileFromStream
        End Sub
    End Class
End Namespace