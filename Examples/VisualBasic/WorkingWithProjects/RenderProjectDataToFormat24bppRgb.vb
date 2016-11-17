Imports System.Drawing.Imaging
Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects
    Public Class RenderProjectDataToFormat24bppRgb
        Public Shared Sub Run()
            ' ExStart:RenderProjectDataToFormat24bppRgb
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)
            Dim project As New Project(dataDir & Convert.ToString("TestProject1.mpp"))
            Dim options As New ImageSaveOptions(SaveFileFormat.TIFF)
            options.HorizontalResolution = 72
            options.VerticalResolution = 72
            options.PixelFormat = PixelFormat.Format24bppRgb
            project.Save(dataDir & Convert.ToString("RenderProjectDataToFormat24bppRgb_out.tif"), options)
            ' ExEnd:RenderProjectDataToFormat24bppRgb
        End Sub
    End Class
End Namespace