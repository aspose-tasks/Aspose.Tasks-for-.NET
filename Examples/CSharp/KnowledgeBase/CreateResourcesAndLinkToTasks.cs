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
    using Aspose.Tasks.Util;

    internal class CreateResourcesAndLinkToTasks
    {
        public static void Run()
        {
            try
            {
                var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                //ExStart:CreateResourcesAndLinkToTasks
                //ExFor: Project.Resources.Add(String)
                //ExFor: Project.ResourceAssignments.Add(Task, Resource)
                //ExSummary: Shows how to create resources and resource assignments.
                var project = new Project(dataDir + "SampleProject.mpp");

                // Declare ChildTasksCollector class object
                var collector = new ChildTasksCollector();

                // Use TaskUtils to get all children tasks in RootTask
                TaskUtils.Apply(project.RootTask, collector, 0);

                // Define Resources
                for (var i = 0; i <= 4; i++)
                {
                    var name = "Developer0" + i;

                    // Add resource to project
                    var resource = project.Resources.Add(name);
                    resource.Set(Rsc.Type, ResourceType.Work);

                    // Add assignment
                    project.ResourceAssignments.Add(collector.Tasks[i], resource);                    
                }

                project.Save(dataDir + "CreateResourcesAndLinkToTasks_out.mpp", SaveFileFormat.MPP);
                //ExEnd:CreateResourcesAndLinkToTasks
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
