using System.IO;
using Aspose.Tasks;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class SetAttributesForNewTasks
    {
        public static void Run()
        {
            //ExStart: SetAttributesForNewTasks
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();

            ///Create a project instance
            Project prj = new Project();

            //Set new task property
            prj.Set(Prj.NewTaskStartDate, TaskStartDateType.CurrentDate);

            //Save the project as XML project file
            prj.Save(dataDir+ "project.xml", Aspose.Tasks.Saving.SaveFileFormat.XML);
 

            // Display Status.
            System.Console.WriteLine("New Task created with start date successfully.");
            //ExEnd: SetAttributesForNewTasks
        }
    }
}