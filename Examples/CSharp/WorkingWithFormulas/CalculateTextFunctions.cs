using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithFormulas
{
    class CalculateTextFunctions
    {
        public static void Run()
        {
            EvaluateStrConv();
            EvaluateStringFunction();
        }

        // ExStart:CalculateTextFunctions
        public static void EvaluateStrConv()
        {
            Project project = CreateTestProjectWithCustomField();
            Task task = project.RootTask.Children.GetById(1);

            // Set formulas and print extended attribute value
            project.ExtendedAttributes[0].Formula = "StrConv(\"sTring and sTRINg\",3)";
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
            project.ExtendedAttributes[0].Formula = "StrConv(\"sTring and sTRINg\",1)";
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
            project.ExtendedAttributes[0].Formula = "StrConv(\"sTring and sTRINg\",2)";
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
        }

        public static void EvaluateStringFunction()
        {
            Project project = CreateTestProjectWithCustomField();
            Task task = project.RootTask.Children.GetById(1);
                        
            // Set formulas and print extended attribute value
            project.ExtendedAttributes[0].Formula = "String(5, 40)";
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
            project.ExtendedAttributes[0].Formula = "String(5, \"A\")";
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
            project.ExtendedAttributes[0].Formula = "String(-5, \"A\")";
            // #Error
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
        }
        // ExEnd:CalculateTextFunctions

        public static Project CreateTestProjectWithCustomField()
        {
            Project project = new Project();
            ExtendedAttributeDefinition attr = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Text, ExtendedAttributeTask.Text1, "Custom Field");
            project.ExtendedAttributes.Add(attr);

            Task task = project.RootTask.Children.Add("Task");

            ExtendedAttribute a = attr.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(a);
            return project;
        }   
    }
}
