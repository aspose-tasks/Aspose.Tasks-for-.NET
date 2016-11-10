using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    class ViewSplitTasks
    {
        public static void Run()
        {
            // ExStart:ViewSplitTasks
            // Create project instance
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            Project project1 = new Project(dataDir + "project.mpp");
            
            // Access task 
            Task splitTask = project1.RootTask.Children.GetById(4);

            // Display split parts of task
            SplitPartCollection collection = splitTask.SplitParts;
            foreach (SplitPart splitPart in collection)
            {
                Console.WriteLine("Index: " + splitPart.Index + "\nStart: " + splitPart.Start + "\nFinish: " + splitPart.Finish + "\n");
            }
            // ExEnd:ViewSplitTasks
        }
    }
}
