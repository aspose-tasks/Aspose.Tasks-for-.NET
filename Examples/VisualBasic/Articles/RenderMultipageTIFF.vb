Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Articles
    Public Class RenderMultipageTIFF
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:RenderMultipageTIFF
            ' Source file to be converted to TIFF
            Dim file As String = "Project2.mpp"
            Dim project As New Project(dataDir & file)

            ' Save the project to TIFF
            project.Save(dataDir & "RenderMultipageTIFF_out.tif", SaveFileFormat.TIFF)

            ' Save the project with CCITT4 compression
            Dim options As New ImageSaveOptions(SaveFileFormat.TIFF)
            options.TiffCompression = TiffCompression.Ccitt4
            project.Save(dataDir & "RenderMultipageTIFF_options_out.tif", options)

            ' Remove the compression
            options.TiffCompression = TiffCompression.None
            project.Save(dataDir & "RenderMultipageTIFF_comp_none_out.tif", options)
            ' ExEnd:RenderMultipageTIFF
        End Sub
    End Class
End Namespace