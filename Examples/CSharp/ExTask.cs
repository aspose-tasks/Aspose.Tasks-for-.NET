namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using NUnit.Framework;
    using Saving;
    using Util;

    [TestFixture]
    [SuppressMessage("ReSharper", "StyleCop.SA1600", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global", Justification = "Reviewed. Suppression is OK here.")]
    public class ExTask : ApiExampleBase
    {
        [Test]
        public void CreateNewTask()
        {
            // ExStart:CreateNewTask
            // ExFor: Task
            // ExSummary: Shows how to add a task into a project. 
            var project = new Project();

            var task = project.RootTask.Children.Add("Task1");
            task.Set(Tsk.DurationFormat, TimeUnitType.Day);
            task.Set(Tsk.Start, new DateTime(2012, 8, 23, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(24, TimeUnitType.Hour));
            task.Set(Tsk.ActualStart, new DateTime(2012, 8, 23, 8, 0, 0));

            project.Save(OutDir + "CreateNewTask_out.xml", SaveFileFormat.XML);

            // ExEnd:CreateNewTask        
        }

        [Test]
        public void ViewSplitTasks()
        {
            // ExStart:ViewSplitTasks
            // ExFor: Task.SplitParts
            // ExSummary: Shows how to display task's split parts.
            var project = new Project(DataDir + "ViewSplitTasks.mpp");

            // Access task 
            var task = project.RootTask.Children.GetById(4);

            // Display split parts of task
            var collection = task.SplitParts;
            foreach (var splitPart in collection)
            {
                Console.WriteLine("Index: " + splitPart.Index + "\nStart: " + splitPart.Start + "\nFinish: " + splitPart.Finish + "\n");
            }

            // ExEnd:ViewSplitTasks
        }

        [Test]
        public static void MoveTaskUnderSameParent()
        {
            try
            {
                // ExStart:MoveTaskUnderSameParent
                // ExFor: Task.MoveToSibling(Int32)
                // ExSummary: Shows how to move the task under the same parent using task's Id.
                var project = new Project(DataDir + "MoveTask.mpp");

                // Move tasks with id 5 before task with id 3
                var task = project.RootTask.Children.GetById(5);

                task.MoveToSibling(3);

                // OR
                // Move task to the end of the collection
                // task.MoveToSibling(-1);
                project.Save(OutDir + "MoveTaskUnderSameParent_out.mpp", SaveFileFormat.MPP);

                // ExEnd:MoveTaskUnderSameParent
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose.Tasks License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public static void MoveTaskUnderSameParent2()
        {
            try
            {
                // ExStart:MoveTaskUnderSameParent2
                // ExFor: Task.MoveToSibling(Task)
                // ExSummary: Shows how to move the task under the same parent.
                var project = new Project(DataDir + "MoveTask.mpp");

                // Move tasks with id 5 before task with id 3
                var task = project.RootTask.Children.GetById(5);

                var targetTask = project.RootTask.Children.First(t => t.Get(Tsk.Name) == "Task4");
                task.MoveToSibling(targetTask);

                // OR
                // Move task to the end of the collection
                // task.MoveToSibling(null);
                project.Save(OutDir + "MoveTaskUnderSameParent_out.mpp", SaveFileFormat.MPP);

                // ExEnd:MoveTaskUnderSameParent2
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose.Tasks License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public void ReadWriteTaskProperties()
        {
            // ExStart:ReadWriteTaskProperties
            // ExFor: Task.Get``1(Aspose.Tasks.Key{``0,Aspose.Tasks.TaskKey})
            // ExFor: Task.Set``1(Aspose.Tasks.Key{``0,Aspose.Tasks.TaskKey},``0)
            // ExSummary: Shows how to get/set task properties.
            var project = new Project();

            // Add task and set task properties
            var task = project.RootTask.Children.Add();
            task.Set(Tsk.Name, "Task1");
            task.Set(Tsk.Start, new DateTime(2020, 3, 31, 8, 0, 0));
            task.Set(Tsk.Finish, new DateTime(2020, 3, 31, 17, 0, 0));

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (var tsk in collector.Tasks)
            {
                Console.WriteLine("Task Id: {0}", tsk.Get(Tsk.Id));
                Console.WriteLine("Task Uid: {0}", tsk.Get(Tsk.Uid));
                Console.WriteLine("Task Name: {0}", tsk.Get(Tsk.Name));
                Console.WriteLine("Task Start: {0}", tsk.Get(Tsk.Start));
                Console.WriteLine("Task Finish: {0}", tsk.Get(Tsk.Finish));
            }

            // ExEnd:ReadWriteTaskProperties
        }

        [Test]
        public void ReadWriteTaskExtendedAttributes()
        {
            try
            {
                // ExStart:ReadWriteTaskExtendedAttributes
                // ExFor: Task.ExtendedAttributes
                // ExSummary: Shows how to read task extended attributes.
                var project = new Project(DataDir + "ReadTaskExtendedAttributes.mpp");

                // Create extended attribute definition
                var definition = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Start, ExtendedAttributeTask.Start7, "Start 7");
                project.ExtendedAttributes.Add(definition);

                // Get zero index task
                var tsk = project.RootTask.Children.GetById(1);

                // Add extended attribute
                var extendedAttribute = definition.CreateExtendedAttribute();
                extendedAttribute.DateValue = DateTime.Now;

                // Also the following short syntax can be used: ExtendedAttribute attribute = attributeDefinition.CreateExtendedAttribute(DateTime.Now);
                tsk.ExtendedAttributes.Add(extendedAttribute);

                // Create an Extended Attribute Definition of Text1 type
                var taskExtendedAttributeText1Definition =
                    ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Text, ExtendedAttributeTask.Text1, "Task City Name");

                // Add it to the project's Extended Attributes collection
                project.ExtendedAttributes.Add(taskExtendedAttributeText1Definition);

                var newTask = project.RootTask.Children.Add("Task 1");

                // Create an Extended Attribute from the Attribute Definition
                var taskExtendedAttributeText1 = taskExtendedAttributeText1Definition.CreateExtendedAttribute();

                // Assign a value to the generated Extended Attribute. The type of the attribute is "Text", the "TextValue" property should be used.
                taskExtendedAttributeText1.TextValue = "London";

                // Add the Extended Attribute to task
                newTask.ExtendedAttributes.Add(taskExtendedAttributeText1);

                // Create an Extended Attribute Definition of Text2 type
                var taskExtendedAttributeText2Definition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(
                    CustomFieldType.Text,
                    ExtendedAttributeTask.Text2,
                    "Task Towns Name");

                // Add lookup values for the extended attribute definition
                taskExtendedAttributeText2Definition.AddLookupValue(new Value { Id = 1, StringValue = "Town1", Description = "This is Town1" });
                taskExtendedAttributeText2Definition.AddLookupValue(new Value { Id = 2, StringValue = "Town2", Description = "This is Town2" });

                // Add it to the project's Extended Attributes collection
                project.ExtendedAttributes.Add(taskExtendedAttributeText2Definition);

                var task2 = project.RootTask.Children.Add("Task 2");

                // Crate an Extended Attribute from the Text2 Lookup Definition for Id 1
                var taskExtendedAttributeText2 = taskExtendedAttributeText2Definition.CreateExtendedAttribute(taskExtendedAttributeText2Definition.ValueList[1]);

                // Add the Extended Attribute to task
                task2.ExtendedAttributes.Add(taskExtendedAttributeText2);

                // Create an Extended Attribute Definition of Duration2 type
                var taskExtendedAttributeDuration2Definition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(
                    CustomFieldType.Duration,
                    ExtendedAttributeTask.Duration2,
                    "Some duration");

                // Add lookup values for extended attribute definition
                taskExtendedAttributeDuration2Definition.AddLookupValue(
                    new Value { Id = 3, Duration = project.GetDuration(4, TimeUnitType.Hour), Description = "4 hours" });
                taskExtendedAttributeDuration2Definition.AddLookupValue(new Value { Id = 4, Duration = project.GetDuration(1, TimeUnitType.Day), Description = "1 day" });
                taskExtendedAttributeDuration2Definition.AddLookupValue(
                    new Value { Id = 5, Duration = project.GetDuration(1, TimeUnitType.Hour), Description = "1 hour" });
                taskExtendedAttributeDuration2Definition.AddLookupValue(
                    new Value { Id = 6, Duration = project.GetDuration(10, TimeUnitType.Day), Description = "10 days" });

                // Add the definition to the project's Extended Attributes collection
                project.ExtendedAttributes.Add(taskExtendedAttributeDuration2Definition);

                var task3 = project.RootTask.Children.Add("Task 3");

                // Create an Extended Attribute from the Duration2 Lookup Definition for Id 3
                var taskExtendedAttributeDuration2 =
                    taskExtendedAttributeDuration2Definition.CreateExtendedAttribute(taskExtendedAttributeDuration2Definition.ValueList[3]);

                // Add the Extended Attribute to task
                task3.ExtendedAttributes.Add(taskExtendedAttributeDuration2);

                // Create an Extended Attribute Definition of Finish2 Type
                var taskExtendedAttributeFinish2Definition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(
                    CustomFieldType.Finish,
                    ExtendedAttributeTask.Finish2,
                    "Some finish");

                // Add lookup values for extended attribute definition
                taskExtendedAttributeFinish2Definition.AddLookupValue(
                    new Value { Id = 7, DateTimeValue = new DateTime(1984, 01, 01, 00, 00, 01), Description = "This is Value2" });
                taskExtendedAttributeFinish2Definition.AddLookupValue(
                    new Value { Id = 8, DateTimeValue = new DateTime(1994, 01, 01, 00, 01, 01), Description = "This is Value3" });
                taskExtendedAttributeFinish2Definition.AddLookupValue(
                    new Value { Id = 9, DateTimeValue = new DateTime(2009, 12, 31, 00, 00, 00), Description = "This is Value4" });
                taskExtendedAttributeFinish2Definition.AddLookupValue(new Value { Id = 10, DateTimeValue = DateTime.Now, Description = "This is Value6" });

                // Add the definition to the project's Extended Attributes collection
                project.ExtendedAttributes.Add(taskExtendedAttributeFinish2Definition);

                var task4 = project.RootTask.Children.Add("Task 4");

                // Create an Extended Attribute from the Finish2 Lookup Definition for Id 3
                var taskExtendedAttributeFinish2 = taskExtendedAttributeFinish2Definition.CreateExtendedAttribute(taskExtendedAttributeFinish2Definition.ValueList[3]);

                // Add the Extended Attribute to task
                task4.ExtendedAttributes.Add(taskExtendedAttributeFinish2);

                var collector = new ChildTasksCollector();
                TaskUtils.Apply(project.RootTask, collector, 0);

                // Read extended attributes for tasks
                foreach (var task in collector.Tasks)
                {
                    foreach (var attribute in task.ExtendedAttributes)
                    {
                        Console.WriteLine(attribute.FieldId);
                        Console.WriteLine(attribute.ValueGuid);

                        switch (attribute.AttributeDefinition.CfType)
                        {
                            case CustomFieldType.Date:
                            case CustomFieldType.Start:
                            case CustomFieldType.Finish:
                                Console.WriteLine(attribute.DateValue);
                                break;
                            case CustomFieldType.Text:
                                Console.WriteLine(attribute.TextValue);
                                break;
                            case CustomFieldType.Duration:
                                Console.WriteLine(attribute.DurationValue.ToString());
                                break;
                            case CustomFieldType.Cost:
                            case CustomFieldType.Number:
                                Console.WriteLine(attribute.NumericValue);
                                break;
                            case CustomFieldType.Flag:
                                Console.WriteLine(attribute.FlagValue);
                                break;
                            case CustomFieldType.Null:
                            case CustomFieldType.RBS:
                            case CustomFieldType.OutlineCode:
                                return;
                            default:
                                return;
                        }
                    }
                }

                project.Save(OutDir + "ReadWriteTaskExtendedAttributes_out.mpp", SaveFileFormat.MPP);

                // ExEnd:ReadWriteTaskExtendedAttributes
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public void IterateOverTaskAssignments()
        {
            // ExStart:IterateOverTaskAssignments
            // ExFor: Task.Assignments
            // ExFor: Task.Equals(Task)
            // ExFor: Task.Equals(Object)
            // ExSummary: Shows how to iterate over task's assignments.
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

            // ExEnd:IterateOverTaskAssignments
        }

        [Test]
        public void ReadTaskBaselines()
        {
            // ExStart:ReadTaskBaselines
            // ExFor: Task.Baselines
            // ExSummary: Shows how to read task's baselines.
            var project = new Project();

            // set a baseline
            var task = project.RootTask.Children.Add("Task");
            project.SetBaseline(BaselineType.Baseline);

            // Display task baseline duration
            foreach (var baseline in task.Baselines)
            {
                Console.WriteLine("Baseline duration is 1 day: {0}", baseline.Duration.ToString().Equals("1 day"));
                Console.WriteLine("BaselineStart is same as Task Start: {0}", baseline.Start.Equals(task.Get(Tsk.Start)));
                Console.WriteLine("BaselineFinish is same as Task Finish: {0}", baseline.Finish.Equals(task.Get(Tsk.Finish)));
            }

            // ExEnd:ReadTaskBaselines
        }

        [Test]
        public void TaskDeepClone()
        {
            // ExStart:TaskDeepClone
            // ExFor: Task.Clone
            // ExSummary: Shows how to clone a task.
            var project = new Project();

            var originalTask = project.RootTask.Children.Add("Task");
            var cloneTask = (Task)originalTask.Clone();

            Console.WriteLine("Are tasks equal: " + cloneTask.Equals(originalTask));

            // ExEnd:TaskDeepClone
        }

        [Test]
        public void TaskDelete()
        {
            // ExStart:TaskDelete
            // ExFor: Task.Delete
            // ExSummary: Shows how to delete a task.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            Console.WriteLine("Number of tasks: " + project.RootTask.Children.Count);

            // delete a task
            task.Delete();

            Console.WriteLine("Number of tasks: " + project.RootTask.Children.Count);

            // ExEnd:TaskDelete
        }

        [Test]
        public void TaskGetHashCodeTest()
        {
            // ExStart:TaskGetHashCode
            // ExFor: Task.GetHashCode
            // ExSummary: Shows how to get a hash code of a task.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            // the hash code of a task is based on task's uid and name
            Console.WriteLine("Hash code of the task: " + task.GetHashCode());

            task.Set(Tsk.Name, "Task 1");

            Console.WriteLine("Hash code of the task: " + task.GetHashCode());

            // ExEnd:TaskGetHashCodeTest
        }

        [Test]
        public void TaskGetTimephasedDataTest()
        {
            var project = new Project();
            var task1 = project.RootTask.Children.Add("Task");
            task1.Set(Tsk.Start, new DateTime(2020, 4, 1, 8, 0, 0));
            task1.Set(Tsk.Duration, project.GetDuration(1));
            task1.Set(Tsk.Finish, new DateTime(2020, 4, 1, 17, 0, 0));

            // ExStart:TaskGetTimephasedData
            // ExFor: Task.GetTimephasedData(DateTime,DateTime)
            // ExSummary: Shows how to get timephased data (with TaskWork type) of the task.
            var task = project.RootTask.Children.GetById(1);

            List<TimephasedData> data = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate)).ToList();
            foreach (var td in data)
            {
                Console.WriteLine("Start: " + td.Start);
                Console.WriteLine("Finish: " + td.Finish);
                Console.WriteLine("Type: " + td.TimephasedDataType);
            }

            // ExEnd:TaskGetTimephasedData
        }

        [Test]
        public void TaskGetTimephasedDataTest2()
        {
            // ExStart:TaskGetSpecificTimephasedData
            // ExFor: Task.GetTimephasedData(DateTime,DateTime,TimephasedDataType)
            // ExSummary: Shows how to get timephased data (with specific type) of the task.
            var project = new Project(DataDir + "BaselineTD2010_3.mpp");
            var task = project.RootTask.Children.GetById(1);

            List<TimephasedData> data = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate).AddDays(2), TimephasedDataType.TaskBaselineWork)
                .ToList();
            foreach (var td in data)
            {
                Console.WriteLine("Start: " + td.Start);
                Console.WriteLine("Finish: " + td.Finish);
                Console.WriteLine("Type: " + td.TimephasedDataType);
            }

            // ExEnd:TaskGetSpecificTimephasedData
        }

        [Test]
        public void TaskOutlineCodeTest()
        {
            // ExStart:TaskOutlineCode
            // ExFor: Task.OutlineCodes
            // ExSummary: Show how to read task's outline code values.
            var project = new Project(DataDir + "OutlineCodes2003.mpp");
            var mapping = new Dictionary<string, OutlineValueCollection>();

            // ReSharper disable once LoopCanBeConvertedToQuery //ExSkip
            foreach (var code in project.OutlineCodes)
            {
                mapping.Add(code.FieldId, code.Values);
            }

            var task = project.RootTask.Children.GetById(2);
            foreach (var code in task.OutlineCodes)
            {
                var val = GetOutlineValue(mapping[code.FieldId], code.ValueId);
                Console.WriteLine("Outline value: " + val);
            }
        }

        public static object GetOutlineValue(OutlineValueCollection collection, int valueId)
        {
            object obj = null;

            // ReSharper disable once LoopCanBeConvertedToQuery //ExSkip
            foreach (var value in collection)
            {
                if (value.ValueId != valueId)
                {
                    continue;
                }

                obj = value.Value;
                break;
            }

            return obj;
        }

        // ExEnd:TaskOutlineCode
        [Test]
        public void TaskOutlineIndent()
        {
            // ExStart
            // ExFor: Task.OutlineIndent
            // ExSummary: Shows how to indent a task.
            var project = new Project();
            var task1 = project.RootTask.Children.Add("Parent");
            var task2 = project.RootTask.Children.Add("Task");
            Console.WriteLine("Outline Level: " + task1.Get(Tsk.OutlineLevel));
            Console.WriteLine("Outline Level: " + task2.Get(Tsk.OutlineLevel));
            Console.WriteLine(); // ExSkip

            // indent the task
            task2.OutlineIndent();

            Console.WriteLine("Outline Level: " + task1.Get(Tsk.OutlineLevel));
            Console.WriteLine("Outline Level: " + task2.Get(Tsk.OutlineLevel));

            // ExEnd
        }

        [Test]
        public void TaskOutlineOutdent()
        {
            // ExStart
            // ExFor: Task.OutlineOutdent
            // ExSummary: Shows how to outdent a task.
            var project = new Project();
            var task1 = project.RootTask.Children.Add("Parent");
            var task2 = task1.Children.Add("Task");
            Console.WriteLine("Outline Level: " + task1.Get(Tsk.OutlineLevel));
            Console.WriteLine("Outline Level: " + task2.Get(Tsk.OutlineLevel));
            Console.WriteLine(); // ExSkip

            // outdent the task
            task2.OutlineOutdent();

            Console.WriteLine("Outline Level: " + task1.Get(Tsk.OutlineLevel));
            Console.WriteLine("Outline Level: " + task2.Get(Tsk.OutlineLevel));

            // ExEnd
        }

        [Test]
        public void TaskParentProject()
        {
            // ExStart
            // ExFor: Task.ParentProject
            // ExSummary: Shows how to use parent project of task.
            var project = new Project();
            var task = project.RootTask.Children.Add("Parent");

            // set a duration for the task by using default project time unit type.
            task.Set(Tsk.Duration, task.ParentProject.GetDuration(1));

            Console.WriteLine(task.Get(Tsk.Duration));

            // ExEnd
        }

        [Test]
        public void TaskParentTask()
        {
            // ExStart
            // ExFor: Task.ParentTask
            // ExSummary: Shows how to use the parent task of a task.
            var project = new Project();
            var parent = project.RootTask.Children.Add("Parent");
            var child1 = parent.Children.Add("Child1");
            var child2 = child1.ParentTask.Children.Add("Child2");

            Console.WriteLine("Is parent is equal to the root task: " + child2.ParentTask.Equals(parent));

            // ExEnd
        }

        [Test]
        public void GetTaskPredecessors()
        {
            // ExStart
            // ExFor: Task.Predecessors
            // ExSummary: Shows how to read task's predecessors.
            var project = new Project();
            var pred = project.RootTask.Children.Add("Predecessor");
            var succ = project.RootTask.Children.Add("Successor");

            project.TaskLinks.Add(pred, succ);

            foreach (var predecessor in succ.Predecessors)
            {
                Console.WriteLine("{0} {1}", predecessor.Get(Tsk.Id), predecessor.Get(Tsk.Name));
            }

            // ExEnd
        }

        [Test]
        public void GetTaskSuccessors()
        {
            // ExStart
            // ExFor: Task.Successors
            // ExSummary: Shows how to read task's successors.
            var project = new Project();
            var pred = project.RootTask.Children.Add("Predecessor");
            var succ = project.RootTask.Children.Add("Successor");

            project.TaskLinks.Add(pred, succ);

            foreach (var successor in pred.Successors)
            {
                Console.WriteLine("{0} {1}", successor.Get(Tsk.Id), successor.Get(Tsk.Name));
            }

            // ExEnd
        }

        [Test]
        public void GetTaskRecurringInfo()
        {
            // ExStart
            // ExFor: Task.RecurringInfo
            // ExSummary: Shows how to read task's recurring info.
            var project = new Project(DataDir + "TestRecurringTask2016.mpp");

            var task = project.RootTask.Children.GetById(1);

            Console.WriteLine("Recurrence Pattern: " + task.RecurringInfo.RecurrencePattern);
            Console.WriteLine("Start Date: " + task.RecurringInfo.StartDate);
            Console.WriteLine("End Date: " + task.RecurringInfo.EndDate);
            Console.WriteLine("Duration: " + task.RecurringInfo.Duration);
            Console.WriteLine("Occurrences: " + task.RecurringInfo.Occurrences);
            Console.WriteLine("Weekly Days: " + task.RecurringInfo.WeeklyDays);
            Console.WriteLine("WeeklyRepetitions: " + task.RecurringInfo.WeeklyRepetitions);

            // ExEnd
        }

        [Test]
        public void GetTaskSelectAllChildTasks()
        {
            // ExStart
            // ExFor: Task.SelectAllChildTasks
            // ExSummary: Shows how to iterate over child tasks.
            var project = new Project();
            var task = project.RootTask.Children.Add("Task 1");
            task.Children.Add("Task 2");

            foreach (var tsk in project.RootTask.SelectAllChildTasks())
            {
                Console.WriteLine("{0} {1}", tsk.Get(Tsk.Id), tsk.Get(Tsk.Name));
            }

            // ExEnd
        }

        [Test]
        public void GetTaskTimephasedData()
        {
            // ExStart
            // ExFor: Task.TimephasedData
            // ExSummary: Shows how to iterate over task's timephased data.
            var project = new Project(DataDir + "BaselineTD2010_3.mpp");
            var task = project.RootTask.Children.GetById(1);

            foreach (var td in task.TimephasedData)
            {
                Console.WriteLine("Start: " + td.Start);
                Console.WriteLine("Finish: " + td.Finish);
                Console.WriteLine("Type: " + td.TimephasedDataType);
            }

            // ExEnd
        }

        [Test]
        public void CreateTasks()
        {
            try
            {
                // ExStart:CreateTasks
                // ExFor: Task.Children
                // ExSummary: Shows how to use task collection to add a task.
                var project = new Project();

                // Add task, sub task and save project
                var task = project.RootTask.Children.Add("Summary1");
                task.Children.Add("Subtask1");
                project.Save(OutDir + "CreateTasks_out.xml", SaveFileFormat.XML);

                // ExEnd:CreateTasks
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        // ExStart:SortTasksByName
        // ExFor: Task.ToString
        // ExSummary: Shows how to sort tasks by name.
        [Test] // ExSkip
        public void SortTasksByName()
        {
            var project = new Project(DataDir + "project-sort.mpp");
            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);
            List<Task> tasks = collector.Tasks;

            tasks.Sort(new TaskNameComparer());

            foreach (var task in tasks)
            {
                Console.WriteLine(task.ToString());
            }
        }

        private class TaskNameComparer : IComparer<Task>
        {
            public int Compare(Task x, Task y)
            {
                if (x == null && y == null)
                {
                    return 0;
                }

                if (x == null)
                {
                    return -1;
                }

                if (y == null)
                {
                    return 1;
                }

                if (string.IsNullOrEmpty(x.Get(Tsk.Name)))
                {
                    return 1;
                }

                if (string.IsNullOrEmpty(y.Get(Tsk.Name)))
                {
                    return -1;
                }

                return string.Compare(x.Get(Tsk.Name), y.Get(Tsk.Name), StringComparison.Ordinal);
            }
        }

        // ExEnd:SortTasksByName
    }
}