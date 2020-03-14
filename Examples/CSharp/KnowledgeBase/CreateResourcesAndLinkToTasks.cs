using Aspose.Tasks.Saving;
using Aspose.Tasks.Util;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.KnowledgeBase
{
    class CreateResourcesAndLinkToTasks
    {
        public static void Run()
        {
            try
            {
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                //ExStart:CreateResourcesAndLinkToTasks
                Project project1 = new Project(dataDir + "SampleProject.mpp");

                // Declare ChildTasksCollector class object
                ChildTasksCollector collector = new ChildTasksCollector();

                // Use TaskUtils to get all children tasks in RootTask
                TaskUtils.Apply(project1.RootTask, collector, 0);

                // Define Resources
                for (int i = 0; i <= 4; i++)
                {
                    string developer0 = "Developer0" + i;

                    // Add resource to project
                    Resource newResource = project1.Resources.Add(developer0);
                    newResource.Set(Rsc.Type, ResourceType.Work);

                    // Define assignment
                    ResourceAssignment newResourceAssignment = project1.ResourceAssignments.Add(collector.Tasks[i], newResource);                    
                }

                project1.Save(dataDir + "CreateResourcesAndLinkToTasks_out.mpp", SaveFileFormat.MPP);
                //ExEnd:CreateResourcesAndLinkToTasks
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
