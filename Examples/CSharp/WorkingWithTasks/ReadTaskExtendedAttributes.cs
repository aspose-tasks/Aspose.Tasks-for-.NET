using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    class ReadTaskExtendedAttributes
    {
        public static void Run()
        {
            // ExStart:ReadTaskExtendedAttributes
            // Create project instance
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            Project project1 = new Project(dataDir + "ReadTaskExtendedAttributes.mpp");

            // Read extended attributes for tasks
            foreach (Task tsk in project1.RootTask.Children)
            {
                foreach (ExtendedAttribute ea in tsk.ExtendedAttributes)
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
                    }
                }
            }
            // ExEnd:ReadTaskExtendedAttributes
        }
    }
}
