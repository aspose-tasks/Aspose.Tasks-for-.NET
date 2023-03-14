namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExPrimaveraRead : ApiExampleBase
    {
        [Test]
        public void ReadXmlFileWithMultipleProjects1()
        {
            // ExStart:ReadXMLFileWithMultipleProjects
            // ExFor: PrimaveraReadOptions
            // ExFor: PrimaveraReadOptions.ProjectUid
            // ExSummary: Shows how to read a project from a Primavera XML or Primavera XER file containing multiple projects.
            var options = new PrimaveraReadOptions();
            options.ProjectUid = 3881;

            // Returns project with special Uid
            var project = new Project(DataDir + "PrimaveraProject.xml", options);
            Console.WriteLine(project.Get(Prj.Name));

            // ExEnd:ReadXMLFileWithMultipleProjects
        }

        [Test]
        public void ReadPrimaveraXmlFileAndAccessPrimaveraSpecificProperties()
        {
            // ExStart:ReadPrimaveraXmlFileAndAccessPrimaveraSpecificProperties
            // ExFor: Task.PrimaveraProperties
            // ExSummary: Shows how to read a project from a Primavera XML and examine tasks' Primavera-specific properties.
            var options = new PrimaveraReadOptions();
            options.ProjectUid = 3883;

            // Returns project with special Uid
            var project = new Project(DataDir + "PrimaveraProject.xml", options);

            foreach (Task task in project.EnumerateAllChildTasks())
            {
                Console.WriteLine("Task '{0}'", task.Name);

                if (task.IsSummary)
                {
                    Console.WriteLine("WBS Sequence number: {0}", task.PrimaveraProperties.SequenceNumber);
                }
                else
                {
                    Console.WriteLine("Task ActivityId: {0}", task.PrimaveraProperties.ActivityId);
                }

                Console.WriteLine("Activity Type: {0}", task.PrimaveraProperties.ActivityType);
                Console.WriteLine("Duration Type: {0}", task.PrimaveraProperties.DurationType);
                Console.WriteLine("Percent Complete Type: {0}", task.PrimaveraProperties.PercentCompleteType);
                Console.WriteLine("Original Duration: {0:N2}", task.Duration.TimeSpan.TotalHours);
                Console.WriteLine("At Complete Duration: {0:N2}", task.ActualDuration.TimeSpan.TotalHours + task.RemainingDuration.TimeSpan.TotalHours);
                Console.WriteLine("Duration % Complete: {0}", task.PrimaveraProperties.DurationPercentComplete);
                Console.WriteLine("Physical % Complete: {0}", task.PrimaveraProperties.PhysicalPercentComplete);

                Console.WriteLine("Task RemainingEarlyStart: {0}", task.PrimaveraProperties.RemainingEarlyStart);
                Console.WriteLine("Task RemainingEarlyFinish: {0}", task.PrimaveraProperties.RemainingEarlyFinish);

                Console.WriteLine("Labor Units:");
                Console.WriteLine("{0}, {1}, {2}, {3}", 
                    task.PrimaveraProperties.ActualLaborUnits,
                    task.PrimaveraProperties.ActualNonLaborUnits,
                    task.PrimaveraProperties.RemainingLaborUnits,
                    task.PrimaveraProperties.RemainingNonLaborUnits);

                Console.WriteLine("Actual costs:");
                Console.WriteLine("{0}, {1}, {2}, {3}, Total: {4}",
                    task.PrimaveraProperties.ActualExpenseCost,
                    task.PrimaveraProperties.ActualLaborCost,
                    task.PrimaveraProperties.ActualMaterialCost,
                    task.PrimaveraProperties.ActualNonlaborCost,
                    task.PrimaveraProperties.ActualTotalCost);

                Console.WriteLine("Units % Complete: {0}", task.PrimaveraProperties.UnitsPercentComplete);
            }

            // ExEnd:ReadPrimaveraXmlFileAndAccessPrimaveraSpecificProperties
        }

        [Test]
        public void AccessPrimaveraSpecificProjectProperties()
        {
            // ExStart:AccessPrimaveraSpecificProjectProperties
            // ExFor: Project.PrimaveraProperties
            // ExSummary: Shows how to read a project from a Primavera file and examine project's Primavera-specific properties.

            var options = new PrimaveraReadOptions();
            options.ProjectUid = 4861;

            // Returns project with special Uid
            var project = new Project(DataDir + "ScheduleOptions.xer", options);

            // PrimaveraProperties can be null if project's schedule options have default values.
            if (project.PrimaveraProperties != null)
            {
                Console.WriteLine("Project's schedule options:");
                Console.WriteLine("Relationship Lag Calendar: " + project.PrimaveraProperties.RelationshipLagCalendar);
                Console.WriteLine("Make Open Ended Activities Critical: " + project.PrimaveraProperties.MakeOpenEndedActivitiesCritical);
                Console.WriteLine("Ignore Other Project Relationships: " + project.PrimaveraProperties.IgnoreOtherProjectRelationships);
                Console.WriteLine("Use Expected Finish Dates: " + project.PrimaveraProperties.UseExpectedFinishDates);
            }

            // ExEnd:AccessPrimaveraSpecificProjectProperties
        }
    }
}