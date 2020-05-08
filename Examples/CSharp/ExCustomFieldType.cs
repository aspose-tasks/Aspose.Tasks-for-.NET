namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;

    [TestFixture]
    public class ExCustomFieldType : ApiExampleBase
    {
        [Test]
        public void WorkWithCustomFieldType()
        {
            // ExStart
            // ExFor: CustomFieldType
            // ExSummary: Shows how to use <see cref="CustomFieldType" /> (CustomFieldType.Text).
            var project = new Project(DataDir + "Project2.mpp");
            var definition = ExtendedAttributeDefinition.CreateTaskDefinition(
                CustomFieldType.Text,
                ExtendedAttributeTask.Text1,
                "MyText");
            project.ExtendedAttributes.Add(definition);
            // work with definitions...
            // ExEnd
        }
    }
}