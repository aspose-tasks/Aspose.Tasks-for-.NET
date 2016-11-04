Imports Aspose.Tasks
Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects.WorkingWithProjectProperties
    Public Class WriteMPPProjectSummary
        Public Shared Sub Run()
            Try
                ' ExStart: WriteMPPProjectSummary
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

                ' Instantiate Project class
                Dim project As New Project(dataDir & "WriteMPPProjectSummary.mpp")

                ' Set project summary
                project.Set(Prj.Author, "Author")
                project.Set(Prj.LastAuthor, "Last Author")
                project.Set(Prj.Revision, 15)
                project.Set(Prj.Keywords, "MSP Aspose")
                project.Set(Prj.Comments, "Comments")
                project.Save(dataDir & "saved_out.mpp", SaveFileFormat.MPP)
                ' ExEnd: WriteMPPProjectSummary
            Catch ex As Exception
                Console.WriteLine(ex.Message & "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace