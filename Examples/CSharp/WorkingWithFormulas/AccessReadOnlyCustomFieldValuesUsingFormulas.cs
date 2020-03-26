namespace Aspose.Tasks.Examples.CSharp.WorkingWithFormulas
{
    using System;

    internal class AccessReadOnlyCustomFieldValuesUsingFormulas
    {
        public static void Run()
        {
            //ExStart:AccessReadOnlyCustomFieldValuesUsingFormulas
            //ExFor: ExtendedAttributeDefinition.Formula
            //ExFor: ExtendedAttribute.ValueReadOnly
            //ExSummary: Shows how to add read-only custom field values by using formulas.
            // Create new project and extended attribute definition
            var project = new Project();

            // create new task extended attribute definition.
            var attribute = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Cost, ExtendedAttributeTask.Cost1, string.Empty);
            
            // add a formula to the attribute.
            attribute.Formula  = "[Cost]-[Actual Cost]";
           
            project.ExtendedAttributes.Add(attribute);
            
            var task = project.RootTask.Children.Add("Task");
            
            // Create extended attribute
            var extendedAttribute = attribute.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(extendedAttribute);

            // Display if extended attributes are read only or not
            Console.WriteLine(extendedAttribute.ValueReadOnly ? "Value is Read only" : "Value is not read only");
            extendedAttribute.NumericValue = -1000000M;
            Console.WriteLine(extendedAttribute.NumericValue != -1000000M ? "Formula values are read-only" : "Values are not read-only");
            //ExEnd:AccessReadOnlyCustomFieldValuesUsingFormulas
        }
    }
}