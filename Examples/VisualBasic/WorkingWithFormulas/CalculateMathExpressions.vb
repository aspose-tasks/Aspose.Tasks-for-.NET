
Namespace WorkingWithFormulas
    Public Class CalculateMathExpressions
        Public Shared Sub Run()
            EvaluateSine()
        End Sub

        ' ExStart:CalculateMathExpressions
        Public Shared Sub EvaluateSine()
            Dim project As Project = CreateTestProjectWithCustomField()

            ' Set formula Sin(pi/2)
            project.ExtendedAttributes(0).Formula = "Sin(3.1415926/2)"

            ' Print Calculated value
            Dim task As Task = project.RootTask.Children.GetById(1)
            Console.WriteLine("Sin(pi/2): {0}", task.ExtendedAttributes(0).Value)
        End Sub

        Public Shared Function CreateTestProjectWithCustomField() As Project
            Dim project As New Project()
            Dim attr As New ExtendedAttributeDefinition()
            attr.FieldId = ExtendedAttributeTask.Text1.ToString("D")
            attr.Alias = "Sine"
            project.ExtendedAttributes.Add(attr)

            Dim Task = project.RootTask.Children.Add("Task")

            Dim a As ExtendedAttribute = attr.CreateExtendedAttribute()
            Task.ExtendedAttributes.Add(a)
            Return project
        End Function
        ' ExEnd:CalculateMathExpressions
    End Class
End Namespace
