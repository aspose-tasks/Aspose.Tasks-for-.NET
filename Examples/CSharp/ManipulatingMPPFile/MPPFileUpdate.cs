using System;
using Aspose.Tasks.Saving;

namespace Aspose.Tasks.Examples.CSharp.ManipulatingMPPFile
{
    public class MPPFileUpdate
    {
        public static void Run()
        {
            try
            {
                // ExStart:MPPFileUpdate
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ManipulatingMPPFile();

                // Read an existing project
                Project project = new Project(dataDir + "MPPFileUpdate.mpp");

                // Create a new task
                Task task = project.RootTask.Children.Add("Task1");

                task.Set(Tsk.Start, new DateTime(2012, 8, 1));
                task.Set(Tsk.Finish, new DateTime(2012, 8, 5));

                // Save the project as MPP project file
                project.Save(dataDir + "AfterLinking_out.Mpp", SaveFileFormat.MPP);
                // ExEnd:MPPFileUpdate   

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
            
        }
    }
}