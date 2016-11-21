
Namespace WorkingWithFormulas
    Public Class CalculateGeneralFunctions
        Public Shared Sub Run()
            EvaluateChoose()
            EvaluateIsNumeric()
            EvaluateSwitch()
        End Sub

        ' ExStart:CalculateGeneralFunctions
        Public Shared Sub EvaluateChoose()
            Dim project As Project = CreateTestProjectWithCustomField()

            ' Set Formula
            project.ExtendedAttributes(0).Formula = "Choose(3, ""This is a"", ""right"", ""choice"")"

            ' Print extended attribute value
            Dim task As Task = project.RootTask.Children.GetById(1)
            Console.WriteLine(task.ExtendedAttributes(0).Value)
        End Sub

        Public Shared Sub EvaluateIsNumeric()
            Dim numericFormulas() As String = {"IsNUmeric(1)", "IsNumeric(1<0)", "IsNumeric(""1.1"")", "IsNumeric(Choose((2 + Sgn(2^-3)), 123, ""one two three""))"}
            Dim project As Project = CreateTestProjectWithCustomField()

            For Each numericFormula As String In numericFormulas
                ' Set Formula
                project.ExtendedAttributes(0).Formula = numericFormula

                ' Print extended attribute value
                Dim task As Task = project.RootTask.Children.GetById(1)
                Console.WriteLine(task.ExtendedAttributes(0).Value)
            Next
        End Sub

        Public Shared Sub EvaluateSwitch()
            Dim project As Project = CreateTestProjectWithCustomField()

            ' Set Formula
            project.ExtendedAttributes(0).Formula = "Switch(False, ""False predicate"", true, ""True predicate"")"

            ' Print extended attribute value
            Dim task As Task = project.RootTask.Children.GetById(1)
            Console.WriteLine(task.ExtendedAttributes(0).Value)
        End Sub
        ' ExEnd:CalculateGeneralFunctions

        Public Shared Function CreateTestProjectWithCustomField() As Project
            Dim project As New Project()
            Dim attr As ExtendedAttributeDefinition = New ExtendedAttributeDefinition()
            attr.FieldId = ExtendedAttributeTask.Text1.ToString("D")
            attr.Alias = "Custom Field"
            project.ExtendedAttributes.Add(attr)

            Dim task As Task = project.RootTask.Children.Add("Task")
            Dim a As ExtendedAttribute = attr.CreateExtendedAttribute()
            task.ExtendedAttributes.Add(a)
            Return project
        End Function
    End Class
End Namespace
