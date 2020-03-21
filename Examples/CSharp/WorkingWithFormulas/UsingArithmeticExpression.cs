/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithFormulas
{
    using System;

    internal class UsingArithmeticExpression
    {
        public static void Run()
        {
            //ExStart:UsingArithmeticExpression
            //ExFor: ExtendedAttributeDefinition.Formula
            //ExSummary: Shows how to use arithmetic functions with extended attributes.
            var project = CreateTestProjectWithCustomField();
            
            // Set arithmetic formula for extended attribute
            var attr = project.ExtendedAttributes[0];
            attr.Alias = "Arithmetic Expression";
            attr.Formula = "(1+3*(2+ -5)+8/2)^3";

            // Display extended attribute value
            var task = project.RootTask.Children.GetById(1);
            Console.WriteLine(task.ExtendedAttributes[0].NumericValue);
            //ExEnd:UsingArithmeticExpression
        }

        private static Project CreateTestProjectWithCustomField()
        {
            var project = new Project();
            project.Set(Prj.StartDate, new DateTime(2015, 3, 6, 8, 0, 0));
            var attr = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Number, ExtendedAttributeTask.Number1, "Custom");
            project.ExtendedAttributes.Add(attr);

            var task = project.RootTask.Children.Add("Task");
            var extendedAttribute = attr.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(extendedAttribute);
            return project;
        }
    }
}