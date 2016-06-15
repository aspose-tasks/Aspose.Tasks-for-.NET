using System.IO;
using Aspose.Tasks;
using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class MPPFileUpdate
    {
        public static void Run()
        {
            //ExStart: MPPFileUpdate
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();
            //Read an existing project
            Project project = new Project(dataDir+ "MPPFileUpdate.mpp");

            //create a new task
            Task task = project.RootTask.Children.Add("Task1");

            task.Set(Tsk.Start, new System.DateTime(2012, 8, 1));
            task.Set(Tsk.Finish, new DateTime(2012, 8, 5));

            //Save the project as MPP project file
            project.Save(dataDir+ "AfterLinking.Mpp", Aspose.Tasks.Saving.SaveFileFormat.MPP);
            //ExEnd: MPPFileUpdate   
        }
    }
}