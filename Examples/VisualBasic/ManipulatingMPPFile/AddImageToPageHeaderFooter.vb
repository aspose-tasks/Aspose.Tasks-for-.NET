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

Namespace Aspose.Tasks.Examples.VisualBasic.ManipulatingMPPFile
    Public Class AddImageToPageHeaderFooter
        Public Shared Sub Run()
            ' ExStart:AddImageToPageHeaderFooter
            Try
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_ManipulatingMPPFile()

                Dim project As New Project(dataDir & Convert.ToString("Project1.mpp"))
                project.RootTask.Children.Add("Task1")
                Dim pageInfo As PageInfo = project.DefaultView.PageInfo

                Using image__1 As Image = Image.FromFile(dataDir & Convert.ToString("Image1.png"))
                    pageInfo.Header.CenteredImage = image__1
                    pageInfo.Legend.LeftImage = image__1
                    pageInfo.Legend.LeftText = String.Empty

                    Dim saveOptions As New MPPSaveOptions()
                    saveOptions.WriteViewData = True
                    ' see the result in the attached screenshot 
                    project.Save(dataDir & Convert.ToString("ReadHeaderAndFooterInformationFromMPPFile1_out.mpp"), saveOptions)
                End Using
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try
            ' ExEnd:AddImageToPageHeaderFooter
        End Sub
    End Class
End Namespace