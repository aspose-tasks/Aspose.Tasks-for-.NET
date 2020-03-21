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

    internal class FormulaWithProjectFields
    {
        //ExStart:FormulaWithProjectFields
        //ExFor: ExtendedAttributeDefinition.Formula
        //ExSummary: Shows how to use extended attribute functions by using project fields.
        public static void Run()
        {            
            var project = CreateTestProjectWithCustomFieldWithoutResource();

            // Set formula
            project.ExtendedAttributes[0].Formula = "\"Total tasks: \" & [Task Count] & \" Total resources: \" & [Resource Count]";
            
            // Print if formula value is computed correctly
            var task = project.RootTask.Children.GetById(1);
            Console.WriteLine("Check Total tasks: 1 Total resources: 0 - {0}", task.ExtendedAttributes[0].TextValue.Equals("Total tasks: 1 Total resources: 0"));            
        }

        private static Project CreateTestProjectWithCustomFieldWithoutResource()
        {
            var project = new Project();
            project.Set(Prj.StartDate, new DateTime(2015, 3, 6, 8, 0, 0));
            var attr = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Text, ExtendedAttributeTask.Text1, "Custom");
            project.ExtendedAttributes.Add(attr);
         
            var task = project.RootTask.Children.Add("Task");
            var attribute = attr.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(attribute);
            return project;
        }
        //ExEnd:FormulaWithProjectFields
    }
}