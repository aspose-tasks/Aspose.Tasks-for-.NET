namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithExtendedAttributes
{
    using System;
    using Saving;

    internal class WriteExtendedAttributes
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:ExtendedAttributes
            //ExFor: ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType,ExtendedAttributeTask,String)
            //ExFor: Task.ExtendedAttributes
            //ExSummary: Shows how to write extended attributes.
            var project = new Project(dataDir + "ExtendedAttributes.mpp");

            // Create extended attribute definition
            var definition = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Start, ExtendedAttributeTask.Start7, "Start 7");
            project.ExtendedAttributes.Add(definition);

            // Get zero index task
            var task = project.RootTask.Children.GetById(1);

            // Add extended attribute
            var attribute = definition.CreateExtendedAttribute();
            attribute.DateValue = DateTime.Now;

            // Also the following short syntax can be used: ExtendedAttribute attribute = attributeDefinition.CreateExtendedAttribute(DateTime.Now);
            task.ExtendedAttributes.Add(attribute);
            project.Save(dataDir + "WriteExtendedAttributes_out.mpp", SaveFileFormat.MPP);
            //ExEnd:ExtendedAttributes
        }
    }
}