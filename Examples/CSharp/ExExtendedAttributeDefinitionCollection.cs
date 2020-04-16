namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExExtendedAttributeDefinitionCollection : ApiExampleBase
    {
        [Test]
        public void WorkWithExtendedAttributeDefinitionCollection()
        {
            //ExStart
            //ExFor: ExtendedAttributeDefinitionCollection
            //ExFor: ExtendedAttributeDefinitionCollection.Add(ExtendedAttributeDefinition)
            //ExFor: ExtendedAttributeDefinitionCollection.Clear
            //ExFor: ExtendedAttributeDefinitionCollection.Contains(ExtendedAttributeDefinition)
            //ExFor: ExtendedAttributeDefinitionCollection.CopyTo(ExtendedAttributeDefinition[],Int32)
            //ExFor: ExtendedAttributeDefinitionCollection.Count
            //ExFor: ExtendedAttributeDefinitionCollection.GetById(Int32)
            //ExFor: ExtendedAttributeDefinitionCollection.GetEnumerator
            //ExFor: ExtendedAttributeDefinitionCollection.IndexOf(ExtendedAttributeDefinition)
            //ExFor: ExtendedAttributeDefinitionCollection.Insert(Int32,ExtendedAttributeDefinition)
            //ExFor: ExtendedAttributeDefinitionCollection.IsReadOnly
            //ExFor: ExtendedAttributeDefinitionCollection.Item(Int32)
            //ExFor: ExtendedAttributeDefinitionCollection.ParentProject
            //ExFor: ExtendedAttributeDefinitionCollection.Remove(ExtendedAttributeDefinition)
            //ExFor: ExtendedAttributeDefinitionCollection.RemoveAt(Int32)
            //ExFor: ExtendedAttributeDefinitionCollection.ToList
            //ExSummary: Shows how to use extended attribute definition collections.
            var project = new Project(DataDir + "ReadTaskExtendedAttributes.mpp");

            if (!project.ExtendedAttributes.IsReadOnly)
            {
                if (project.ExtendedAttributes.Count > 0)
                {
                    // clear extended attribute definitions
                    project.ExtendedAttributes.Clear();
                }
            }
            
            // create extended attribute definition for a task
            var taskDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(
                CustomFieldType.Start, 
                ExtendedAttributeTask.Start7, 
                "Start 7");
            project.ExtendedAttributes.Add(taskDefinition);

            Console.WriteLine("Iterate over extended attributes of " + project.ExtendedAttributes.ParentProject.Get(Prj.Name) + " project: ");
            foreach (var attribute in project.ExtendedAttributes)
            {
                Console.WriteLine("Attribute Alias: " + attribute.Alias);
                Console.WriteLine("Attribute CfType: " + attribute.CfType);
                Console.WriteLine();
            }

            Console.WriteLine();
            
            // work with extended attribute definitions...

            var resourceDefinition = ExtendedAttributeDefinition.CreateResourceDefinition(
                CustomFieldType.Cost,
                ExtendedAttributeResource.Cost5,
                "My cost");

            if (!project.ExtendedAttributes.Contains(resourceDefinition))
            {
                project.ExtendedAttributes.Add(resourceDefinition);
            }
            
            // work with extended attribute definitions...
            
            var resourceDefinition2 = ExtendedAttributeDefinition.CreateResourceDefinition(
                CustomFieldType.Number,
                ExtendedAttributeResource.Cost1,
                "My Cost 2");

            if (project.ExtendedAttributes.IndexOf(resourceDefinition2) < 0)
            {
                project.ExtendedAttributes.Insert(0, resourceDefinition2);
            }
            
            // work with extended attribute definitions...
            
            // remove extended attribute by index
            project.ExtendedAttributes.RemoveAt(0);
            
            Assert.AreEqual(2, project.ExtendedAttributes.Count); //ExSkip
            
            Console.WriteLine("Print project's extended attributes: ");
            Console.WriteLine("Count of project's extended attribute definitions: " + project.ExtendedAttributes.Count);
            // use collection index access
            Console.WriteLine("Attribute 1 Alias: " + project.ExtendedAttributes[0].Alias);
            Console.WriteLine("Attribute 1 CfType: " + project.ExtendedAttributes[0].CfType);
            Console.WriteLine("Attribute 2 Alias: " + project.ExtendedAttributes[1].Alias);
            Console.WriteLine("Attribute 2 CfType: " + project.ExtendedAttributes[1].CfType);
            
            var otherProject = new Project();

            // copy attributes to other project
            var attributes = new ExtendedAttributeDefinition[project.ExtendedAttributes.Count];
            project.ExtendedAttributes.CopyTo(attributes, 0);

            foreach (var attribute in attributes)
            {
                otherProject.ExtendedAttributes.Add(attribute);
            }

            Console.WriteLine();
            Console.WriteLine("Iterate over other project's extended attributes: ");
            foreach (var attribute in otherProject.ExtendedAttributes)
            {
                Console.WriteLine("Attribute Alias: " + attribute.Alias);
                Console.WriteLine("Attribute CfType: " + attribute.CfType);
                Console.WriteLine();
            }
            
            // remove all extended attribute definitions
            List<ExtendedAttributeDefinition> definitions = project.ExtendedAttributes.ToList();
            foreach (var definition in definitions)
            {
                project.ExtendedAttributes.Remove(definition);
            }
            //ExEnd
        }
    }
}