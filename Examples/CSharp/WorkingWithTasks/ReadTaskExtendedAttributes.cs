namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using System;

    internal class ReadTaskExtendedAttributes
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:ReadTaskExtendedAttributes
            //ExFor: Task.ExtendedAttributes
            //ExFor: ExtendedAttributeDefinition.CfType
            //ExSummary: Shows how to read task extended attributes.
            // Create project instance
            var project = new Project(dataDir + "ReadTaskExtendedAttributes.mpp");

            // Read extended attributes for tasks
            foreach (var task in project.RootTask.Children)
            {
                foreach (var attribute in task.ExtendedAttributes)
                {
                    Console.WriteLine(attribute.FieldId);
                    Console.WriteLine(attribute.ValueGuid);

                    switch (attribute.AttributeDefinition.CfType)
                    {
                        case CustomFieldType.Date:
                        case CustomFieldType.Start:
                        case CustomFieldType.Finish:
                            Console.WriteLine(attribute.DateValue);
                            break;
                        case CustomFieldType.Text:
                            Console.WriteLine(attribute.TextValue);
                            break;
                        case CustomFieldType.Duration:
                            Console.WriteLine(attribute.DurationValue.ToString());
                            break;
                        case CustomFieldType.Cost:
                        case CustomFieldType.Number:
                            Console.WriteLine(attribute.NumericValue);
                            break;
                        case CustomFieldType.Flag:
                            Console.WriteLine(attribute.FlagValue);
                            break;
                        case CustomFieldType.Null:
                        case CustomFieldType.RBS:
                        case CustomFieldType.OutlineCode:
                            return;
                        default:
                            return;
                    }
                }
            }
            //ExEnd:ReadTaskExtendedAttributes
        }
    }
}
