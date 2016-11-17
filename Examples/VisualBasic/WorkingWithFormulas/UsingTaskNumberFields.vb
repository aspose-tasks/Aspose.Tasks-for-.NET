'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithFormulas
    Public Class UsingTaskNumberFields
        Public Shared Sub Run()
            ' ExStart:UsingTaskNumberFields
            Dim project As Project = CreateTestProjectWithCustomField()

            ' Set formula
            Dim attr As ExtendedAttributeDefinition = project.ExtendedAttributes(0)
            attr.[Alias] = "Task number fields"
            attr.Formula = "([Outline Level] + [Priority] + [% Complete])/2"

            Dim task As Task = project.RootTask.Children.GetById(1)

            ' Print extended attribute value before and after updating task percent complete
            Console.WriteLine(task.ExtendedAttributes(0).Value)
            task.[Set](Tsk.PercentComplete, 50)
            Console.WriteLine(task.ExtendedAttributes(0).Value)
            ' ExEnd:UsingTaskNumberFields
        End Sub

        Private Shared Function CreateTestProjectWithCustomField() As Project
            Dim project As New Project()
            project.[Set](Prj.StartDate, New DateTime(2015, 3, 6, 8, 0, 0))
            Dim attr As New ExtendedAttributeDefinition()
            attr.FieldId = ExtendedAttributeTask.Text1.ToString("D")
            project.ExtendedAttributes.Add(attr)

            Dim task As Task = project.RootTask.Children.Add("Task")
            Dim extendedAttribute As ExtendedAttribute = attr.CreateExtendedAttribute()
            task.ExtendedAttributes.Add(extendedAttribute)
            Dim rsc As Resource = project.Resources.Add("Rsc")
            Dim resourceAssignment As ResourceAssignment = project.ResourceAssignments.Add(task, rsc)
            Return project
        End Function
    End Class
End Namespace
