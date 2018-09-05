using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithFormulas
{
    class CalculateDateTimeFunctions
    {
        public static void Run()
        {
            // ExStart:CalculateDateTimeFunctions
            Project project = CreateTestProject();
            Task task = project.RootTask.Children.GetById(1);

            ExtendedAttributeDefinition numberDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Number1, null);
            project.ExtendedAttributes.Add(numberDefinition);

            ExtendedAttribute numberAttribute = numberDefinition.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(numberAttribute);

            // Set ProjDateDiff formula and print extended attribute value
            numberDefinition.Formula = "ProjDateDiff(\"03/23/2015\",\"03/18/2015\")";
            Console.WriteLine(numberAttribute.NumericValue);
            numberDefinition.Formula = "ProjDateDiff(\"03/23/2015\",\"03/25/2015\")";
            Console.WriteLine(numberAttribute.NumericValue);

            ExtendedAttributeDefinition dateDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Date1, null);
            project.ExtendedAttributes.Add(dateDefinition);
            ExtendedAttribute dateAttribute = dateDefinition.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(dateAttribute);

            ExtendedAttributeDefinition durationDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Duration4, "Custom duration field");
            project.ExtendedAttributes.Add(durationDefinition);
            ExtendedAttribute durationAttribute = durationDefinition.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(durationAttribute);

            ExtendedAttributeDefinition textDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Text5, "Custom text field");
            project.ExtendedAttributes.Add(textDefinition);
            ExtendedAttribute textAttribute = textDefinition.CreateExtendedAttribute();
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

            // Set Second formula and print entended attribute value
            numberDefinition.Formula = "Second(\"4/21/2015 2:53:41 AM\")";
            Console.WriteLine(numberAttribute.NumericValue);

            // Set Weekday formula and print entended attribute value
            numberDefinition.Formula = "Weekday(\"24/3/2015\", 1)";
            Console.WriteLine(numberAttribute.NumericValue);
            numberDefinition.Formula = "Weekday(\"24/3/2015\", 2)";
            Console.WriteLine(numberAttribute.NumericValue);
            numberDefinition.Formula = "Weekday(\"24/3/2015\", 3)";
            Console.WriteLine(numberAttribute.NumericValue);
            // ExEnd:CalculateDateTimeFunctions
        }

        private static Project CreateTestProject()
        {
            Project project = new Project();
            project.RootTask.Children.Add("Task");
            return project;
        }
    }
}
