namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExOutlineCodeDefinitionCollection : ApiExampleBase
    {
        [Test]
        public void WorkWithOutlineCodeDefinitionCollection()
        {
            // ExStart
            // ExFor: OutlineCodeDefinitionCollection
            // ExFor: OutlineCodeDefinitionCollection.Add(OutlineCodeDefinition)
            // ExFor: OutlineCodeDefinitionCollection.Clear
            // ExFor: OutlineCodeDefinitionCollection.Contains(OutlineCodeDefinition)
            // ExFor: OutlineCodeDefinitionCollection.CopyTo(OutlineCodeDefinition[],Int32)
            // ExFor: OutlineCodeDefinitionCollection.Count
            // ExFor: OutlineCodeDefinitionCollection.GetEnumerator
            // ExFor: OutlineCodeDefinitionCollection.IndexOf(OutlineCodeDefinition)
            // ExFor: OutlineCodeDefinitionCollection.Insert(Int32,OutlineCodeDefinition)
            // ExFor: OutlineCodeDefinitionCollection.IsReadOnly
            // ExFor: OutlineCodeDefinitionCollection.Item(Int32)
            // ExFor: OutlineCodeDefinitionCollection.Remove(OutlineCodeDefinition)
            // ExFor: OutlineCodeDefinitionCollection.RemoveAt(Int32)
            // ExFor: OutlineCodeDefinitionCollection.ToList
            // ExSummary: Shows how to work with outline code definition collections.
            var project = new Project(DataDir + "OutlineCodes.mpp");

            Console.WriteLine("Count of outline code definitions: " + project.OutlineCodes.Count);
            foreach (var outlineCode in project.OutlineCodes)
            {
                Console.WriteLine("Field Name: " + outlineCode.FieldName);
                Console.WriteLine("Alias: " + outlineCode.Alias);
                Console.WriteLine();
            }

            // add a custom outline code definition
            var outlineCodeDefinition = new OutlineCodeDefinition { FieldId = ((int)ExtendedAttributeTask.OutlineCode3).ToString("D"), Alias = "My Outline Code" };

            var outlineCodeDefinition2 = new OutlineCodeDefinition { FieldId = ((int)ExtendedAttributeTask.OutlineCode1).ToString("D"), Alias = "My Outline Code 2" };

            if (!project.OutlineCodes.IsReadOnly)
            {
                project.OutlineCodes.Add(outlineCodeDefinition);

                // insert outline code definition in position
                project.OutlineCodes.Insert(0, outlineCodeDefinition2);
            }

            // find the index of the outline code definition
            var index = project.OutlineCodes.IndexOf(outlineCodeDefinition);

            // edit the outline code definition
            project.OutlineCodes[index].Alias = "New Alias";

            // ...
            // work with outline code definitions
            // ...

            // remove the outline code definition
            if (project.OutlineCodes.Contains(outlineCodeDefinition))
            {
                project.OutlineCodes.Remove(outlineCodeDefinition);
            }

            // remove an outline code definition by index
            project.OutlineCodes.RemoveAt(0);

            var otherProject = new Project(DataDir + "Blank2010.mpp");

            // remove outline code definitions
            otherProject.OutlineCodes.Clear();

            // copy outline code definitions
            var outlineCodeDefinitions = new OutlineCodeDefinition[project.OutlineCodes.Count];
            project.OutlineCodes.CopyTo(outlineCodeDefinitions, 0);

            foreach (var definition in outlineCodeDefinitions)
            {
                otherProject.OutlineCodes.Add(definition);
            }

            // ...
            // work with outline code definitions
            // ...

            // remove outline code definitions one by one
            List<OutlineCodeDefinition> definitions = otherProject.OutlineCodes.ToList();
            foreach (var definition in definitions)
            {
                otherProject.OutlineCodes.Remove(definition);
            }

            // ExEnd
        }
    }
}