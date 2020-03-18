namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using System;

    internal class ReadTaskExtendedAttributes
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:ReadTaskExtendedAttributes
            // Create project instance
            var project = new Project(dataDir + "ReadTaskExtendedAttributes.mpp");

            // Read extended attributes for tasks
            foreach (var tsk in project.RootTask.Children)
            {
                foreach (var ea in tsk.ExtendedAttributes)
                {
                    Console.WriteLine(ea.FieldId);
                    Console.WriteLine(ea.ValueGuid);

                    switch (ea.AttributeDefinition.CfType)
                    {
                        case CustomFieldType.Date:
                        case CustomFieldType.Start:
                        case CustomFieldType.Finish:
                            Console.WriteLine(ea.DateValue);
                            break;
                        case CustomFieldType.Text:
                            Console.WriteLine(ea.TextValue);
                            break;
                        case CustomFieldType.Duration:
                            Console.WriteLine(ea.DurationValue.ToString());
                            break;
                        case CustomFieldType.Cost:
                        case CustomFieldType.Number:
                            Console.WriteLine(ea.NumericValue);
                            break;
                        case CustomFieldType.Flag:
                            Console.WriteLine(ea.FlagValue);
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
