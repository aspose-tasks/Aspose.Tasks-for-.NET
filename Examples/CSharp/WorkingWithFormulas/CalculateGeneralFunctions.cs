namespace Aspose.Tasks.Examples.CSharp.WorkingWithFormulas
{
    using System;

    internal class CalculateGeneralFunctions
    {
        public static void Run()
        {
            EvaluateChoose();
            EvaluateIsNumeric();
            EvaluateSwitch();
        }

        //ExStart:CalculateGeneralFunctions
        //ExFor: ExtendedAttributeDefinition.Formula
        //ExSummary: Shows how to use common math functions with extended attributes.
        private static void EvaluateChoose()
        {    
            var project = CreateTestProjectWithCustomField();
    
            // Set Formula
            project.ExtendedAttributes[0].Formula = "Choose(3, \"This is a\", \"right\", \"choice\")";
    
            // Print extended attribute value
            var task = project.RootTask.Children.GetById(1);
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
        }

        private static void EvaluateIsNumeric()
        {
            string[] numericFormulas = { "IsNumeric('AAA')", @"IsNUmeric(1)", "IsNumeric(1<0)", "IsNumeric(\"1.1\")", "IsNumeric(Choose((2 + Sgn(2^-3)), 123, \"one two three\"))" };
    
            var project = CreateTestProjectWithCustomField();
    
            foreach (var numericFormula in numericFormulas)    
            {
                // Set Formula
                project.ExtendedAttributes[0].Formula = numericFormula;

                // Print extended attribute value
                var task = project.RootTask.Children.GetById(1);
                Console.WriteLine(task.ExtendedAttributes[0].TextValue);
            }           
        }

        private static void EvaluateSwitch()
        {    
            var project = CreateTestProjectWithCustomField();

            // Set Formula
            project.ExtendedAttributes[0].Formula = "Switch( 0 < 1, \"0 is lesser than 1\", 0 > 1, \"0 is greater than 1\")";

            // Print extended attribute value
            var task = project.RootTask.Children.GetById(1);
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
        }
        //ExEnd:CalculateGeneralFunctions

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
