
Namespace WorkingWithFormulas
    Public Class CalculateTextFunctions
        Public Shared Sub Run()
            EvaluateStrConv()
            EvaluateStringFunction()
        End Sub

        ' ExStart:CalculateTextFunctions
        Public Shared Sub EvaluateStrConv()
            Dim project As Project = CreateTestProjectWithCustomField()
            Dim task As Task = project.RootTask.Children.GetById(1)

            ' Set formulas and print extended attribute value
            project.ExtendedAttributes(0).Formula = "StrConv(""sTring and sTRINg"",3)"
            Console.WriteLine(task.ExtendedAttributes(0).Value)
            project.ExtendedAttributes(0).Formula = "StrConv(""sTring and sTRINg"",1)"
            Console.WriteLine(task.ExtendedAttributes(0).Value)
            project.ExtendedAttributes(0).Formula = "StrConv(""sTring and sTRINg"",2)"
            Console.WriteLine(task.ExtendedAttributes(0).Value)
        End Sub

        Public Shared Sub EvaluateStringFunction()
            Dim project As Project = CreateTestProjectWithCustomField()
            Dim task As Task = project.RootTask.Children.GetById(1)

            ' Set formulas and print extended attribute value
            project.ExtendedAttributes(0).Formula = "String(5 ,40)"
            Console.WriteLine(task.ExtendedAttributes(0).Value)
            project.ExtendedAttributes(0).Formula = "String(5 ,""Astr"")"
            Console.WriteLine(task.ExtendedAttributes(0).Value)
            project.ExtendedAttributes(0).Formula = "String(-5 ,""Astr"")"
            Console.WriteLine(task.ExtendedAttributes(0).Value)
        End Sub
        ' ExEnd:CalculateTextFunctions

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