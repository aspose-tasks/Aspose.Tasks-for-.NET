
using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithFormulas
{
    public class AccessReadOnlyCustomFieldValuesUsingFormulas
    {
        public static void Run()
        {
            // ExStart:AccessReadOnlyCustomFieldValuesUsingFormulas
            // Create new project and extended attribute definition
            Project project = new Project();

            ExtendedAttributeDefinition attribute = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Cost, ExtendedAttributeTask.Cost1, "");
            attribute.Formula  = "[Cost]-[Actual Cost]";
           
            project.ExtendedAttributes.Add(attribute);
            
            // Add task
            Task task = project.RootTask.Children.Add("Task");
            
            // Create extended attribute
            ExtendedAttribute extendedAttribute = attribute.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(extendedAttribute);

            // Display if extended attributes are read only or not
            Console.WriteLine(extendedAttribute.ValueReadOnly == true ? "Value is Read only" : "Value is not read only");
            extendedAttribute.NumericValue = -1000000M;
            Console.WriteLine(extendedAttribute.NumericValue == -1000000M ? "Formula values are read-only" : "Values are not read-only");
            // ExEnd:AccessReadOnlyCustomFieldValuesUsingFormulas
        }
    }
}