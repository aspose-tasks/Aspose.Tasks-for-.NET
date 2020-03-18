namespace Aspose.Tasks.Examples.CSharp.WorkingWithFormulas
{
    using System;

    public class AccessReadOnlyCustomFieldValuesUsingFormulas
    {
        public static void Run()
        {
            //ExStart:AccessReadOnlyCustomFieldValuesUsingFormulas
            // Create new project and extended attribute definition
            var project = new Project();

            var attribute = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Cost, ExtendedAttributeTask.Cost1, string.Empty);
            attribute.Formula  = "[Cost]-[Actual Cost]";
           
            project.ExtendedAttributes.Add(attribute);
            
            // Add task
            var task = project.RootTask.Children.Add("Task");
            
            // Create extended attribute
            var extendedAttribute = attribute.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(extendedAttribute);

            // Display if extended attributes are read only or not
            Console.WriteLine(extendedAttribute.ValueReadOnly ? "Value is Read only" : "Value is not read only");
            extendedAttribute.NumericValue = -1000000M;
            Console.WriteLine(extendedAttribute.NumericValue == -1000000M ? "Formula values are read-only" : "Values are not read-only");
            //ExEnd:AccessReadOnlyCustomFieldValuesUsingFormulas
        }
    }
}