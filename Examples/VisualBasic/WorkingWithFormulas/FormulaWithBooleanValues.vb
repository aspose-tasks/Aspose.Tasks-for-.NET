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
    Public Class FormulaWithBooleanValues
        Public Shared Sub Run()
            ' ExStart:FormulaWithBooleanValues
            Dim project As Project = CreateTestProjectWithCustomField()

            ' Set formula for extended attribute
            project.ExtendedAttributes(0).Formula = "[Critical]-[Marked]+4+[Active]-Not [Active]"

            ' Print value of extened attribute
            Dim task As Task = project.RootTask.Children.GetById(1)
            Console.WriteLine("Formula with boolean values: " + task.ExtendedAttributes(0).Value)
            ' ExEnd:FormulaWithBooleanValues
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
            Dim assn As ResourceAssignment = project.ResourceAssignments.Add(task, rsc)
            Return project
        End Function
    End Class
End Namespace