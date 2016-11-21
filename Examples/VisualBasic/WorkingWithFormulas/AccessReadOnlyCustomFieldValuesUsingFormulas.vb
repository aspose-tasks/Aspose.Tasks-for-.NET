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

Namespace WorkingWithFormulas
    Public Class AccessReadOnlyCustomFieldValuesUsingFormulas
        Public Shared Sub Run()
            ' ExStart:AccessReadOnlyCustomFieldValuesUsingFormulas
            ' Create new project and extended attribute definition
            Dim project As New Project()
            Dim attribute As New ExtendedAttributeDefinition() With { _
                .FieldId = CInt(ExtendedAttributeTask.Text1).ToString(), _
                .Formula = "[Cost]-[Actual Cost]" _
            }
            project.ExtendedAttributes.Add(attribute)

            ' Add task
            Dim task As Task = project.RootTask.Children.Add("Task")

            ' Create extended attribute
            Dim extendedAttribute As ExtendedAttribute = attribute.CreateExtendedAttribute()
            task.ExtendedAttributes.Add(extendedAttribute)

            ' Display if extended attributes are read only or not
            Console.WriteLine(If(extendedAttribute.ValueReadOnly = True, "Value is Read only", "Value is not read only"))
            extendedAttribute.Value = "Invalid"
            Console.WriteLine(If(extendedAttribute.Value = String.Empty, "Formula values are read-only", "Values are not read-only"))
            ' ExEnd:AccessReadOnlyCustomFieldValuesUsingFormulas
        End Sub
    End Class
End Namespace