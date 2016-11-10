using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    class ReadTaskExtendedAttributes
    {
        public static void Run()
        {
            // ExStart:ReadTaskExtendedAttributes
            // Create project instance
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            Project project1 = new Project(dataDir + "project.mpp");

            // Read extended attributes for tasks
            foreach (Task tsk in project1.RootTask.Children)
            {
                foreach (ExtendedAttribute ea in tsk.ExtendedAttributes)
                {
                    Console.WriteLine(ea.FieldId);
                    Console.WriteLine(ea.Value);
                    Console.WriteLine(ea.ValueGuid);
                }
            }
            // ExEnd:ReadTaskExtendedAttributes
        }
    }
}
