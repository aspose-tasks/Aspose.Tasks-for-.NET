using System;
using Aspose.Tasks.Saving;

namespace Aspose.Tasks.Examples.CSharp.CustomizingCreatedProject
{
    public class SetAttributesForNewTasks
    {
        public static void Run()
        {
            // ExStart:SetAttributesForNewTasks
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CustomizingCreatedProject();

            // Create a project instance Set new task property and Save the project as XML project file
            Project project = new Project();
            project.Set(Prj.NewTaskStartDate, TaskStartDateType.CurrentDate);
            project.Save(dataDir + "Project_out.xml", SaveFileFormat.XML);
 
            // Display Status.
            Console.WriteLine("New Task created with start date successfully.");
            // ExEnd:SetAttributesForNewTasks
        }
    }
}