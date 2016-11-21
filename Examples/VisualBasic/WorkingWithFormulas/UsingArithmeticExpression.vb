
Namespace WorkingWithFormulas
    Public Class UsingArithmeticExpression
        Public Shared Sub Run()
            ' ExStart:UsingArithmeticExpression
            Dim project As Project = CreateTestProjectWithCustomField()

            ' Set arithmetic formula for extended attribute0
            Dim attr As ExtendedAttributeDefinition = project.ExtendedAttributes(0)
            attr.Alias = "Arithmetic Expression"
            attr.Formula = "(1+3*(2+ -5)+8/2)^3"

            ' Display extended attribute value
            Dim task As Task = project.RootTask.Children.GetById(1)
            Console.WriteLine(task.ExtendedAttributes(0).Value)
            ' ExEnd:UsingArithmeticExpression
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
