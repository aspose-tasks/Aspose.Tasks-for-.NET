namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using System;

    internal class ViewSplitTasks
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:ViewSplitTasks
            // Create project instance
            var project = new Project(dataDir + "ViewSplitTasks.mpp");
            
            // Access task 
            var splitTask = project.RootTask.Children.GetById(4);

            // Display split parts of task
            var collection = splitTask.SplitParts;
            foreach (var splitPart in collection)
            {
                Console.WriteLine("Index: " + splitPart.Index + "\nStart: " + splitPart.Start + "\nFinish: " + splitPart.Finish + "\n");
            }
            //ExEnd:ViewSplitTasks
        }
    }
}
