namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;
    using Saving;
    using Util;

    [TestFixture]
    public class ExResourceAssignment : ApiExampleBase
    {
        [Test]
        public void CreateSplittedTasks()
        {
            // ExStart:CreateSplittedTasks
            // ExFor: ResourceAssignment.TimephasedDataFromTaskDuration(Calendar)
            // ExFor: ResourceAssignment.SplitTask(DateTime, DateTime, Calendar)
            // ExSummary: Shows how to add a split for a task.
            var project = new Project();

            // Get a standard calendar
            var calendar = project.Get(Prj.Calendar);

            // Set project's calendar settings
            project.Set(Prj.StartDate, new DateTime(2000, 3, 15, 8, 0, 0));
            project.Set(Prj.FinishDate, new DateTime(2000, 4, 21, 17, 0, 0));

            // Add a new task to root task
            var task = project.RootTask.Children.Add("Task1");
            task.Set(Tsk.Duration, project.GetDuration(3));

            // Create a new resource assignment and generate timephased data
            var assignment = project.ResourceAssignments.Add(task, null);
            assignment.TimephasedDataFromTaskDuration(calendar);

            // Split the task into 3 parts.
            // Provide start date and finish date arguments to SplitTask method which will be used for split
            assignment.SplitTask(new DateTime(2000, 3, 16, 8, 0, 0), new DateTime(2000, 3, 16, 17, 0, 0), calendar);
            assignment.SplitTask(new DateTime(2000, 3, 18, 8, 0, 0), new DateTime(2000, 3, 18, 17, 0, 0), calendar);
            assignment.Set(Asn.WorkContour, WorkContourType.Contoured);

            project.Save(OutDir + "CreateSplitTasks_out.xml", SaveFileFormat.Xml);

            // ExEnd:CreateSplittedTasks
        }

        [Test]
        public void ReadWriteTimephasedData()
        {
            // ExStart:ReadWriteTimephasedData
            // ExFor: ResourceAssignment.GetTimephasedData(DateTime, DateTime)
            // ExFor: ResourceAssignment.GetTimephasedData(DateTime, DateTime, TimephasedDataType)
            // ExSummary: Shows how to generate timephased data of a resource assignment within a date range.
            var project = new Project(DataDir + "ReadWriteTimephasedData.mpp");

            // Set project properties
            project.Set(Prj.StartDate, new DateTime(2013, 10, 30, 9, 0, 0));
            project.Set(Prj.NewTasksAreManual, false);

            var task = project.RootTask.Children.Add("Task");
            task.Set(Tsk.Duration, project.GetDuration(6));

            var rsc = project.Resources.Add("Rsc");
            rsc.Set(Rsc.StandardRate, 10);
            rsc.Set(Rsc.OvertimeRate, 15);

            // Create resource assignment
            var assn = project.ResourceAssignments.Add(task, rsc);
            assn.Set(Asn.Stop, DateTime.MinValue);
            assn.Set(Asn.Resume, DateTime.MinValue);

            // Set Backloaded contour, it increases task duration from 6 to 10 days
            assn.Set(Asn.WorkContour, WorkContourType.BackLoaded);

            project.SetBaseline(BaselineType.Baseline);
            task.Set(Tsk.PercentComplete, 50);

            // get timephased data
            List<TimephasedData> td = assn.GetTimephasedData(assn.Get(Asn.Start), assn.Get(Asn.Finish), TimephasedDataType.AssignmentRemainingWork).ToList();
            Console.WriteLine(td.Count);
            foreach (var timePhasedValue in td)
            {
                Console.WriteLine(timePhasedValue.Value);
            }

            // ExEnd:ReadWriteTimephasedData
        }

        [Test]
        public void ReadResourceAssignmentTimephasedData()
        {
            // ExStart:ReadResourceAssignmentTimephasedData
            // ExFor: ResourceAssignment.TimephasedData
            // ExSummary: Shows how to read timephased data of a resource assignment.
            var project = new Project(DataDir + "ReadWriteTimephasedData.mpp");
            project.Set(Prj.StartDate, new DateTime(2013, 10, 30, 9, 0, 0));
            project.Set(Prj.NewTasksAreManual, false);

            var task = project.RootTask.Children.Add("Task");
            task.Set(Tsk.Duration, project.GetDuration(6));

            var rsc = project.Resources.Add("Rsc");
            rsc.Set(Rsc.StandardRate, 10);
            rsc.Set(Rsc.OvertimeRate, 15);

            // Create resource assignment
            var assn = project.ResourceAssignments.Add(task, rsc);
            assn.Set(Asn.Stop, DateTime.MinValue);
            assn.Set(Asn.Resume, DateTime.MinValue);
            assn.Set(Asn.WorkContour, WorkContourType.BackLoaded);

            // get timephased data
            foreach (var td in assn.TimephasedData)
            {
                Console.WriteLine(td.Value);
            }

            // ExEnd:ReadResourceAssignmentTimephasedData
        }

        [Test]
        public void PrintResourceAssignmentCommonInformation()
        {
            // ExStart:PrintAssignmentCommonInformation
            // ExFor: ResourceAssignment.ToString()
            // ExSummary: Shows how to print common assignment info.
            var project = new Project(DataDir + "BudgetWorkAndCost.mpp");

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);
            foreach (var task in collector.Tasks)
            {
                // display task's assignments
                foreach (var assignment in task.Assignments)
                {
                    Console.WriteLine(assignment.ToString());
                }
            }

            // ExEnd:PrintAssignmentCommonInformation
        }

        [Test]
        public void CreateAndGetSetResourceAssignmentCommonProperties()
        {
            // ExStart:CreateAndGetSetResourceAssignmentCommonProperties
            // ExFor: ResourceAssignment
            // ExFor: ResourceAssignment.Get``1(Aspose.Tasks.Key{``0,Aspose.Tasks.AsnKey})
            // ExFor: ResourceAssignment.Set``1(Aspose.Tasks.Key{``0,Aspose.Tasks.AsnKey},``0)
            // ExSummary: Shows how to create an assignment and get/set common assignment properties.
            var project = new Project(DataDir + "BudgetWorkAndCost.mpp");

            var task = project.RootTask.Children.Add("Task");
            task.Set(Tsk.Start, new DateTime(2020, 4, 2, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(1));
            task.Set(Tsk.Finish, new DateTime(2020, 4, 2, 17, 0, 0));
            var resource = project.Resources.Add("Resource");
            var resourceAssignment = project.ResourceAssignments.Add(task, resource);
            resourceAssignment.Set(Asn.Start, new DateTime(2020, 4, 2, 8, 0, 0));
            resourceAssignment.Set(Asn.Work, project.GetWork(1));
            resourceAssignment.Set(Asn.Finish, new DateTime(2020, 4, 2, 17, 0, 0));

            Console.WriteLine(resourceAssignment.Get(Asn.Start));
            Console.WriteLine(resourceAssignment.Get(Asn.Work));
            Console.WriteLine(resourceAssignment.Get(Asn.Finish));

            // ExEnd:CreateAndGetSetResourceAssignmentCommonProperties
        }

        [Test]
        public void ResourceAssignmentEquals()
        {
            // ExStart
            // ExFor: ResourceAssignment.Equals(ResourceAssignment)
            // ExFor: ResourceAssignment.Equals(Object)
            // ExSummary: Shows how to check resource assignment equality.
            var project = new Project(DataDir + "BaselineTD2010_3.mpp");

            var resourceAssignment1 = project.ResourceAssignments.GetByUid(1);
            var resourceAssignment2 = project.ResourceAssignments.GetByUid(1);

            Console.WriteLine("Are resource assignments equal: " + resourceAssignment1.Equals(resourceAssignment2));

            // ExEnd
        }

        [Test]
        public void GetResourceAssignmentHashCode()
        {
            // ExStart
            // ExFor: ResourceAssignment.GetHashCode()
            // ExSummary: Shows how to get a hash code of a resource assignment.
            var project = new Project(DataDir + "BaselineTD2010_3.mpp");

            var resourceAssignment1 = project.ResourceAssignments.GetByUid(2);
            var resourceAssignment2 = project.ResourceAssignments.GetByUid(3);

            // print assignment's hash codes
            Console.WriteLine("Resource Assignment 1 Hash Code: {0}", resourceAssignment1.GetHashCode());
            Console.WriteLine("Resource Assignment 2 Hash Code: {0}", resourceAssignment2.GetHashCode());

            // ExEnd
        }

        [Test]
        public void ResourceAssignmentParentProject()
        {
            // ExStart
            // ExFor: ResourceAssignment.ParentProject
            // ExSummary: Shows how to use parent project of a resource assignment.
            var project = new Project();
            var task = project.RootTask.Children.Add("Task");
            var resource = project.Resources.Add("Resource");
            var resourceAssignment = project.ResourceAssignments.Add(task, resource);

            // set a duration of the assignment by using default project time unit type.
            resourceAssignment.Set(Asn.Work, resource.ParentProject.GetWork(1));

            Console.WriteLine(resourceAssignment.Get(Asn.Work));

            // ExEnd
        }

        [Test]
        public void GetResourceAssignmentBaselines()
        {
            // ExStart
            // ExFor: ResourceAssignment.Baselines
            // ExSummary: Shows how to get access to assignment's baselines.
            var project = new Project();
            var task = project.RootTask.Children.Add("Task");
            var resource = project.Resources.Add("Resource");
            var resourceAssignment = project.ResourceAssignments.Add(task, resource);

            project.SetBaseline(BaselineType.Baseline);

            foreach (var assignmentBaseline in resourceAssignment.Baselines)
            {
                Console.WriteLine("Baseline Start: {0}", assignmentBaseline.Start);
                Console.WriteLine("Baseline Finish: {0}", assignmentBaseline.Finish);
            }

            // ExEnd            
        }

        [Test]
        public void ResourceAssignmentDelete()
        {
            // ExStart
            // ExFor: ResourceAssignment.Delete
            // ExSummary: Shows how to delete a resource assignment.
            var project = new Project();
            var task = project.RootTask.Children.Add("Task");
            var resource = project.Resources.Add("Resource");
            var resourceAssignment = project.ResourceAssignments.Add(task, resource);

            Console.WriteLine("Assignment count (before): {0}", project.ResourceAssignments.Count);

            resourceAssignment.Delete();

            Console.WriteLine("Assignment count (after): {0}", project.ResourceAssignments.Count);

            // ExEnd            
        }

        [Test]
        public void ResourceAssignmentExtendedAttributes()
        {
            // ExStart
            // ExFor: ResourceAssignment.ExtendedAttributes
            // ExSummary: Shows how to add extended attributes for an assignment.
            var project = new Project(DataDir + "Blank2010.mpp");

            // Assign resource "1 TRG: Trade Group" to the "TASK 1" by creating a ResourceAssignment object.
            var task = project.RootTask.Children.Add("Task");
            var resource = project.Resources.Add("Resource");
            var assignment = project.ResourceAssignments.Add(task, resource);

            // Create custom attribute definition with lookup.
            var definition = ExtendedAttributeDefinition.CreateLookupResourceDefinition(CustomFieldType.Cost, ExtendedAttributeResource.Cost5, "My lookup resource cost");
            project.ExtendedAttributes.Add(definition);

            var firstValue = new Value { NumericValue = 1500, Description = "Val 1", Id = 1, Val = "1500" };
            var secondValue = new Value { NumericValue = 2500, Description = "Val 2", Id = 2 };
            definition.AddLookupValue(firstValue);
            definition.AddLookupValue(secondValue);

            // This value can be seen in "Resource usage" view of MS Project.
            var attributeValue = definition.CreateExtendedAttribute(firstValue);
            assignment.ExtendedAttributes.Add(attributeValue);

            Console.WriteLine("Number of assignment's extended attribute: " + assignment.ExtendedAttributes.Count);
            foreach (var attribute in assignment.ExtendedAttributes)
            {
                Console.WriteLine("Extended attribute alias: " + attribute.AttributeDefinition.Alias);
            }

            // ExEnd
        }

        [Test]
        public void ResourceAssignmentGuid()
        {
            // ExStart
            // ExFor: ResourceAssignment.Guid
            // ExSummary: Shows how to read an resource assignment GUID.
            var project = new Project();
            var task = project.RootTask.Children.Add("Task");
            var resource = project.Resources.Add("Resource");
            var assignment = project.ResourceAssignments.Add(task, resource);

            Console.WriteLine(assignment.Guid);

            // ExEnd
        }

        [Test]
        public void ResourceAssignmentMakeTPs()
        {
            // ExStart
            // ExFor: ResourceAssignment.MakeTPs(System.DateTime,System.TimeSpan,Aspose.Tasks.Calendar,System.Collections.Generic.List{Aspose.Tasks.TimephasedData},System.Boolean,System.Int32)
            // ExSummary: Shows how to generate TPs by parameters.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");
            task.Set(Tsk.Start, new DateTime(2020, 3, 30, 8, 0, 0));
            var resource = project.Resources.Add("Resource");
            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.Start, new DateTime(2020, 4, 1, 8, 0, 0));

            var tps = new List<TimephasedData>();
            var lastDate = assignment.MakeTPs(
                assignment.Get(Asn.Start),
                TimeSpan.FromHours(32),
                project.Calendars.GetByName("Standard"),
                tps,
                true,
                (int)TimephasedDataType.AssignmentRemainingWork);

            foreach (var data in tps)
            {
                Console.WriteLine("Start: " + data.Start);
                Console.WriteLine("Finish: " + data.Finish);
                Console.WriteLine("TimephasedDataType: " + data.TimephasedDataType);
                Console.WriteLine();
            }

            Assert.AreEqual(tps[tps.Count - 1].Finish, lastDate); // ExSkip

            // ExEnd
        }
    }
}