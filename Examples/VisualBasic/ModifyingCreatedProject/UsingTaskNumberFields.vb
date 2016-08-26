'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Tasks.Examples.VisualBasic.ModifyingCreatedProject
    Public Class UsingTaskNumberFields
        Public Shared Sub Run()
            ' ExStart:UsingTaskNumberFields
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingCreatedProject()
            Dim project As Project = CreateTestProjectWithCustomField()
            Dim attr As ExtendedAttributeDefinition = project.ExtendedAttributes(0)
            attr.[Alias] = "Task number fields"
            attr.Formula = "([Outline Level] + [Priority] + [% Complete])/2"
            Dim task As Task = project.RootTask.Children.GetById(1)
            ' (1 (Outline Level) + 500 (Priority) + 0 (% Complete) ) / 2
            Console.WriteLine(task.ExtendedAttributes(0).Value)
            task.[Set](Tsk.PercentComplete, 50)
            ' (1 (Outline Level) + 500 (Priority) + 50 (% Complete) ) / 2
            Console.WriteLine(task.ExtendedAttributes(0).Value)
            ' ExEnd:UsingTaskNumberFields
        End Sub

        Private Shared Function CreateTestProjectWithCustomField() As Project
            Dim project As New Project()
            project.[Set](Prj.StartDate, New DateTime(2015, 3, 6, 8, 0, 0))
            Dim attr As New ExtendedAttributeDefinition()
            project.ExtendedAttributes.Add(attr)
            attr.FieldId = ExtendedAttributeTask.Text1.ToString("D")
            Dim task As Task = project.RootTask.Children.Add("Task")
            Dim extendedAttribute As ExtendedAttribute = attr.CreateExtendedAttribute()
            task.ExtendedAttributes.Add(extendedAttribute)
            Dim rsc As Resource = project.Resources.Add("Rsc")
            Dim resourceAssignment As ResourceAssignment = project.ResourceAssignments.Add(task, rsc)
            Return project
        End Function
    End Class
End Namespace
