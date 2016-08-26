using System;

namespace Aspose.Tasks.Examples.CSharp.ModifyingCreatedProject
{
    public class ReadOnlyAccessToCustomFieldValuesUsingFormulas
    {
        public static void Run()
        {
            // ExStart:ReadOnlyAccessToCustomFieldValuesUsingFormulas
            Project project = new Project();
            ExtendedAttributeDefinition attribute = new ExtendedAttributeDefinition
            {
                FieldId = ((int) ExtendedAttributeTask.Text1).ToString(),
                Formula = "[Cost]-[Actual Cost]"
            };
            project.ExtendedAttributes.Add(attribute);
            Task task = project.RootTask.Children.Add("Task");
            ExtendedAttribute extendedAttribute = attribute.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(extendedAttribute);
            Console.WriteLine(extendedAttribute.ValueReadOnly == true ? "Value is Read only" : "Value is not read only");
            extendedAttribute.Value = "Invalid";
            Console.WriteLine(extendedAttribute.Value == string.Empty ? "Formula values are read-only" : "Values are not read-only");
            // ExEnd:ReadOnlyAccessToCustomFieldValuesUsingFormulas
        }
    }
}