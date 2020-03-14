using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithFormulas
{
    public class FormulaWithBooleanValues
    {
        public static void Run()
        {
            //ExStart:FormulaWithBooleanValues
            Project project = CreateTestProjectWithCustomField();

            // Set formula for extended attribute
            project.ExtendedAttributes[0].Formula = "[Critical]-[Marked]+4+[Active]-Not [Active]";
            
            // Print value of extened attribute
            Task task = project.RootTask.Children.GetById(1);
            Console.WriteLine("Formula with boolean values: " + task.ExtendedAttributes[0].TextValue);
            //ExEnd:FormulaWithBooleanValues
        }
      
        private static Project CreateTestProjectWithCustomField()
        {
            Project project = new Project();
            project.Set(Prj.StartDate, new DateTime(2015, 3, 6, 8, 0, 0));
            ExtendedAttributeDefinition attr = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Text, ExtendedAttributeTask.Text1, "Custom Field");
            project.ExtendedAttributes.Add(attr);

            Task task = project.RootTask.Children.Add("Task");
            ExtendedAttribute extendedAttribute = attr.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(extendedAttribute);
            return project;
        }
    }
}