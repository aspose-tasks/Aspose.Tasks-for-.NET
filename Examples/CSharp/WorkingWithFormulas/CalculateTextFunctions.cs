namespace Aspose.Tasks.Examples.CSharp.WorkingWithFormulas
{
    using System;

    internal class CalculateTextFunctions
    {
        public static void Run()
        {
            EvaluateStrConv();
            EvaluateStringFunction();
        }

        //ExStart:CalculateTextFunctions
        private static void EvaluateStrConv()
        {
            var project = CreateTestProjectWithCustomField();
            var task = project.RootTask.Children.GetById(1);

            // Set formulas and print extended attribute value
            project.ExtendedAttributes[0].Formula = "StrConv(\"sTring and sTRINg\",3)";
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
            project.ExtendedAttributes[0].Formula = "StrConv(\"sTring and sTRINg\",1)";
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
            project.ExtendedAttributes[0].Formula = "StrConv(\"sTring and sTRINg\",2)";
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
        }

        private static void EvaluateStringFunction()
        {
            var project = CreateTestProjectWithCustomField();
            var task = project.RootTask.Children.GetById(1);
                        
            // Set formulas and print extended attribute value
            project.ExtendedAttributes[0].Formula = "String(5, 40)";
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
            project.ExtendedAttributes[0].Formula = "String(5, \"A\")";
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
            project.ExtendedAttributes[0].Formula = "String(-5, \"A\")";
            // #Error
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
        }
        //ExEnd:CalculateTextFunctions

        private static Project CreateTestProjectWithCustomField()
        {
            var project = new Project();
            var attr = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Text, ExtendedAttributeTask.Text1, "Custom Field");
            project.ExtendedAttributes.Add(attr);

            var task = project.RootTask.Children.Add("Task");

            var a = attr.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(a);
            return project;
        }   
    }
}
