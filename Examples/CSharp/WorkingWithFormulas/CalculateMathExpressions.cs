namespace Aspose.Tasks.Examples.CSharp.WorkingWithFormulas
{
    using System;

    internal class CalculateMathExpressions
    {
        public static void Run()
        {
            EvaluateSine();
        }

        //ExStart:CalculateMathExpressions
        private static void EvaluateSine()
        {
            var project = CreateTestProjectWithCustomField();
            
            // Set formula Sin(pi/2)
            project.ExtendedAttributes[0].Formula = "Sin(3.1415926/2)";

            // Print Calculated value
            var task = project.RootTask.Children.GetById(1);
            Console.WriteLine("Sin(pi/2): {0}", task.ExtendedAttributes[0].NumericValue);
        }

        private static Project CreateTestProjectWithCustomField()
        {
            var project = new Project();
            var attr = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Number, ExtendedAttributeTask.Number1, "Sine");         
            project.ExtendedAttributes.Add(attr);

            var task = project.RootTask.Children.Add("Task");

            var attribute = attr.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(attribute);
            return project;
        }
        //ExEnd:CalculateMathExpressions
    }
}
