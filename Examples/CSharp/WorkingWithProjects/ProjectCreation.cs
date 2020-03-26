namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    using System;
    using System.Reflection;
    using Saving;

    internal class ProjectCreation
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(MethodBase.GetCurrentMethod());
            
            //ExStart:ProjectCreation
            //ExFor: Project
            //ExSummary: Shows how to work with a <see cref="Aspose.Tasks.Project"/> instance.
            var project = new Project();
            project.Set(Prj.WorkFormat, TimeUnitType.Hour); // set the desired project properties
            project.Set(Prj.NewTasksAreManual, false);

            // adding new tasks and set desired properties
            var task1 = project.RootTask.Children.Add("Task 1");
            task1.Set(Tsk.Start, new DateTime(2020, 2, 5, 8, 0, 0));
            task1.Set(Tsk.Duration, project.GetDuration(8, TimeUnitType.Hour));
            task1.Set(Tsk.Finish, new DateTime(2020, 2, 5, 17, 0, 0));
            var task2 = project.RootTask.Children.Add("Task 2");
            task2.Set(Tsk.Start, new DateTime(2020, 2, 6, 8, 0, 0));
            task2.Set(Tsk.Duration, project.GetDuration(8, TimeUnitType.Hour));
            task2.Set(Tsk.Finish, new DateTime(2020, 2, 6, 17, 0, 0));

            // adding new resources
            var workResource = project.Resources.Add("Work Resource");
            workResource.Set(Rsc.Type, ResourceType.Work);
            var costResource = project.Resources.Add("Cost Resource");
            costResource.Set(Rsc.Type, ResourceType.Cost);

            // adding new resource assignments
            var workResourceAssignment = project.ResourceAssignments.Add(task1, workResource);
            workResourceAssignment.Set(Asn.Start, new DateTime(2020, 2, 5, 8, 0, 0));
            workResourceAssignment.Set(Asn.Work, project.GetWork(8));
            workResourceAssignment.Set(Asn.Finish, new DateTime(2020, 2, 5, 17, 0, 0));
            var costResourceAssignment = project.ResourceAssignments.Add(task2, costResource);
            costResourceAssignment.Set(Asn.Start, new DateTime(2020, 2, 6, 8, 0, 0));
            costResourceAssignment.Set(Asn.Work, project.GetWork(8));
            costResourceAssignment.Set(Asn.Finish, new DateTime(2020, 2, 6, 17, 0, 0));

            // save project in the one of available formats
            // here we are saving it in Microsoft Project XML file format.
            project.Save(dataDir + "ProjectCreation_out.xml", SaveFileFormat.XML);
            //ExEnd:ProjectCreation
        }
    }
}