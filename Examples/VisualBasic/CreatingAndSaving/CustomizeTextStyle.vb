Imports System.Collections.Generic
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

Namespace Aspose.Tasks.Examples.VisualBasic.CreatingAndSaving
    Public Class CustomizeTextStyle
        Public Shared Sub Run()
            ' ExStart:CustomizeTextStyle
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreatingAndSaving()
            ' Create a project instance and Set default properties
            Dim project As New Project(dataDir & Convert.ToString("Project2.mpp"))
            Dim options As SaveOptions = New PdfSaveOptions()
            options.PresentationFormat = PresentationFormat.ResourceSheet
            Dim style As New TextStyle()
            style.Color = Color.OrangeRed
            style.FontStyle = FontStyle.Bold
            style.FontStyle = style.FontStyle Or FontStyle.Italic
            style.ItemType = TextItemType.OverallocatedResources
            options.TextStyles = New List(Of TextStyle)()
            options.TextStyles.Add(style)
            project.Save(dataDir & Convert.ToString("CustomizeTextStyle_out.pdf"), options)
            ' ExEnd:CustomizeTextStyle
        End Sub
    End Class
End Namespace