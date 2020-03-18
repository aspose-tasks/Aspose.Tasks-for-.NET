namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithExtendedAttributes
{
    using System;

    public class WriteExtendedAttributes
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:ExtendedAttributes
            var project = new Project(dataDir + "ExtendedAttributes.mpp");

            // Create extended attribute definition
            var attributeDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Start, ExtendedAttributeTask.Start7, "Start 7");
            project.ExtendedAttributes.Add(attributeDefinition);

            // Get zero index task
            var task = project.RootTask.Children.GetById(1);

            // Add extended attribute
            var attribute = attributeDefinition.CreateExtendedAttribute();
            attribute.DateValue = DateTime.Now;

            // Also the following short syntax can be used: ExtendedAttribute attribute = attributeDefinition.CreateExtendedAttribute(DateTime.Now);
            task.ExtendedAttributes.Add(attribute);
            //ExEnd:ExtendedAttributes
        }
    }
}