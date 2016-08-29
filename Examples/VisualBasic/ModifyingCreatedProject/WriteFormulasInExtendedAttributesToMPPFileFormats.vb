Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Tasks.Examples.VisualBasic.ModifyingCreatedProject
    Public Class WriteFormulasInExtendedAttributesToMPPFileFormats
        Public Shared Sub Run()
            ' ExStart:WriteFormulasInExtendedAttributesToMPPFileFormats

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingCreatedProject()
            Dim project As New Project(dataDir & Convert.ToString("Project1.mpp"))
            project.[Set](Prj.NewTasksAreManual, False)

            ' Create new custom field (Task Text1) with formula which will double task cost
            Dim attr As New ExtendedAttributeDefinition()
            project.ExtendedAttributes.Add(attr)
            attr.FieldId = ExtendedAttributeTask.Text1.ToString("D")
            attr.[Alias] = "Double Costs"
            attr.Formula = "[Cost]*2"

            ' Add a task to see the result in MSP
            Dim task As Task = project.RootTask.Children.Add("Task")

            ' Set task cost            
            task.[Set](Tsk.Cost, 100)
            ' See the result in the attached screenshot (result.jpg)
            project.Save(dataDir & Convert.ToString("WriteFormulasInExtendedAttributesToMPPFileFormats_out.mpp"), SaveFileFormat.MPP)
            ' ExEnd:WriteFormulasInExtendedAttributesToMPPFileFormats
        End Sub
    End Class
End Namespace