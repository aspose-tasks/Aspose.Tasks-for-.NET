namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;
    using Util;

    [TestFixture]
    public class ExResource : ApiExampleBase
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

                project.Save(OutDir + "CreateResourcesAndLinkToTasks_out.mpp", SaveFileFormat.MPP);
                //ExEnd:CreateResourcesAndLinkToTasks
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void WriteMetadataToMpp()
        {
            try
            {
                //ExStart:WriteMetadataToMpp
                //ExFor: Rsc.EMailAddress
                //ExFor: Rsc.WindowsUserAccount
                //ExSummary: Shows how to prepare and save project with metadata were set for main entities (Tasks, Resources, Assignments).
                var project = new Project(DataDir + "Project.mpp");

                // Add working times to project calendar
                var wt = new WorkingTime();
                wt.FromTime = new DateTime(2010, 1, 1, 19, 0, 0);
                wt.ToTime = new DateTime(2010, 1, 1, 20, 0, 0);
                var day = project.Get(Prj.Calendar).WeekDays.ToList()[1];
                day.WorkingTimes.Add(wt);

                // Change calendar name
                project.Get(Prj.Calendar).Name = "CHANGED NAME!";

                // Add tasks and set task meta data
                var task = project.RootTask.Children.Add("Task 1");
                task.Set(Tsk.DurationFormat, TimeUnitType.Day);
                task.Set(Tsk.Duration, project.GetDuration(3));
                task.Set(Tsk.Contact, "Rsc 1");
                task.Set(Tsk.IsMarked, true);
                task.Set(Tsk.IgnoreWarnings, true);
                var task2 = project.RootTask.Children.Add("Task 2");
                task2.Set(Tsk.DurationFormat, TimeUnitType.Day);
                task2.Set(Tsk.Contact, "Rsc 2");

                // Link tasks
                project.TaskLinks.Add(task, task2, TaskLinkType.FinishToStart, project.GetDuration(-1, TimeUnitType.Day));

                // Set project start date
                project.Set(Prj.StartDate, new DateTime(2013, 8, 13, 9, 0, 0));

                // Add resource and set resource meta data
                var rsc1 = project.Resources.Add("Rsc 1");
                rsc1.Set(Rsc.Type, ResourceType.Work);
                rsc1.Set(Rsc.Initials, "WR");
                rsc1.Set(Rsc.AccrueAt, CostAccrualType.Prorated);
                rsc1.Set(Rsc.MaxUnits, 1);
                rsc1.Set(Rsc.Code, "Code 1");
                rsc1.Set(Rsc.Group, "Workers");
                rsc1.Set(Rsc.EMailAddress, "1@gmail.com");
                rsc1.Set(Rsc.WindowsUserAccount, "user_acc1");
                rsc1.Set(Rsc.IsGeneric, new NullableBool(true));
                rsc1.Set(Rsc.AccrueAt, CostAccrualType.End);
                rsc1.Set(Rsc.StandardRate, 10);
                rsc1.Set(Rsc.StandardRateFormat, RateFormatType.Day);
                rsc1.Set(Rsc.OvertimeRate, 15);
                rsc1.Set(Rsc.OvertimeRateFormat, RateFormatType.Hour);

                rsc1.Set(Rsc.IsTeamAssignmentPool, true);
                rsc1.Set(Rsc.CostCenter, "Cost Center 1");

                // Create resource assignment and set resource assignment meta data
                var assn = project.ResourceAssignments.Add(task, rsc1);
                assn.Set(Asn.Uid, 1);
                assn.Set(Asn.Work, task.Get(Tsk.Duration));
                assn.Set(Asn.RemainingWork, assn.Get(Asn.Work));
                assn.Set(Asn.RegularWork, assn.Get(Asn.Work));
                task.Set(Tsk.Work, assn.Get(Asn.Work));

                rsc1.Set(Rsc.Work, task.Get(Tsk.Work));
                assn.Set(Asn.Start, task.Get(Tsk.Start));
                assn.Set(Asn.Finish, task.Get(Tsk.Finish));

                // Add extended attribute for project and task
                var attributeDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Flag, ExtendedAttributeTask.Flag1,  "My Flag Field");
                project.ExtendedAttributes.Add(attributeDefinition);

                var attribute = attributeDefinition.CreateExtendedAttribute();
                attribute.FlagValue = true;
                task2.ExtendedAttributes.Add(attribute);

                project.Save(OutDir + "WriteMetaData_out.mpp", SaveFileFormat.MPP);
                //ExEnd:WriteMetadataToMpp
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void CreateResources()
        {
            //ExStart:CreateResources
            //ExFor: Resource
            //ExSummary: Shows how to add project resources.
            var project = new Project();

            // Add resources
            project.Resources.Add("Rsc");

            project.Save(OutDir + "CreateResources_out.xml", SaveFileFormat.XML);
            //ExEnd:CreateResources
        }
        
        [Test]
        public void GetSetResourceCalendar()
        {
            //ExStart:GetSetResourceCalendar
            //ExFor: Rsc.Calendar
            //ExFor: Calendar.BaseCalendar
            //ExSummary: Shows how to get/set resource calendars.
            var project = new Project(DataDir + "ResourceCalendar.mpp");
            var res = project.Resources.Add("Resource1");
            
            // Add standard calendar and assign to resource
            var cal = project.Calendars.Add("Resource1");
            res.Set(Rsc.Calendar, cal);
            
            // Display base calendar name for all resources
            foreach (var resource in project.Resources)
            {
                if (resource.Get(Rsc.Name) != null)
                {
                    Console.WriteLine(resource.Get(Rsc.Calendar).BaseCalendar.Name);
                }
            }
            //ExEnd:GetSetResourceCalendar
        }
        
        [Test]
        public void GetResourceCosts()
        {
            //ExStart:GetResourceCosts
            //ExFor: Rsc.Cost
            //ExFor: Rsc.ACWP
            //ExFor: Rsc.BCWS
            //ExFor: Rsc.BCWP
            //ExSummary: Shows how to read resource costs.
            var project = new Project(DataDir + "ResourceCosts.mpp");

            // Display all resources costs
            foreach (var res in project.Resources)
            {
                if (res.Get(Rsc.Name) == null)
                {
                    continue;
                }

                Console.WriteLine(res.Get(Rsc.Cost));
                Console.WriteLine(res.Get(Rsc.ACWP));
                Console.WriteLine(res.Get(Rsc.BCWS));
                Console.WriteLine(res.Get(Rsc.BCWP));
            }
            //ExEnd:GetResourceCosts
        }
        
        [Test]
        public void GetResourceOvertime()
        {
            //ExStart:GetResourceOvertime
            //ExFor: Rsc.OvertimeCost
            //ExFor: Rsc.OvertimeWork
            //ExFor: Rsc.OvertimeRateFormat
            //ExSummary: Shows how to read resource overtime values.
            var project = new Project(DataDir + "ResourceOvertime.mpp");

            // Display overtime related parameters for all resources
            foreach (var res in project.Resources)
            {
                if (res.Get(Rsc.Name) == null)
                {
                    continue;
                }

                Console.WriteLine(res.Get(Rsc.OvertimeCost));
                Console.WriteLine(res.Get(Rsc.OvertimeWork).ToString());
                Console.WriteLine(res.Get(Rsc.OvertimeRateFormat).ToString());
            }
            //ExEnd:GetResourceOvertime
        }
        
        [Test]
        public void GetResourcePercentWorkComplete()
        {
            //ExStart:GetResourcePercentWorkComplete
            //ExFor: Rsc.PercentWorkComplete
            //ExSummary: Shows how to read resource percent work complete.
            var project = new Project(DataDir + "ResourcePercentWorkComplete.mpp");

            // Display work percentage completion for all resources
            foreach (var res in project.Resources)
            {
                if (res.Get(Rsc.Name) != null)
                {
                    Console.WriteLine(res.Get(Rsc.PercentWorkComplete));
                }
            }
            //ExEnd:GetResourcePercentWorkComplete
        }
        
        [Test]
        public void GetResourceWorkVariance()
        {
            //ExStart:GetResourceWorkVariance
            //ExFor: Rsc.WorkVariance
            //ExSummary: Shows how to read resource work variance.
            var project = new Project(DataDir + "WorkVariance.mpp");

            foreach (var assignment in project.ResourceAssignments)
            {
                var resource = assignment.Get(Asn.Resource);

                var workVariance = resource.Get(Rsc.WorkVariance);

                Console.WriteLine(workVariance);
            }
            //ExEnd:GetResourceWorkVariance
        }
        
        [Test]
        public void ReadResourceTimephasedData()
        {
            //ExStart:ReadResourceTimephasedData
            //ExFor: Resource.GetTimephasedData(DateTime,DateTime)
            //ExFor: Resource.GetTimephasedData(DateTime,DateTime,TimephasedDataType)
            //ExSummary: Shows how to read timephased data of work/cost resources.
            var project = new Project(DataDir + "ResourceTimephasedData.mpp");

            // Get the Resource by its ID
            var resource = project.Resources.GetByUid(1);

            // Print Timephased data of ResourceWork
            Console.WriteLine("Timephased data of ResourceWork");
            foreach (var td in resource.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate)))
            {
                Console.Write("Start: " + td.Start.ToShortDateString());
                Console.WriteLine(" Work: " + td.Value);
            }

            // Print Timephased data of ResourceCost
            Console.WriteLine("Timephased data of ResourceCost");
            foreach (var td in resource.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate), TimephasedDataType.ResourceCost))
            {
                Console.Write("Start: " + td.Start.ToShortDateString());
                Console.WriteLine(" Cost: " + td.Value);
            }
            //ExEnd:ReadResourceTimephasedData
        }
        
        [Test]
        public void SetGeneralResourceProperties()
        {
            try
            {
                //ExStart:UpdateResourceDataInMpp
                //ExFor: Rsc.StandardRate
                //ExFor: Rsc.OvertimeRate
                //ExFor: Rsc.Group
                //ExSummary: Shows how to update common resource data.
                var project = new Project(DataDir + "UpdateResourceData.mpp");

                // Add resource and set some properties
                var resource = project.Resources.Add("Rsc");
                resource.Set(Rsc.StandardRate, 30);
                resource.Set(Rsc.OvertimeRate, 45);
                resource.Set(Rsc.Group, "Workgroup1");

                project.Save(OutDir + "UpdateResourceData_out.mpp", SaveFileFormat.MPP);
                //ExEnd:UpdateResourceDataInMpp
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void SetResourceExtendedAttributes()
        {
            try
            {
                //ExStart:SetResourceExtendedAttributes
                //ExFor: Resource.ExtendedAttributes
                //ExSummary: Shows how to add resource extended attributes.
                var project = new Project(DataDir + "ResourceExtendedAttributes.mpp");

                // Define extended attribute
                var definition = project.ExtendedAttributes.GetById((int)ExtendedAttributeTask.Number1);
                if (definition == null)
                {
                    definition = ExtendedAttributeDefinition.CreateResourceDefinition(ExtendedAttributeResource.Number1, "Age");
                    project.ExtendedAttributes.Add(definition);
                }

                // Create extended attribute and set its value
                var attribute = definition.CreateExtendedAttribute();
                attribute.NumericValue = 30.5345m;

                // Add a new resource and its extended attribute   
                var resource = project.Resources.Add("R1");
                resource.ExtendedAttributes.Add(attribute);

                project.Save(OutDir + "ResourceExtendedAttributes_out.mpp", SaveFileFormat.MPP);
                //ExEnd:SetResourceExtendedAttributes
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void ReadBudgetWorkAndCost()
        {
            //ExStart:ReadBudgetWorkAndCost
            //ExFor: Rsc.BudgetWork
            //ExFor: Rsc.BudgetCost
            //ExSummary: Shows how to read budget work/cost values of a resource.
            var project = new Project(DataDir + "BudgetWorkAndCost.mpp");

            // Display budget work and budget cost for project summary task
            Console.WriteLine("projSummary.BudgetWork = " + project.RootTask.Get(Tsk.BudgetWork));
            Console.WriteLine("projSummary.BudgetCost = " + project.RootTask.Get(Tsk.BudgetCost));

            // Display resource budget work
            var rsc = project.Resources.GetByUid(6);            
            Console.WriteLine("Resource BudgetWork = " + rsc.Get(Rsc.BudgetWork));

            // Display resource budget cost
            rsc = project.Resources.GetByUid(7);
            Console.WriteLine("Resource BudgetCost = " + rsc.Get(Rsc.BudgetCost));

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);
            foreach (var task in collector.Tasks)
            {
                // Display assignment budget work and budget cost
                foreach (var assignment in task.Assignments)
                {
                    var resource = assignment.Get(Asn.Resource);
                    if (resource == null)
                    {
                        continue;
                    }

                    if (resource.Get(Rsc.Type) == ResourceType.Work)
                    {
                        Console.WriteLine("Assignment BudgetWork = " + assignment.Get(Asn.BudgetWork));
                    }
                    else
                    {
                        Console.WriteLine("Assignment BudgetCost = " + assignment.Get(Asn.BudgetCost));
                    }
                }
            }
            //ExEnd:ReadBudgetWorkAndCost
        }
    }
}