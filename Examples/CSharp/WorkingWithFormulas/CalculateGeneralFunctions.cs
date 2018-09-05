using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithFormulas
{
    class CalculateGeneralFunctions
    {
        public static void Run()
        {
            EvaluateChoose();
            EvaluateIsNumeric();
            EvaluateSwitch();
        }

        // ExStart:CalculateGeneralFunctions
        public static void EvaluateChoose()
        {    
            Project project = CreateTestProjectWithCustomField();
    
            // Set Formula
            project.ExtendedAttributes[0].Formula = "Choose(3, \"This is a\", \"right\", \"choice\")";
    
            // Print extended attribute value
            Task task = project.RootTask.Children.GetById(1);
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
        }

        public static void EvaluateIsNumeric()
        {
            string[] numericFormulas = { "IsNumeric('AAA')", "IsNUmeric(1)", "IsNumeric(1<0)", "IsNumeric(\"1.1\")", "IsNumeric(Choose((2 + Sgn(2^-3)), 123, \"one two three\"))" };
    
            Project project = CreateTestProjectWithCustomField();
    
            foreach (string numericFormula in numericFormulas)    
            {
                // Set Formula
                project.ExtendedAttributes[0].Formula = numericFormula;

                // Print extended attribute value
                Task task = project.RootTask.Children.GetById(1);
                Console.WriteLine(task.ExtendedAttributes[0].TextValue);
            }           
        }

        public static void EvaluateSwitch()
        {    
            Project project = CreateTestProjectWithCustomField();

            // Set Formula
            project.ExtendedAttributes[0].Formula = "Switch( 0 < 1, \"0 is lesser than 1\", 0 > 1, \"0 is greater than 1\")";

            // Print extended attribute value
            Task task = project.RootTask.Children.GetById(1);
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
        }
        // ExEnd:CalculateGeneralFunctions

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
