Imports System.Drawing
Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects
    Public Class AddImageToPageHeaderFooter
        Public Shared Sub Run()
            Try
                ' ExStart:AddImageToPageHeaderFooter
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
                Dim project As New Project(dataDir & Convert.ToString("Project1.mpp"))

                project.RootTask.Children.Add("Task1")
                Dim pageInfo As PageInfo = project.DefaultView.PageInfo

                Using image__1 As Image = Image.FromFile(dataDir & Convert.ToString("Image1.png"))
                    pageInfo.Header.CenteredImage = image__1
                    pageInfo.Legend.LeftImage = image__1
                    pageInfo.Legend.LeftText = String.Empty

                    Dim saveOptions As New MPPSaveOptions()
                    saveOptions.WriteViewData = True
                    project.Save(dataDir & Convert.ToString("ReadHeaderAndFooterInformationFromMPPFile1_out.mpp"), saveOptions)
                End Using
                ' ExEnd:AddImageToPageHeaderFooter
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace