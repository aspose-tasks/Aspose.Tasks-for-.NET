/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using Aspose.Tasks.Saving;

    internal class WriteTaskProperties
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:WriteTaskProperties
            //ExFor: Tsk.Start
            //ExFor: Tsk.Name
            //ExSummary: Shows how to set task properties.
            var project = new Project();
            
            // Add task and set task properties
            var task = project.RootTask.Children.Add("Task1");
            task.Set(Tsk.Start, project.RootTask.Get(Tsk.Start).AddDays(1));
            task.Set(Tsk.Name, "Task1");
            
            // Save project
            project.Save(dataDir + "WriteTaskProperties_out.pdf", SaveFileFormat.PDF);
            //ExEnd:WriteTaskProperties
        }
    }
}
