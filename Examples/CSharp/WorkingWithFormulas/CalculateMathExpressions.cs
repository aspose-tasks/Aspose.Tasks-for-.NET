using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithFormulas
{
    class CalculateMathExpressions
    {
        public static void Run()
        {
            EvaluateSine();
        }

        // ExStart:CalculateMathExpressions
        public static void EvaluateSine()
        {
            Project project = CreateTestProjectWithCustomField();
            
            // Set formula Sin(pi/2)
            project.ExtendedAttributes[0].Formula = "Sin(3.1415926/2)";

            // Print Calculated value
            Task task = project.RootTask.Children.GetById(1);
            Console.WriteLine("Sin(pi/2): {0}", task.ExtendedAttributes[0].NumericValue);
        }

        public static Project CreateTestProjectWithCustomField()
        {
            Project project = new Project();
            ExtendedAttributeDefinition attr = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Number, ExtendedAttributeTask.Number1, "Sine");         
            project.ExtendedAttributes.Add(attr);

            Task task = project.RootTask.Children.Add("Task");

            ExtendedAttribute a = attr.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(a);
            return project;
        }
        // ExEnd:CalculateMathExpressions
    }
}
