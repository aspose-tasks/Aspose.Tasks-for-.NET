namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Util;

    [TestFixture]
    public class ExOutlineCodeCollection : ApiExampleBase
    {
        [Test]
        public void WorkWithOutlineCodeCollection()
        {
            // ExStart
            // ExFor: OutlineCodeCollection
            // ExFor: OutlineCodeCollection.Add(OutlineCode)
            // ExFor: OutlineCodeCollection.Clear
            // ExFor: OutlineCodeCollection.Contains(OutlineCode)
            // ExFor: OutlineCodeCollection.CopyTo(OutlineCode[],Int32)
            // ExFor: OutlineCodeCollection.Count
            // ExFor: OutlineCodeCollection.GetEnumerator
            // ExFor: OutlineCodeCollection.IndexOf(OutlineCode)
            // ExFor: OutlineCodeCollection.Insert(Int32,OutlineCode)
            // ExFor: OutlineCodeCollection.IsReadOnly
            // ExFor: OutlineCodeCollection.Item(Int32)
            // ExFor: OutlineCodeCollection.Remove(OutlineCode)
            // ExFor: OutlineCodeCollection.RemoveAt(Int32)
            // ExSummary: Shows how to work with outline code collections.
            var project = new Project(DataDir + "OutlineCodes2003.mpp");

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);

            for (var i = 0; i < collector.Tasks.Count; i++)
            {
                var current = collector.Tasks[i];
                if (current.Get(Tsk.Id) == 0)
                {
                    continue;
                }

                Console.WriteLine("Print outline codes for the " + current.Get(Tsk.Name) + " task.");
                Console.WriteLine("Count of outline codes: " + current.OutlineCodes.Count);
                foreach (var outlineCode in current.OutlineCodes)
                {
                    Console.WriteLine("Field Id: " + outlineCode.FieldId);
                    Console.WriteLine("Value Id: " + outlineCode.ValueId);
                    Console.WriteLine("Value Guid: " + outlineCode.ValueGuid);
                    Console.WriteLine();
                }
            }

            // add a custom outline code definition
            var outlineCodeDefinition = new OutlineCodeDefinition { FieldId = ((int)ExtendedAttributeTask.OutlineCode3).ToString("D"), Alias = "My Outline Code" };
            project.OutlineCodes.Add(outlineCodeDefinition);

            // create outline code
            var value = new OutlineValue { Type = OutlineValueType.Text, Value = "Val1", Description = "Descr1", ValueId = 1 };
            outlineCodeDefinition.Values.Add(value);

            var codeOne = new OutlineCode { FieldId = outlineCodeDefinition.FieldId, ValueId = 1, ValueGuid = value.ValueGuid.ToString("D").ToUpperInvariant() };

            var task = project.RootTask.Children.GetByUid(2);

            // one can check that collection is not read only
            if (!task.OutlineCodes.IsReadOnly)
            {
                task.OutlineCodes.Add(codeOne);
            }

            var codeZero = new OutlineCode { FieldId = outlineCodeDefinition.FieldId, ValueId = 0, ValueGuid = value.ValueGuid.ToString("D").ToUpperInvariant() };

            task.OutlineCodes.Insert(0, codeZero);

            var code2 = new OutlineCode { FieldId = outlineCodeDefinition.FieldId, ValueId = 2, ValueGuid = value.ValueGuid.ToString("D").ToUpperInvariant() };

            // insert code with 2 in a wrong position
            task.OutlineCodes.Insert(0, code2);

            // fix it
            var indexOf = task.OutlineCodes.IndexOf(code2);
            task.OutlineCodes.RemoveAt(indexOf);

            // insert code with 2 in a right position
            task.OutlineCodes.Insert(2, code2);

            // check that the code was inserted
            Console.WriteLine("Is outline codes contains the inserted value: " + task.OutlineCodes.Contains(code2));

            // ...
            // work with outline codes
            // ...
            var otherProject = new Project(DataDir + "OutlineCodes2003.mpp");
            var otherTask = otherProject.RootTask.Children.GetById(2);

            // add a custom outline code definition
            outlineCodeDefinition = new OutlineCodeDefinition { FieldId = ((int)ExtendedAttributeTask.OutlineCode3).ToString("D"), Alias = "My Outline Code" };
            otherProject.OutlineCodes.Add(outlineCodeDefinition);

            // create outline code
            var otherValue = new OutlineValue { Type = OutlineValueType.Text, Value = "Val1", Description = "Descr1", ValueId = 1 };
            outlineCodeDefinition.Values.Add(otherValue);

            var outlineCodes = new OutlineCode[task.OutlineCodes.Count];
            task.OutlineCodes.CopyTo(outlineCodes, 0);

            foreach (var code in outlineCodes)
            {
                otherTask.OutlineCodes.Add(code);
            }

            // ...
            // work with outline codes
            // ...

            // remove outline code
            otherTask.OutlineCodes.RemoveAt(0);

            while (otherTask.OutlineCodes.Count > 0)
            {
                otherTask.OutlineCodes.Remove(otherTask.OutlineCodes[0]);
            }

            // clear all values at once
            task.OutlineCodes.Clear();

            // ExEnd
        }
    }
}