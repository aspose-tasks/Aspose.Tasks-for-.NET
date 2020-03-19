namespace Aspose.Tasks.Examples.CSharp.WorkingWithFormulas
{
    using System;

    internal class CalculateDateTimeFunctions
    {
        public static void Run()
        {
            //ExStart:CalculateDateTimeFunctions
            //ExFor: ExtendedAttributeDefinition.Formula
            //ExFor: ExtendedAttribute.DurationValue
            //ExFor: ExtendedAttribute.TextValue
            //ExSummary: Shows how to add extended attributes that uses MS Project date/time formulas.
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
            textDefinition.Formula = "ProjDurConv([Duration], pjHours)";
            Console.WriteLine(textAttribute.TextValue);

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
            //ExEnd:CalculateDateTimeFunctions
        }
    }
}
