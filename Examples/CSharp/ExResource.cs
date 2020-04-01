namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
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

                // add new resources
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
        public void ReadWriteGeneralResourceProperties()
        {
            try
            {
                //ExStart:ReadWriteGeneralResourceProperties
                //ExFor: Resource.Get``1(Aspose.Tasks.Key{``0,Aspose.Tasks.RscKey})
                //ExFor: Resource.Set(Key{System.DateTime,Aspose.Tasks.RscKey},System.DateTime)
                //ExFor: Resource.Set``1(Aspose.Tasks.Key{``0,Aspose.Tasks.RscKey},``0)
                //ExFor: Rsc.StandardRate
                //ExFor: Rsc.OvertimeRate
                //ExFor: Rsc.Group
                //ExSummary: Shows how to read/write common resource properties.
                var project = new Project(DataDir + "UpdateResourceData.mpp");

                // Add resource and set some properties
                var resource = project.Resources.Add("Rsc");
                resource.Set(Rsc.Start, new DateTime(2020, 4, 1, 8, 0, 0));
                resource.Set(Rsc.StandardRate, 30);
                resource.Set(Rsc.OvertimeRate, 45);
                resource.Set(Rsc.Group, "Workgroup1");

                Console.WriteLine("Resource Start: " + resource.Get(Rsc.Start));
                Console.WriteLine("Resource Standard Rate: " + resource.Get(Rsc.StandardRate));
                Console.WriteLine("Resource Overtime Rate: " + resource.Get(Rsc.OvertimeRate));
                Console.WriteLine("Resource Group: " + resource.Get(Rsc.Group));

                project.Save(OutDir + "UpdateResourceData_out.mpp", SaveFileFormat.MPP);
                //ExEnd:ReadWriteGeneralResourceProperties
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
        
        [Test]
        public void ReadAssignmentsOfResource()
        {
            //ExStart:ReadBudgetWorkAndCost
            //ExFor: Resource.Assignments
            //ExSummary: Shows how to read assignments of a resource.
            var project = new Project(DataDir + "BudgetWorkAndCost.mpp");

            foreach (var resource in project.Resources)
            {
                foreach (var assignment in resource.Assignments)
                {
                    Console.WriteLine("Assignment UID: " + assignment.Get(Asn.Uid));
                    Console.WriteLine("Assignment's task name: " + assignment.Get(Asn.Task).Get(Tsk.Name));
                }
            }
            //ExEnd:ReadBudgetWorkAndCost
        }

        [Test]
        public void ResourceAvailabilityPeriods()
        {
            //ExStart
            //ExFor: Resource.AvailabilityPeriods
            //ExSummary: Shows how to add availability period for a resource.
            var project = new Project();
            var resource = project.Resources.Add("Resource");

            var availabilityPeriod = new AvailabilityPeriod();
            availabilityPeriod.AvailableFrom = new DateTime(2020, 4, 1, 8, 0, 0);
            availabilityPeriod.AvailableTo = new DateTime(2020, 4, 1, 17, 0, 0);
            availabilityPeriod.AvailableUnits = 2d;
            resource.AvailabilityPeriods.Add(availabilityPeriod);
            
            var availabilityPeriod2 = new AvailabilityPeriod();
            availabilityPeriod2.AvailableFrom = new DateTime(2020, 4, 2, 8, 0, 0);
            availabilityPeriod2.AvailableTo = new DateTime(2020, 4, 2, 17, 0, 0);
            availabilityPeriod2.AvailableUnits = 3d;
            resource.AvailabilityPeriods.Add(availabilityPeriod2);
            //ExEnd
        }
        
        [Test]
        public void ReadResourceBaselines()
        {
            //ExStart
            //ExFor: Resource.Baselines
            //ExSummary: Shows how to read resource's baselines.
            var project = new Project(DataDir + "Baselines2010.mpp");

            foreach (var resource in project.Resources)
            {
                foreach (var baseline in resource.Baselines)
                {
                    Console.WriteLine("BaselineNumber: " + baseline.BaselineNumber);
                    Console.WriteLine("Bcwp: " + baseline.Bcwp);
                    Console.WriteLine("Bcws: " + baseline.Bcws);
                    Console.WriteLine("Cost: " + baseline.Cost);
                    Console.WriteLine("Work: " + baseline.Work);
                }
            }
            //ExEnd
        }
        
        [Test]
        public void DeleteResource()
        {
            //ExStart
            //ExFor: Resource.Delete
            //ExSummary: Shows how to delete a resource.
            var project = new Project(DataDir + "Baselines2010.mpp");

            var resource = project.Resources.GetById(1);

            Console.WriteLine("Number of resources (before): " + project.Resources.Count);
            
            // delete the resource
            resource.Delete();
            
            Console.WriteLine("Number of resources (after): " + project.Resources.Count);
            //ExEnd
        }
        
        [Test]
        public void EqualsResource()
        {
            //ExStart
            //ExFor: Resource.Equals(Resource)
            //ExFor: Resource.Equals(Object)
            //ExSummary: Shows how to check resource equality.
            var project = new Project(DataDir + "Baselines2010.mpp");

            var resource1 = project.Resources.GetById(1);
            var resource2 = project.Resources.GetById(1);

            Console.WriteLine("Resources are equal: " + resource1.Equals(resource2));
            //ExEnd
        }
        
        [Test]
        public void GetResourceHashCode()
        {
            //ExStart
            //ExFor: Resource.GetHashCode()
            //ExSummary: Shows how to get a hash code of a resource.
            var project = new Project(DataDir + "Project.mpp");

            var resource1 = project.Resources.GetById(1);
            var resource2 = project.Resources.GetById(2);

            // hash code of a resource is equal to resource UID 
            Console.WriteLine("Resource UID: {0} Hash Code: {0}", resource1.GetHashCode());
            Console.WriteLine("Resource UID: {0} Hash Code: {0}", resource2.GetHashCode());
            //ExEnd
        }
        
        [Test]
        public void GetResourceOutlineCode()
        {
            //ExStart:GetResourceOutlineCode
            //ExFor: Resource.OutlineCode
            //ExSummary: Shows how to work with resource outline values.
            Project project = new Project(DataDir + "OutlineCodes2003.mpp");

            Resource res = project.Resources.GetById(2);
            Assert.AreEqual(2, res.OutlineCode.Count);
            foreach (OutlineCode code in res.OutlineCode)
            {
                object val = null;
                foreach (OutlineCodeDefinition def in project.OutlineCodes)
                {
                    if (def.FieldId != code.FieldId)
                    {
                        continue;
                    }

                    foreach (OutlineValue value in def.Values)
                    {
                        if (value.ValueId != code.ValueId)
                        {
                            continue;
                        }

                        val = value.Value;
                        break;
                    }
                }

                Console.WriteLine(val.ToString());
            }
            //ExEnd:GetResourceOutlineCode
        }
        
        [Test]
        public void ResourceParentProject()
        {
            //ExStart
            //ExFor: Resource.ParentProject
            //ExSummary: Shows how to use parent project of resource.
            var project = new Project();
            var resource = project.Resources.Add("Resource");
            
            // set a work for the resource by using default project work time unit type.
            resource.Set(Rsc.Work, resource.ParentProject.GetWork(1));

            Console.WriteLine(resource.Get(Rsc.Work));
            //ExEnd
        }
        
        [Test]
        public void ResourceToString()
        {
            //ExStart
            //ExFor: Resource.ToString
            //ExSummary: Shows how to use resource ToString method.
            var project = new Project();
            var resource = project.Resources.Add("Resource");

            // print resource common information
            Console.WriteLine(resource.ToString());
            //ExEnd
        }
        
        [Test]
        public void ReadResourceTimephasedData2()
        {
            var project = new Project();
            var task = project.RootTask.Children.Add("Task");
            task.Set(Tsk.Start, new DateTime(2020, 4, 1, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(1));
            task.Set(Tsk.Finish, new DateTime(2020, 4, 1, 17, 0, 0));
            var resource = project.Resources.Add("Resource");
            project.ResourceAssignments.Add(task, resource);
            
            //ExStart
            //ExFor: Resource.TimephasedData
            //ExSummary: Shows how to read resource timephased data.
            resource.Set(Rsc.Work, resource.ParentProject.GetWork(2));
            
            project.SetBaseline(BaselineType.Baseline);
            
            // iterate over timephased data of the resource 
            foreach (var td in resource.TimephasedData)
            {
                Console.WriteLine(td.Start);
                Console.WriteLine(td.Finish);
            }
            //ExEnd
        }
        
        [Test]
        public void ReadResourceRates()
        {
            //ExStart
            //ExFor: Resource.Rates
            //ExSummary: Shows how to read resource rates.
            var project = new Project();
            var resource = project.Resources.Add();
            resource.Set(Rsc.Uid, 1);
            resource.Set(Rsc.Name, "Test Resource 1");
            resource.Set(Rsc.Type, ResourceType.Work);
            resource.Set(Rsc.Work, project.GetDuration(2d, TimeUnitType.Hour));
            resource.Set(Rsc.StandardRate, 20m);

            var rate1 = resource.Rates.Add(new DateTime(2019, 1, 1, 8, 0, 0));
            rate1.RatesTo = new DateTime(2019, 11, 11, 17, 0, 0);
            rate1.StandardRate = 5m;
            rate1.StandardRateFormat = RateFormatType.Hour;

            var rate2 = resource.Rates.Add(new DateTime(2019, 11, 12, 8, 0, 0));
            rate2.RatesTo = new DateTime(2019, 12, 31, 17, 0, 0);
            rate2.StandardRate = 10m;
            rate2.StandardRateFormat = RateFormatType.Hour;
            
            // iterate over rates
            foreach (KeyValuePair<RateType, RateByDateCollection> rate in resource.Rates)
            {
                foreach (KeyValuePair<DateTime, Rate> pair in rate.Value)
                {
                    Console.WriteLine(pair.Value.RatesFrom);
                    Console.WriteLine(pair.Value.RatesTo);
                }
            }
            //ExEnd
        }
    }
}