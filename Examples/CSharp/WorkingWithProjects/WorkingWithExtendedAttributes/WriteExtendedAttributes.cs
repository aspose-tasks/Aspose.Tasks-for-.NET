using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithExtendedAttributes
{
    public class WriteExtendedAttributes
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:ExtendedAttributes
            Project project = new Project(dataDir + "ExtendedAttributes.mpp");

            // Create extended attribute definition
            ExtendedAttributeDefinition attributeDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Start, ExtendedAttributeTask.Start7, "Start 7");
            project.ExtendedAttributes.Add(attributeDefinition);

            // Get zero index task
            Task task = project.RootTask.Children.GetById(1);

            // Add extended attribute
            ExtendedAttribute attribute = attributeDefinition.CreateExtendedAttribute();
            attribute.DateValue = DateTime.Now;

            // Also the following short syntax can be used: ExtendedAttribute attribute = attributeDefinition.CreateExtendedAttribute(DateTime.Now);
            task.ExtendedAttributes.Add(attribute);
            //ExEnd:ExtendedAttributes
        }
    }
}