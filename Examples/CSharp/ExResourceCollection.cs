namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;
    using Util;

    [TestFixture]
    public class ExResourceCollection : ApiExampleBase
    {
        [Test]
        public void CreateResourcesAndLinkToTasks()
        {
            try
            {
                //ExStart:CreateResourcesAndLinkToTasks
                //ExFor: ResourceCollection.Add(String)
                //ExSummary: Shows how to create resources and resource assignments.
                var project = new Project(DataDir + "SampleProject.mpp");

                // Declare ChildTasksCollector instance
                var collector = new ChildTasksCollector();

                // Use TaskUtils to get all children tasks in RootTask
                TaskUtils.Apply(project.RootTask, collector, 0);

                // add new resources
                for (var i = 0; i <= 4; i++)
                {
                    // Add resource to project
                    var resource = project.Resources.Add("Developer0" + i);
                    resource.Set(Rsc.Type, ResourceType.Work);

                    // Add assignment
                    project.ResourceAssignments.Add(collector.Tasks[i], resource);                    
                }

                project.Save(OutDir + "CreateResourcesAndLinkToTasks_out.mpp", SaveFileFormat.MPP);
                //ExEnd:CreateResourcesAndLinkToTasks
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}