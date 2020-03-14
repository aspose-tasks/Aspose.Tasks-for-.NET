using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    class IdentifyCrossProjectTasks
    {
        public static void Run()
        {
            //ExStart:IdentifyCrossProjectTasks
            // Create project instance and access task
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            Project project1 = new Project(dataDir + "External.mpp");
            Task externalTask = project1.RootTask.Children.GetByUid(1);

            // Show ID of the task in the external project
            Console.WriteLine(externalTask.Get(Tsk.Id).ToString());
            
            // Show ID of the task in the original project
            Console.WriteLine(externalTask.Get(Tsk.ExternalId).ToString());
            //ExEnd:IdentifyCrossProjectTasks
        }
    }
}
