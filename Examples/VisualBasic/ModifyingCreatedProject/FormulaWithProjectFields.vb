Imports System.Drawing.Printing
Imports System.IO
Imports Aspose.Tasks
Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Tasks.Examples.VisualBasic.ModifyingCreatedProject
    Public Class FormulaWithProjectFields
        Public Shared Sub Run()
            ' ExStart:FormulaWithProjectFields
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingCreatedProject()
            Dim project As Project = CreateTestProjectWithCustomFieldWithoutResource()
            project.ExtendedAttributes(0).Formula = """Total tasks: "" & [Task Count] & "" Total resources: "" & [Resource Count]"
            Dim task As Task = project.RootTask.Children.GetById(1)
            ' ExEnd:FormulaWithProjectFields
        End Sub

        Private Shared Function CreateTestProjectWithCustomFieldWithoutResource() As Project
            Dim project As New Project()
            project.[Set](Prj.StartDate, New DateTime(2015, 3, 6, 8, 0, 0))
            Dim attr As New ExtendedAttributeDefinition()
            project.ExtendedAttributes.Add(attr)
            attr.FieldId = ExtendedAttributeTask.Text1.ToString("D")
            Dim task As Task = project.RootTask.Children.Add("Task")
            Dim a As ExtendedAttribute = attr.CreateExtendedAttribute()
            task.ExtendedAttributes.Add(a)
            Return project
        End Function
    End Class
End Namespace