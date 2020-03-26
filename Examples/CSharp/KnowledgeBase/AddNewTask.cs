/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.KnowledgeBase
{
    using System;

    using Aspose.Tasks.Saving;

    internal class AddNewTask
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:AddNewTask
            //ExFor: Task
            //ExFor: Project.RootTask
            //ExFor: Tsk.ActualStart
            //ExFor: Tsk.Duration
            //ExFor: Tsk.DurationFormat
            //ExSummary: Shows how to add a task into a project. 
            var project = new Project(dataDir + "Project1.mpp");

            var task = project.RootTask.Children.Add("Task1");
            task.Set(Tsk.ActualStart, DateTime.Parse("23-Aug-2012"));

            // Set duration in hours
            task.Set(Tsk.Duration, project.GetDuration(24, TimeUnitType.Hour));
            task.Set(Tsk.DurationFormat, TimeUnitType.Day);
            
            // Save the Project as XML
            project.Save(dataDir + "AddNewTask_out.xml", SaveFileFormat.XML);
            //ExEnd:AddNewTask        
        }
    }
}
