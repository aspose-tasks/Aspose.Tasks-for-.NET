Imports System.IO
Imports Aspose.Tasks
'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects.Miscellaneous
    Public Class ExtractEmbeddedObjects
        Public Shared Sub Run()
            ' ExStart:ExtractEmbeddedObjects
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            Dim project As New Project(dataDir & Convert.ToString("Project1.mpp"))
            Dim ole As OleObject = project.OleObjects.ToList()(0)

            ' We have to check this property because it can be null if the embedded object was created inside the ms project application Or, alternatively, you can use this check: if (ole.FileFormat == "Package")
            If Not String.IsNullOrEmpty(ole.FullPath) Then
                Using fileStream As New FileStream(dataDir, FileMode.Create)
                    fileStream.Write(ole.Content, 0, ole.Content.Length)
                End Using
            End If
            ' ExEnd:ExtractEmbeddedObjects
        End Sub
    End Class
End Namespace
