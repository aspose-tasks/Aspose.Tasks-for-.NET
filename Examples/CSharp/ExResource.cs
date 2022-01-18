namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExResource : ApiExampleBase
    {
        [Test]
        public void CreateResources()
        {
            // ExStart:CreateResources
            // ExFor: Resource
            // ExSummary: Shows how to add project resources.
            var project = new Project();

            // Add resources
            project.Resources.Add("Resource");

            project.Save(OutDir + "CreateResources_out.xml", SaveFileFormat.Xml);

            // ExEnd:CreateResources
        }

        [Test]
        public void ReadResourceTimephasedData()
        {
            // ExStart:ReadResourceTimephasedData
            // ExFor: Resource.GetTimephasedData(DateTime,DateTime)
            // ExFor: Resource.GetTimephasedData(DateTime,DateTime,TimephasedDataType)
            // ExSummary: Shows how to read timephased data of work/cost resources.
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

            // ExEnd:ReadResourceTimephasedData
        }

        [Test]
        public void ReadWriteGeneralResourceProperties()
        {
            try
            {
                // ExStart:ReadWriteGeneralResourceProperties
                // ExFor: Resource.Get``1(Aspose.Tasks.Key{``0,Aspose.Tasks.RscKey})
                // ExFor: Resource.Set(Key{System.DateTime,Aspose.Tasks.RscKey},System.DateTime)
                // ExFor: Resource.Set``1(Aspose.Tasks.Key{``0,Aspose.Tasks.RscKey},``0)
                // ExSummary: Shows how to read/write common resource properties.
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

                project.Save(OutDir + "UpdateResourceData_out.mpp", SaveFileFormat.Mpp);

                // ExEnd:ReadWriteGeneralResourceProperties
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void SetResourceExtendedAttributes()
        {
            try
            {
                // ExStart:SetResourceExtendedAttributes
                // ExFor: Resource.ExtendedAttributes
                // ExSummary: Shows how to add resource extended attributes.
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

                project.Save(OutDir + "ResourceExtendedAttributes_out.mpp", SaveFileFormat.Mpp);

                // ExEnd:SetResourceExtendedAttributes
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public void ReadAssignmentsOfResource()
        {
            // ExStart:ReadBudgetWorkAndCost
            // ExFor: Resource.Assignments
            // ExSummary: Shows how to read assignments of a resource.
            var project = new Project(DataDir + "BudgetWorkAndCost.mpp");

            foreach (var resource in project.Resources)
            {
                foreach (var assignment in resource.Assignments)
                {
                    Console.WriteLine("Assignment UID: " + assignment.Get(Asn.Uid));
                    Console.WriteLine("Assignment's task name: " + assignment.Get(Asn.Task).Get(Tsk.Name));
                }
            }

            // ExEnd:ReadBudgetWorkAndCost
        }

        [Test]
        public void ResourceAvailabilityPeriods()
        {
            // ExStart
            // ExFor: Resource.AvailabilityPeriods
            // ExSummary: Shows how to add availability period for a resource.
            var project = new Project();
            var resource = project.Resources.Add("Resource");

            var availabilityPeriod = new AvailabilityPeriod
            {
                AvailableFrom = new DateTime(2020, 4, 1, 8, 0, 0),
                AvailableTo = new DateTime(2020, 4, 1, 17, 0, 0),
                AvailableUnits = 2d
            };
            resource.AvailabilityPeriods.Add(availabilityPeriod);

            var availabilityPeriod2 = new AvailabilityPeriod
            {
                AvailableFrom = new DateTime(2020, 4, 2, 8, 0, 0),
                AvailableTo = new DateTime(2020, 4, 2, 17, 0, 0),
                AvailableUnits = 3d
            };
            resource.AvailabilityPeriods.Add(availabilityPeriod2);

            // ExEnd
        }

        [Test]
        public void ReadResourceBaselines()
        {
            // ExStart
            // ExFor: Resource.Baselines
            // ExSummary: Shows how to read resource's baselines.
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

            // ExEnd
        }

        [Test]
        public void DeleteResource()
        {
            // ExStart
            // ExFor: Resource.Delete
            // ExSummary: Shows how to delete a resource.
            var project = new Project(DataDir + "Baselines2010.mpp");

            var resource = project.Resources.GetById(1);

            Console.WriteLine("Number of resources (before): " + project.Resources.Count);

            // delete the resource
            resource.Delete();

            Console.WriteLine("Number of resources (after): " + project.Resources.Count);

            // ExEnd
        }

        [Test]
        public void ResourceEquals()
        {
            // ExStart
            // ExFor: Resource.Equals(Resource)
            // ExFor: Resource.Equals(Object)
            // ExSummary: Shows how to check resource equality.
            var project = new Project(DataDir + "Baselines2010.mpp");

            var resource1 = project.Resources.GetById(1);
            var resource2 = project.Resources.GetById(1);

            Console.WriteLine("Are resources equal: " + resource1.Equals(resource2));

            // ExEnd
        }

        [Test]
        public void GetResourceHashCode()
        {
            // ExStart
            // ExFor: Resource.GetHashCode()
            // ExSummary: Shows how to get a hash code of a resource.
            var project = new Project(DataDir + "Project.mpp");

            var resource1 = project.Resources.GetById(1);
            var resource2 = project.Resources.GetById(2);

            // the hash code of a resource is equal to resource UID 
            Console.WriteLine("Resource UID: {0} Hash Code: {1}", resource1.Get(Rsc.Uid), resource1.GetHashCode());
            Console.WriteLine("Resource UID: {0} Hash Code: {1}", resource2.Get(Rsc.Uid), resource2.GetHashCode());

            // ExEnd
        }

        [Test]
        public void GetResourceOutlineCode()
        {
            // ExStart:GetResourceOutlineCode
            // ExFor: Resource.OutlineCode
            // ExSummary: Shows how to work with resource outline values.
            var project = new Project(DataDir + "OutlineCodes2003.mpp");

            var res = project.Resources.GetById(2);
            Assert.AreEqual(2, res.OutlineCode.Count);
            foreach (var code in res.OutlineCode)
            {
                object val = null;
                foreach (var def in project.OutlineCodes)
                {
                    if (def.FieldId != code.FieldId)
                    {
                        continue;
                    }

                    foreach (var value in def.Values)
                    {
                        if (value.ValueId != code.ValueId)
                        {
                            continue;
                        }

                        val = value.Value;
                        break;
                    }
                }

                Assert.NotNull(val); // ExSkip
                Console.WriteLine(val.ToString());
            }

            // ExEnd:GetResourceOutlineCode
        }

        [Test]
        public void ResourceParentProject()
        {
            // ExStart
            // ExFor: Resource.ParentProject
            // ExSummary: Shows how to use parent project of resource.
            var project = new Project();
            var resource = project.Resources.Add("Resource");

            // set a work for the resource by using default project work time unit type.
            resource.Set(Rsc.Work, resource.ParentProject.GetWork(1));

            Console.WriteLine(resource.Get(Rsc.Work));

            // ExEnd
        }

        [Test]
        public void ResourceToString()
        {
            // ExStart
            // ExFor: Resource.ToString
            // ExSummary: Shows how to use resource ToString method.
            var project = new Project();
            var resource = project.Resources.Add("Resource");

            // print resource common information
            Console.WriteLine(resource.ToString());

            // ExEnd
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

            // ExStart
            // ExFor: Resource.TimephasedData
            // ExSummary: Shows how to read resource timephased data.
            resource.Set(Rsc.Work, resource.ParentProject.GetWork(2));

            project.SetBaseline(BaselineType.Baseline);

            // iterate over timephased data of the resource 
            foreach (var td in resource.TimephasedData)
            {
                Console.WriteLine(td.Start);
                Console.WriteLine(td.Finish);
            }

            // ExEnd
        }

        [Test]
        public void ReadResourceRates()
        {
            // ExStart
            // ExFor: Resource.Rates
            // ExSummary: Shows how to read resource rates.
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

            // ExEnd
        }
    }
}