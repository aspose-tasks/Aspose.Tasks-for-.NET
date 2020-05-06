namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;

    [TestFixture]
    public class ExCustomFieldType : ApiExampleBase
    {
        [Test]
        public void WorkWithCustomFieldType()
        {
            {
                // ExStart
                // ExFor: CustomFieldType
                // ExFor: CustomFieldType.Text
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
            
            {
                // ExStart
                // ExFor: CustomFieldType.Cost
                // ExSummary: Shows how to use <see cref="CustomFieldType" /> (CustomFieldType.Cost).
                var project = new Project(DataDir + "Project2.mpp");
                var definition = ExtendedAttributeDefinition.CreateTaskDefinition(
                    CustomFieldType.Cost, 
                    ExtendedAttributeTask.Cost1, 
                    "MyCost");
                project.ExtendedAttributes.Add(definition);
                // work with definitions...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: CustomFieldType.Date
                // ExSummary: Shows how to use <see cref="CustomFieldType" /> (CustomFieldType.Date).
                var project = new Project(DataDir + "Project2.mpp");
                var definition = ExtendedAttributeDefinition.CreateTaskDefinition(
                    CustomFieldType.Date, 
                    ExtendedAttributeTask.Date1, 
                    "MyDate");
                project.ExtendedAttributes.Add(definition);
                // work with definitions...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: CustomFieldType.Duration
                // ExSummary: Shows how to use <see cref="CustomFieldType" /> (CustomFieldType.Duration).
                var project = new Project(DataDir + "Project2.mpp");
                var definition = ExtendedAttributeDefinition.CreateTaskDefinition(
                    CustomFieldType.Duration, 
                    ExtendedAttributeTask.Duration1, 
                    "MyDuration");
                project.ExtendedAttributes.Add(definition);
                // work with definitions...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: CustomFieldType.Start
                // ExSummary: Shows how to use <see cref="CustomFieldType" /> (CustomFieldType.Start).
                var project = new Project(DataDir + "Project2.mpp");
                var definition = ExtendedAttributeDefinition.CreateTaskDefinition(
                    CustomFieldType.Start, 
                    ExtendedAttributeTask.Start1, 
                    "MyStart");
                project.ExtendedAttributes.Add(definition);
                // work with definitions...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: CustomFieldType.Finish
                // ExSummary: Shows how to use <see cref="CustomFieldType" /> (CustomFieldType.Finish).
                var project = new Project(DataDir + "Project2.mpp");
                var definition = ExtendedAttributeDefinition.CreateTaskDefinition(
                    CustomFieldType.Finish, 
                    ExtendedAttributeTask.Finish1, 
                    "MyFinish");
                project.ExtendedAttributes.Add(definition);
                // work with definitions...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: CustomFieldType.Flag
                // ExSummary: Shows how to use <see cref="CustomFieldType" /> (CustomFieldType.Flag).
                var project = new Project(DataDir + "Project2.mpp");
                var definition = ExtendedAttributeDefinition.CreateTaskDefinition(
                    CustomFieldType.Flag, 
                    ExtendedAttributeTask.Flag1, 
                    "MyFlag");
                project.ExtendedAttributes.Add(definition);
                // work with definitions...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: CustomFieldType.Number
                // ExSummary: Shows how to use <see cref="CustomFieldType" /> (CustomFieldType.Number).
                var project = new Project(DataDir + "Project2.mpp");
                var definition = ExtendedAttributeDefinition.CreateTaskDefinition(
                    CustomFieldType.Number, 
                    ExtendedAttributeTask.Number1, 
                    "MyNumber");
                project.ExtendedAttributes.Add(definition);
                // work with definitions...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: CustomFieldType.OutlineCode
                // ExSummary: Shows how to use <see cref="CustomFieldType" /> (CustomFieldType.OutlineCode).
                var project = new Project(DataDir + "Project2.mpp");
                var definition = ExtendedAttributeDefinition.CreateTaskDefinition(
                    CustomFieldType.OutlineCode, 
                    ExtendedAttributeTask.OutlineCode1, 
                    "MyOutlineCode");
                project.ExtendedAttributes.Add(definition);
                // work with definitions...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: CustomFieldType.RBS
                // ExSummary: Shows how to use <see cref="CustomFieldType" /> (CustomFieldType.RBS).
                var project = new Project(DataDir + "Project2.mpp");
                // CustomFieldType.RBS is not supported
                /*
                 var definition = ExtendedAttributeDefinition.CreateTaskDefinition(
                     CustomFieldType.RBS, 
                     ExtendedAttributeTask.RBS, 
                     "MyRBS");
                 project.ExtendedAttributes.Add(definition);
                */
                // work with definitions...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: CustomFieldType.Null
                // ExSummary: Shows how to use <see cref="CustomFieldType" /> (CustomFieldType.Null).
                var project = new Project(DataDir + "Project2.mpp");
                // CustomFieldType.Null is not supported
                /*
                 var definition = ExtendedAttributeDefinition.CreateTaskDefinition(
                     CustomFieldType.Null, 
                     ExtendedAttributeTask.Null, 
                     "MyNull");
                 project.ExtendedAttributes.Add(definition);
                */
                // work with definitions...
                // ExEnd
            }
        }
    }
}