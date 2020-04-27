namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExOutlineCode : ApiExampleBase
    {
        [Test]
        public void WorkWithOutlineCode()
        {
            // ExStart
            // ExFor: OutlineCode
            // ExFor: OutlineCode.FieldId
            // ExFor: OutlineCode.ValueId
            // ExFor: OutlineCode.ValueGuid
            // ExSummary: Shows how to read task's outline codes.
            var project = new Project(DataDir + "OutlineValues2010.mpp");

            // read outline codes
            foreach (var task in project.RootTask.SelectAllChildTasks())
            {
                if (task.OutlineCodes.Count <= 0)
                {
                    continue;
                }

                Console.WriteLine("Print outline codes of the task: " + task.Get(Tsk.Name));
                foreach (var value in task.OutlineCodes)
                {
                    Console.WriteLine("  Field Id: " + value.FieldId);
                    Console.WriteLine("  Value Guid: " + value.ValueGuid);
                    Console.WriteLine("  Value Id: " + value.ValueId);
                }
            }

            // ExEnd
        }
    }
}