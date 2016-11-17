
Namespace WorkingWithFormulas
    Public Class CalculateDateTimeFunctions
        Public Shared Sub Run()
            ' ExStart:CalculateDateTimeFunctions
            Dim project As Project = CreateTestProjectWithCustomField()
            Dim task As Task = Project.RootTask.Children.GetById(1)

            ' Set ProjDateDiff formula and print entended attribute value
            project.ExtendedAttributes(0).Formula = "ProjDateDiff(""03/23/2015"",""03/18/2015"")"
            Console.WriteLine(task.ExtendedAttributes(0).Value)
            project.ExtendedAttributes(0).Formula = "ProjDateDiff(""03/23/2015"",""03/25/2015"")"
            Console.WriteLine(task.ExtendedAttributes(0).Value)

            ' Set ProjDateSub formula and print entended attribute value
            project.ExtendedAttributes(0).Formula = "ProjDateSub(""3/19/2015"", ""1d"")"
            Console.WriteLine(task.ExtendedAttributes(0).Value)

            ' Set ProjDurConv formula and print entended attribute value
            project.ExtendedAttributes(0).Formula = "ProjDurConv([Duration], pjHours)"
            Console.WriteLine(task.ExtendedAttributes(0).Value)
            project.ExtendedAttributes(0).Formula = "ProjDurConv([Duration], pjWeeks)"
            Console.WriteLine(task.ExtendedAttributes(0).Value)

            ' Set Second formula and print entended attribute value
            project.ExtendedAttributes(0).Formula = "Second(""4/21/2015 2:53:41 AM"")"
            Console.WriteLine(task.ExtendedAttributes(0).Value)

            ' Set Weekday formula and print entended attribute value
            project.ExtendedAttributes(0).Formula = "Weekday(""24/3/2015"", 1)"
            Console.WriteLine(task.ExtendedAttributes(0).Value)
            project.ExtendedAttributes(0).Formula = "Weekday(""24/3/2015"", 2)"
            Console.WriteLine(task.ExtendedAttributes(0).Value)
            project.ExtendedAttributes(0).Formula = "Weekday(""24/3/2015"", 3)"
            Console.WriteLine(Task.ExtendedAttributes(0).Value)
            ' ExEnd:CalculateDateTimeFunctions
        End Sub

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
