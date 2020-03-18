namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    using System;

    using Aspose.Tasks.Saving;

    public class MPPFileUpdate
    {
        public static void Run()
        {
            try
            {
                //ExStart:MPPFileUpdate
                // The path to the documents directory.
                var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                // Read an existing project
                var project = new Project(dataDir + "MPPFileUpdate.mpp");

                // Create a new task
                var task = project.RootTask.Children.Add("Task1");

                task.Set(Tsk.Start, new DateTime(2012, 8, 1));
                task.Set(Tsk.Finish, new DateTime(2012, 8, 5));

                // Save the project as MPP project file
                project.Save(dataDir + "AfterLinking_out.Mpp", SaveFileFormat.MPP);
                //ExEnd:MPPFileUpdate   
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }            
        }
    }
}