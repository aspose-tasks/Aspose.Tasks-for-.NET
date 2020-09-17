namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using NUnit.Framework;

    [TestFixture]
    public class ExExtendedAttribute : ApiExampleBase
    {
        [Test]
        [SuppressMessage("ReSharper", "RedundantToStringCall", Justification = "Reviewed. Suppression is OK here.")]
        public void ReadExtendedAttributes()
        {
            // ExStart
            // ExFor: ExtendedAttribute.ToString
            // ExSummary: Shows how to read extended attributes. 
            var project = new Project(DataDir + "ReadTaskExtendedAttributes.mpp");

            // Read extended attributes for tasks
            foreach (var task in project.RootTask.Children)
            {
                foreach (var attribute in task.ExtendedAttributes)
                {
                    // read common info about extended attribute
                    Console.WriteLine("Extended Attribute: " + attribute.ToString());
                }
            }

            // ExEnd
        }

        [Test]
        public void CreateExtendedAttribute()
        {
            // ExStart:AccessReadOnlyCustomFieldValuesUsingFormulas
            // ExFor: ExtendedAttribute
            // ExFor: ExtendedAttribute.ValueReadOnly
            // ExFor: ExtendedAttribute.NumericValue
            // ExSummary: Shows how to add read-only custom field values by using formulas.
            var project = new Project();

            // create new task extended attribute definition
            var attribute = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Cost, ExtendedAttributeTask.Cost1, string.Empty);

            // Add a formula to the attribute.
            attribute.Formula = "[Cost]-[Actual Cost]";

            project.ExtendedAttributes.Add(attribute);

            var task = project.RootTask.Children.Add("Task");

            // Create extended attribute
            var extendedAttribute = attribute.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(extendedAttribute);

            // Display if extended attributes are read only or not
            Console.WriteLine(extendedAttribute.ValueReadOnly ? "Value is Read only" : "Value is not read only");
            extendedAttribute.NumericValue = -1000000M;
            Console.WriteLine(extendedAttribute.NumericValue != -1000000M ? "Formula values are read-only" : "Values are not read-only");

            // ExEnd:AccessReadOnlyCustomFieldValuesUsingFormulas
        }

        [Test]
        public void ChangeDefinitionOfExtendedAttribute()
        {
            // ExStart:ChangeExtendedAttributeDefinition
            // ExFor: ExtendedAttribute.AttributeDefinition
            // ExFor: ExtendedAttribute.DateValue
            // ExFor: ExtendedAttribute.FieldId
            // ExSummary: Shows how to change attribute definition of the extended attribute.
            var project = new Project();

            // create new task extended attribute definition
            var definition = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Cost, ExtendedAttributeTask.Cost1, string.Empty);

            // add a formula to the attribute.
            definition.Alias = "Difference between Cost and Actual Cost";
            definition.Formula = "[Cost]-[Actual Cost]";

            project.ExtendedAttributes.Add(definition);

            var task = project.RootTask.Children.Add("Task");
            task.Set(Tsk.Start, new DateTime(2020, 4, 21, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));
            task.Set(Tsk.Finish, new DateTime(2020, 4, 21, 17, 0, 0));
            task.Set(Tsk.Deadline, new DateTime(2020, 4, 22, 17, 0, 0));
            task.Set(Tsk.Cost, 20);
            task.Set(Tsk.ActualCost, 13);

            // create extended attribute
            var extendedAttribute = definition.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(extendedAttribute);

            Console.WriteLine("Before change:");
            Console.WriteLine("Alias: " + definition.Alias);
            Console.WriteLine("Field Id: " + extendedAttribute.FieldId);
            Console.WriteLine("Value: " + extendedAttribute.NumericValue);

            var oldFieldId = extendedAttribute.FieldId; // ExSkip

            // create a new date extended attribute definition
            var newDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Date, ExtendedAttributeTask.Date1, string.Empty);

            // add a formula to the attribute.
            newDefinition.Alias = "Days from finish to deadline";
            newDefinition.Formula = "[Deadline] - [Finish]";
            project.ExtendedAttributes.Add(newDefinition);

            extendedAttribute.AttributeDefinition = newDefinition;

            Console.WriteLine();
            Console.WriteLine("After change:");
            Console.WriteLine("Alias: " + definition.Alias);
            Console.WriteLine("Field Id: " + extendedAttribute.FieldId);
            Console.WriteLine("Value: " + extendedAttribute.DateValue.Day);

            // ExEnd:ChangeExtendedAttributeDefinition
        }

        [Test]
        public void CreateExtendedAttributeValueGuid()
        {
            // ExStart
            // ExFor: ExtendedAttribute.ValueGuid
            // ExSummary: Shows how to work with an extended attribute GUID.
            var project = new Project();
            var definition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(CustomFieldType.Cost, ExtendedAttributeTask.Cost1, "My lookup cost");
            var finished = project.RootTask.Children.Add("Task");
            finished.Set(Tsk.Start, new DateTime(2020, 4, 21, 8, 0, 0));
            finished.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));
            finished.Set(Tsk.Finish, new DateTime(2020, 4, 21, 17, 0, 0));

            var value1 = new Value { NumericValue = 10000, Description = "Val 1", Id = 1 };
            var value2 = new Value { NumericValue = 25000, Description = "Val 2", Id = 2 };

            definition.AddLookupValue(value1);
            definition.AddLookupValue(value2);

            var attribute = definition.CreateExtendedAttribute(value1);

            // extended attribute has a GUID which is 
            // equal to GUID of bind 'Value' from the lookup
            Console.WriteLine("Extended attribute GUID: " + attribute.ValueGuid);
            Console.WriteLine("GUID of the first value in the lookup: " + value1.ValueGuid.ToString().ToUpper());
            var guidFromString = Guid.Parse(attribute.ValueGuid);
            Console.WriteLine("Are these GUIDs equal: " + guidFromString.Equals(value1.ValueGuid));

            // ExEnd
            Assert.IsTrue(guidFromString.Equals(value1.ValueGuid));
        }

        [Test]
        public void CreateFlagExtendedAttribute()
        {
            // ExStart:CreateFlagExtendedAttribute
            // ExFor: ExtendedAttribute.FlagValue
            // ExSummary: Shows how to create boolean extended attribute.
            var project = new Project();

            // create new task extended attribute definition
            var definition = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Flag, ExtendedAttributeTask.Flag1, "Is Finished");

            // add a formula to the attribute.
            definition.Formula = "[% Complete] = 100";

            project.ExtendedAttributes.Add(definition);

            var finished = project.RootTask.Children.Add("Task");
            finished.Set(Tsk.Start, new DateTime(2020, 4, 21, 8, 0, 0));
            finished.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));
            finished.Set(Tsk.Finish, new DateTime(2020, 4, 21, 17, 0, 0));
            finished.Set(Tsk.ActualStart, new DateTime(2020, 4, 21, 8, 0, 0));
            finished.Set(Tsk.ActualDuration, project.GetDuration(1, TimeUnitType.Day));
            finished.Set(Tsk.ActualFinish, new DateTime(2020, 4, 21, 17, 0, 0));
            finished.Set(Tsk.PercentComplete, 100);

            var running = project.RootTask.Children.Add("Task");
            running.Set(Tsk.Start, new DateTime(2020, 4, 21, 8, 0, 0));
            running.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));
            running.Set(Tsk.Finish, new DateTime(2020, 4, 21, 17, 0, 0));
            running.Set(Tsk.ActualStart, new DateTime(2020, 4, 21, 8, 0, 0));

            Console.WriteLine(running.Get(Tsk.PercentComplete));
            // create extended attribute
            var runningFlagAttribute = definition.CreateExtendedAttribute();
            var finishedFlagAttribute = definition.CreateExtendedAttribute();
            running.ExtendedAttributes.Add(runningFlagAttribute);
            finished.ExtendedAttributes.Add(finishedFlagAttribute);

            Console.WriteLine("Alias: {0}\n", definition.Alias);
            Console.WriteLine("(Finished Task) Field Id: " + finishedFlagAttribute.FieldId);
            Console.WriteLine("(Finished Task) Value: {0}\n", finishedFlagAttribute.FlagValue);
            Console.WriteLine("(Running Task) Field Id: " + runningFlagAttribute.FieldId);
            Console.WriteLine("(Running Task) Value: " + runningFlagAttribute.FlagValue);

            // ExEnd:CreateFlagExtendedAttribute
            Assert.IsTrue(finishedFlagAttribute.FlagValue);
            Assert.IsFalse(runningFlagAttribute.FlagValue);
        }

        [Test]
        public void CalculateDateTimeFunctions()
        {
            // ExStart:CalculateDateTimeFunctions
            // ExFor: ExtendedAttribute.TextValue
            // ExFor: ExtendedAttribute.DurationValue
            // ExSummary: Shows how to add extended attributes that uses MS Project date/time formulas.
            var project = new Project();
            var task = project.RootTask.Children.Add("Task");

            var numberDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Number1, null);
            project.ExtendedAttributes.Add(numberDefinition);

            var numberAttribute = numberDefinition.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(numberAttribute);

            // Set ProjDateDiff formula and print extended attribute value
            numberDefinition.Formula = "ProjDateDiff(\"03/23/2015\",\"03/18/2015\")";
            Console.WriteLine(numberAttribute.NumericValue);
            numberDefinition.Formula = "ProjDateDiff(\"03/23/2015\",\"03/25/2015\")";
            Console.WriteLine(numberAttribute.NumericValue);

            var dateDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Date1, null);
            project.ExtendedAttributes.Add(dateDefinition);
            var dateAttribute = dateDefinition.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(dateAttribute);

            var durationDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Duration4, "Custom duration field");
            project.ExtendedAttributes.Add(durationDefinition);
            var durationAttribute = durationDefinition.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(durationAttribute);

            var textDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Text5, "Custom text field");
            project.ExtendedAttributes.Add(textDefinition);
            var textAttribute = textDefinition.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(textAttribute);

            // Set ProjDateSub formula and print extended attribute value
            dateDefinition.Formula = "ProjDateSub(\"3/19/2015\", \"1d\")";
            Console.WriteLine(dateAttribute.DateValue);

            // We can set ProjDurConv formula to duration-valued attribute as well as to text-valued attribute.
            // Set ProjDurConv formula to duration-valued extended attribute and print its value.
            durationDefinition.Formula = "ProjDurConv([Duration], pjHours)";
            Console.WriteLine(durationAttribute.DurationValue);

            // Set ProjDurConv formula to text-valued extended attribute and print its value.
            textDefinition.Formula = "ProjDurConv([Duration], pjWeeks)";
            Console.WriteLine(textAttribute.TextValue);

            // Set Second formula and print extended attribute value
            numberDefinition.Formula = "Second(\"4/21/2015 2:53:41 AM\")";
            Console.WriteLine(numberAttribute.NumericValue);

            // Set Weekday formula and print extended attribute value
            numberDefinition.Formula = "Weekday(\"24/3/2015\", 1)";
            Console.WriteLine(numberAttribute.NumericValue);
            numberDefinition.Formula = "Weekday(\"24/3/2015\", 2)";
            Console.WriteLine(numberAttribute.NumericValue);
            numberDefinition.Formula = "Weekday(\"24/3/2015\", 3)";
            Console.WriteLine(numberAttribute.NumericValue);

            // ExEnd:CalculateDateTimeFunctions
        }
    }
}