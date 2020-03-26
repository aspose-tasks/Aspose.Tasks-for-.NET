namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    using System;

    internal class IdentifyCrossProjectTasks
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:IdentifyCrossProjectTasks
            //ExFor: Tsk.ExternalId
            //ExSummary: Shows how to identify cross project tasks.
            var project = new Project(dataDir + "External.mpp");
            var externalTask = project.RootTask.Children.GetByUid(1);

            // Show ID of the task in the external project
            Console.WriteLine(externalTask.Get(Tsk.Id).ToString());
            
            // Show ID of the task in the original project
            Console.WriteLine(externalTask.Get(Tsk.ExternalId).ToString());
            //ExEnd:IdentifyCrossProjectTasks
        }
    }
}
