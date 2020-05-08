namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;
    using Util;

    [TestFixture]
    public class ExAsn : ApiExampleBase
    {
        [Test]
        public void GenerateResourceAssignmentTimephasedData()
        {
            // ExStart:GenerateResourceAssignmentTimephasedData
            // ExFor: Asn.WorkContour
            // ExFor: WorkContourType
            // ExSummary: Shows how to set different timephased data contours for resource assignments.
            var project = new Project();
            project.Set(Prj.StartDate, new DateTime(2000, 1, 3, 8, 0, 0));
            project.Set(Prj.FinishDate, new DateTime(2000, 1, 7, 17, 0, 0));

            // add a task
            var task = project.RootTask.Children.Add("Task");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8, TimeUnitType.Hour));
            task.Set(Tsk.Finish, new DateTime(2000, 1, 3, 17, 0, 0));

            var resource = project.Resources.Add("Resource");

            // add resource assignment
            var resourceAssignment = project.ResourceAssignments.Add(task, resource);
            resourceAssignment.Set(Asn.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            resourceAssignment.Set(Asn.Work, project.GetWork(8));
            resourceAssignment.Set(Asn.Finish, new DateTime(2000, 1, 3, 17, 0, 0));

            // Flat contour is default contour
            Console.WriteLine("Flat contour");

            var collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            Console.WriteLine("Turtle contour");
            resourceAssignment.Set(Asn.WorkContour, WorkContourType.Turtle);
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            Console.WriteLine("BackLoaded contour");
            resourceAssignment.Set(Asn.WorkContour, WorkContourType.BackLoaded);
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            Console.WriteLine("FrontLoaded contour");
            resourceAssignment.Set(Asn.WorkContour, WorkContourType.FrontLoaded);
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            Console.WriteLine("Bell contour");
            resourceAssignment.Set(Asn.WorkContour, WorkContourType.Bell);
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            Console.WriteLine("EarlyPeak contour");
            resourceAssignment.Set(Asn.WorkContour, WorkContourType.EarlyPeak);
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            Console.WriteLine("LatePeak contour");
            resourceAssignment.Set(Asn.WorkContour, WorkContourType.LatePeak);
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            Console.WriteLine("DoublePeak contour");
            resourceAssignment.Set(Asn.WorkContour, WorkContourType.DoublePeak);
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // ExEnd:GenerateResourceAssignmentTimephasedData
        }

        [Test]
        public void GetResourceAssignmentCosts()
        {
            // ExStart:GetResourceAssignmentCosts
            // ExFor: Asn.ACWP
            // ExFor: Asn.BCWP
            // ExFor: Asn.BCWS
            // ExFor: Asn.CV
            // ExFor: Asn.SV
            // ExSummary: Shows how to read assignment's cost values.
            var project = new Project(DataDir + "ResourceAssignmentCosts.mpp");

            // Print resource assignment costs
            foreach (var assignment in project.ResourceAssignments)
            {
                Console.WriteLine(assignment.Get(Asn.Cost));
                Console.WriteLine(assignment.Get(Asn.ACWP));

                // CV = BCWP - ACWP
                Console.WriteLine(assignment.Get(Asn.CV));

                Console.WriteLine(assignment.Get(Asn.BCWP));
                Console.WriteLine(assignment.Get(Asn.BCWS));

                // SV = BCWP - BCWS
                Console.WriteLine(assignment.Get(Asn.SV));
            }

            // ExEnd:GetResourceAssignmentCosts
        }
        
        [Test]
        public void GetResourceAssignmentOvertimes()
        {
            // ExStart:GetResourceAssignmentOvertimes
            // ExFor: Asn.OvertimeWork
            // ExFor: Asn.OvertimeCost
            // ExFor: Asn.RemainingWork
            // ExFor: Asn.RemainingCost
            // ExFor: Asn.RemainingOvertimeWork
            // ExFor: Asn.RemainingOvertimeCost
            // ExSummary: Shows how to read overtime/remaining works/costs of an assignment.
            var project = new Project(DataDir + "ResourceAssignmentOvertimes.mpp");

            // Print assignment overtimes
            foreach (var ra in project.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.OvertimeWork).ToString());
                Console.WriteLine(ra.Get(Asn.OvertimeCost));
                Console.WriteLine(ra.Get(Asn.RemainingWork).ToString());
                Console.WriteLine(ra.Get(Asn.RemainingCost));
                Console.WriteLine(ra.Get(Asn.RemainingOvertimeWork).ToString());
                Console.WriteLine(ra.Get(Asn.RemainingOvertimeCost));
            }

            // ExEnd:GetResourceAssignmentOvertimes
        }

        [Test]
        public void GetResourceAssignmentPercentWorkComplete()
        {
            // ExStart:GetResourceAssignmentPercentWorkComplete
            // ExFor: Asn.PercentWorkComplete
            // ExSummary: Shows how to read percent work complete of an assignment.
            var project = new Project(DataDir + "ResourceAssignmentPercentWorkComplete.mpp");

            // Print assignment percent completion
            foreach (var ra in project.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.PercentWorkComplete).ToString());
            }

            // ExEnd:GetResourceAssignmentPercentWorkComplete
        }

        [Test]
        public void GetResourceAssignmentStopResumeDates()
        {
            // ExStart:GetResourceAssignmentStopResumeDates
            // ExFor: Asn.Stop
            // ExFor: Asn.Resume
            // ExSummary: Shows how to read assignment's stop/resume dates. 
            var project = new Project(DataDir + "ResourceAssignmentStopResumeDates.mpp");

            // Print resource assignment's stop and resume dates
            foreach (var ra in project.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.Stop).ToShortDateString() == "1/1/2000" ? "NA" : ra.Get(Asn.Stop).ToShortDateString());
                Console.WriteLine(ra.Get(Asn.Resume).ToShortDateString() == "1/1/2000" ? "NA" : ra.Get(Asn.Resume).ToShortDateString());
            }

            // ExEnd:GetResourceAssignmentStopResumeDates
        }

        [Test]
        public void GetResourceAssignmentVariance()
        {
            // ExStart:GetResourceAssignmentVariance
            // ExFor: Asn.WorkVariance
            // ExFor: Asn.CostVariance
            // ExFor: Asn.StartVariance
            // ExFor: Asn.FinishVariance
            // ExSummary: Shows how to read assignment's variances.
            var project = new Project(DataDir + "ResourceAssignmentVariance.mpp");

            // Print assignment variances
            foreach (var ra in project.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.WorkVariance));
                Console.WriteLine(ra.Get(Asn.CostVariance));
                Console.WriteLine(ra.Get(Asn.StartVariance));
                Console.WriteLine(ra.Get(Asn.FinishVariance));
            }

            // ExEnd:GetResourceAssignmentVariance
        }

        [Test]
        public void ReadWriteRateScaleForResourceAssignment()
        {
            try
            {
                // ExStart: ReadWriteRateScaleForResourceAssignment
                // ExFor: Asn.RateScale
                // ExFor: RateScaleType
                // ExSummary: Shows how to work with assignment's rate scale. 
                var project = new Project(DataDir + "New project 2013.mpp");

                var task = project.RootTask.Children.Add("t1");

                var materialResource = project.Resources.Add("materialResource");
                materialResource.Set(Rsc.Type, ResourceType.Material);

                var nonMaterialResource = project.Resources.Add("nonMaterialResource");
                nonMaterialResource.Set(Rsc.Type, ResourceType.Work);

                var materialResourceAssignment = project.ResourceAssignments.Add(task, materialResource);
                materialResourceAssignment.Set(Asn.RateScale, RateScaleType.Week);

                var nonMaterialResourceAssignment = project.ResourceAssignments.Add(task, nonMaterialResource);
                nonMaterialResourceAssignment.Set(Asn.RateScale, RateScaleType.Week);

                project.Save(OutDir + "ReadWriteRateScaleForResourceAssignment_out.mpp", SaveFileFormat.MPP);

                var resavedProject = new Project(OutDir + "ReadWriteRateScaleForResourceAssignment_out.mpp");

                var resavedMaterialResourceAssignment = resavedProject.ResourceAssignments.GetByUid(2);
                Console.WriteLine(resavedMaterialResourceAssignment.Get(Asn.RateScale));

                // only material resource assignments can have non-zero rate scale value.
                var resavedNonMaterialResourceAssignment = resavedProject.ResourceAssignments.GetByUid(3);
                Console.WriteLine(resavedNonMaterialResourceAssignment.Get(Asn.RateScale));

                // ExEnd:ReadWriteRateScaleForResourceAssignment
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void ReadBudgetWorkAndCost()
        {
            // ExStart:ReadBudgetWorkAndCost
            // ExFor: Asn.BudgetWork
            // ExFor: Asn.BudgetCost
            // ExSummary: Shows how to read budget work/cost values of a resource assignment.
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
            foreach (var tsk in collector.Tasks)
            {
                // Display assignment budget work and budget cost
                foreach (var assignment in tsk.Assignments)
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

            // ExEnd:ReadBudgetWorkAndCost
        }

        [Test]
        public void GetSetResourceAssignmentNotes()
        {
            // ExStart
            // ExFor: Asn.Notes
            // ExSummary: Shows how to get/set resource assignment notes.
            var project = new Project(DataDir + "UpdateResourceAssignment.mpp");
            var task = project.RootTask.Children.GetById(1);
            var rsc = project.Resources.GetById(1);

            // create resource assignment
            var assn = project.ResourceAssignments.Add(task, rsc);

            // set resource assignment notes 
            assn.Set(Asn.Notes, "Newly added assignment");

            Console.WriteLine("Notes: " + assn.Get(Asn.Notes));

            // ExEnd
        }

        [Test]
        public void GetSetUid()
        {
            // ExStart
            // ExFor: Asn
            // ExFor: Asn.Uid
            // ExSummary: Shows how to read/write Asn.Uid property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");
            resource.Set(Rsc.Type, ResourceType.Work);

            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.Uid, 30);

            Console.WriteLine("UID: " + assignment.Get(Asn.Uid));

            // ExEnd
        }

        [Test]
        public void GetSetAssignmentOwnerAndGuid()
        {
            // ExStart
            // ExFor: Asn.AssignmentOwner
            // ExFor: Asn.AssignmentOwnerGuid
            // ExSummary: Shows how to read/write Asn.AssignmentOwner and Asn.AssignmentOwnerGuid properties.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");
            resource.Set(Rsc.Type, ResourceType.Work);

            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.AssignmentOwner, "Assignment Owner");
            assignment.Set(Asn.AssignmentOwnerGuid, "1d440f0c-7839-4802-af5f-4bb30e8b75ab");

            Console.WriteLine("Assignment Owner: " + assignment.Get(Asn.AssignmentOwner));
            Console.WriteLine("Assignment Owner GUID: " + assignment.Get(Asn.AssignmentOwnerGuid));

            // ExEnd
        }

        [Test]
        public void GetSetBookingType()
        {
            // ExStart
            // ExFor: Asn.BookingType
            // ExFor: BookingType
            // ExSummary: Shows how to read/write Asn.BookingType property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");
            resource.Set(Rsc.Type, ResourceType.Work);

            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.BookingType, BookingType.Proposed);

            Console.WriteLine("Booking Type: " + assignment.Get(Asn.BookingType));

            // ExEnd
        }

        [Test]
        public void GetSetCreated()
        {
            // ExStart
            // ExFor: Asn.Created
            // ExSummary: Shows how to read/write Asn.Created property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");
            resource.Set(Rsc.Type, ResourceType.Work);

            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.Created, new DateTime(2020, 4, 9, 8, 0, 0));

            Console.WriteLine("Created: " + assignment.Get(Asn.Created));

            // ExEnd
        }

        [Test]
        public void GetSetCommonProps()
        {
            // ExStart
            // ExFor: Asn.Start
            // ExFor: Asn.Finish
            // ExFor: Asn.Work
            // ExFor: Asn.Units
            // ExFor: Asn.PeakUnits
            // ExFor: AsnKey
            // ExSummary: Shows how to read/write common properties.
            var project = new Project();
            project.Set(Prj.WorkFormat, TimeUnitType.Day);

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");
            resource.Set(Rsc.Type, ResourceType.Work);

            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.Start, new DateTime(2020, 4, 9, 8, 0, 0));
            assignment.Set(Asn.Work, project.GetWork(1));
            assignment.Set(Asn.Finish, new DateTime(2020, 4, 9, 17, 0, 0));
            assignment.Set(Asn.Units, 1);
            assignment.Set(Asn.PeakUnits, 1);

            Console.WriteLine("Start: " + assignment.Get(Asn.Start));
            Console.WriteLine("Work: " + assignment.Get(Asn.Work));
            Console.WriteLine("Finish: " + assignment.Get(Asn.Finish));
            Console.WriteLine("Units: " + assignment.Get(Asn.Units));
            Console.WriteLine("Peak Units: " + assignment.Get(Asn.PeakUnits));

            // ExEnd
        }

        [Test]
        public void GetSetHyperlinkProperties()
        {
            // ExStart
            // ExFor: Asn.Hyperlink
            // ExFor: Asn.HyperlinkAddress
            // ExFor: Asn.HyperlinkSubAddress
            // ExSummary: Shows how to read/write hyperlink properties.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");

            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.Hyperlink, "aspose.com");
            assignment.Set(Asn.HyperlinkAddress, "products.aspose.com");
            assignment.Set(Asn.HyperlinkSubAddress, "/total/net");

            Console.WriteLine("Hyperlink: " + assignment.Get(Asn.Hyperlink));
            Console.WriteLine("Hyperlink Address: " + assignment.Get(Asn.HyperlinkAddress));
            Console.WriteLine("Hyperlink Sub Address: " + assignment.Get(Asn.HyperlinkSubAddress));

            // ExEnd
        }

        [Test]
        public void GetSetActualsProperties()
        {
            // ExStart
            // ExFor: Asn.ActualStart
            // ExFor: Asn.ActualWork
            // ExFor: Asn.ActualWorkProtected
            // ExFor: Asn.ActualFinish
            // ExFor: Asn.ActualOvertimeWork
            // ExFor: Asn.ActualOvertimeCost
            // ExFor: Asn.ActualOvertimeWorkProtected
            // ExSummary: Shows how to read/write actual properties.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");

            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            assignment.Set(Asn.Work, project.GetWork(8));
            assignment.Set(Asn.Finish, new DateTime(2000, 1, 3, 17, 0, 0));
            assignment.Set(Asn.ActualStart, new DateTime(2000, 1, 3, 8, 0, 0));
            assignment.Set(Asn.ActualWork, project.GetDuration(8, TimeUnitType.Hour));
            assignment.Set(Asn.ActualWorkProtected, project.GetDuration(8, TimeUnitType.Hour));
            assignment.Set(Asn.ActualFinish, new DateTime(2000, 1, 3, 17, 0, 0));
            assignment.Set(Asn.ActualOvertimeWork, project.GetWork(1));
            assignment.Set(Asn.ActualOvertimeCost, 1m);
            assignment.Set(Asn.ActualOvertimeWorkProtected, project.GetWork(1));

            Console.WriteLine("Start: " + assignment.Get(Asn.Start));
            Console.WriteLine("Work: " + assignment.Get(Asn.Work));
            Console.WriteLine("Finish: " + assignment.Get(Asn.Finish));
            Console.WriteLine("Actual Start: " + assignment.Get(Asn.ActualStart));
            Console.WriteLine("Actual Work: " + assignment.Get(Asn.ActualWork));
            Console.WriteLine("Actual Work Protected: " + assignment.Get(Asn.ActualWorkProtected));
            Console.WriteLine("Actual Finish: " + assignment.Get(Asn.ActualFinish));
            Console.WriteLine("Actual Overtime Work: " + assignment.Get(Asn.ActualOvertimeWork));
            Console.WriteLine("Actual Overtime Cost: " + assignment.Get(Asn.ActualOvertimeCost));
            Console.WriteLine("Actual Overtime Work Protected: " + assignment.Get(Asn.ActualOvertimeWorkProtected));

            // ExEnd
        }

        [Test]
        public void GetSetCostsProperties()
        {
            // ExStart
            // ExFor: Asn.Cost
            // ExFor: Asn.ActualCost
            // ExSummary: Shows how to read/write actual cost properties.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");

            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            assignment.Set(Asn.Cost, 10);
            assignment.Set(Asn.Finish, new DateTime(2000, 1, 3, 17, 0, 0));
            assignment.Set(Asn.ActualStart, new DateTime(2000, 1, 3, 8, 0, 0));
            assignment.Set(Asn.ActualCost, 10m);
            assignment.Set(Asn.ActualFinish, new DateTime(2000, 1, 3, 17, 0, 0));

            Console.WriteLine("Start: " + assignment.Get(Asn.Start));
            Console.WriteLine("Cost: " + assignment.Get(Asn.Cost));
            Console.WriteLine("Finish: " + assignment.Get(Asn.Finish));
            Console.WriteLine("Actual Start: " + assignment.Get(Asn.ActualStart));
            Console.WriteLine("Actual Cost: " + assignment.Get(Asn.ActualCost));
            Console.WriteLine("Actual Finish: " + assignment.Get(Asn.ActualFinish));

            // ExEnd
        }

        [Test]
        public void GetSetConfirmedProperty()
        {
            // ExStart
            // ExFor: Asn.Confirmed
            // ExSummary: Shows how to read/write Asn.Confirmed property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");

            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.Confirmed, true);

            Console.WriteLine("Confirmed: " + assignment.Get(Asn.Confirmed));

            // ExEnd
        }

        [Test]
        public void GetSetResponsePendingProperty()
        {
            // ExStart
            // ExFor: Asn.ResponsePending
            // ExSummary: Shows how to read/write Asn.ResponsePending property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");

            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.ResponsePending, true);

            Console.WriteLine("Response Pending: " + assignment.Get(Asn.ResponsePending));

            // ExEnd
        }

        [Test]
        public void GetSetUpdateNeededProperty()
        {
            // ExStart
            // ExFor: Asn.UpdateNeeded
            // ExSummary: Shows how to read/write Asn.UpdateNeeded property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");

            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.UpdateNeeded, true);

            Console.WriteLine("Update Needed: " + assignment.Get(Asn.UpdateNeeded));

            // ExEnd
        }

        [Test]
        public void GetSetHasFixedRateUnitsProperty()
        {
            // ExStart
            // ExFor: Asn.HasFixedRateUnits
            // ExSummary: Shows how to read/write Asn.HasFixedRateUnits property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");

            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.HasFixedRateUnits, true);

            Console.WriteLine("Has Fixed Rate Units: " + assignment.Get(Asn.HasFixedRateUnits));

            // ExEnd
        }

        [Test]
        public void GetSetFixedMaterialProperty()
        {
            // ExStart
            // ExFor: Asn.FixedMaterial
            // ExSummary: Shows how to read/write Asn.FixedMaterial property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");

            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.FixedMaterial, true);

            Console.WriteLine("Fixed Material: " + assignment.Get(Asn.FixedMaterial));

            // ExEnd
        }

        [Test]
        public void GetTaskResourceProperties()
        {
            // ExStart
            // ExFor: Asn.Task
            // ExFor: Asn.Resource
            // ExSummary: Shows how to read Asn.Task and Asn.Resource properties.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");

            var assignment = project.ResourceAssignments.Add(task, resource);

            Console.WriteLine("Assigned Task Name: " + assignment.Get(Asn.Task).Get(Tsk.Name));
            Console.WriteLine("Assigned Resource Name: " + assignment.Get(Asn.Resource).Get(Rsc.Name));

            // ExEnd
        }

        [Test]
        public void GetSetLevelingDelayProperties()
        {
            // ExStart
            // ExFor: Asn.Delay
            // ExFor: Asn.LevelingDelay
            // ExFor: Asn.LevelingDelayFormat
            // ExSummary: Shows how to read/write Asn.Delay, Asn.LevelingDelay, and Asn.LevelingDelayFormat properties.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");

            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.Delay, project.GetDuration(0, TimeUnitType.Day));

            Console.WriteLine("Delay: " + assignment.Get(Asn.Delay));
            Console.WriteLine("Leveling Delay: " + assignment.Get(Asn.LevelingDelay));
            Console.WriteLine("Leveling Delay Format: " + assignment.Get(Asn.LevelingDelayFormat));

            // ExEnd
        }

        [Test]
        public void GetSetCostRateTableTypeProperties()
        {
            // ExStart
            // ExFor: Asn.CostRateTableType
            // ExSummary: Shows how to read/write Asn.CostRateTableType property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");

            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.CostRateTableType, RateType.B);

            Console.WriteLine("Cost Rate Table Type: " + assignment.Get(Asn.CostRateTableType));

            // ExEnd
        }

        [Test]
        public void GetSetRegularWorkProperties()
        {
            // ExStart
            // ExFor: Asn.RegularWork
            // ExSummary: Shows how to read/write Asn.RegularWork property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");

            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.RegularWork, project.GetWork(1));

            Console.WriteLine("Regular Work: " + assignment.Get(Asn.RegularWork));

            // ExEnd
        }

        [Test]
        public void GetSetLinkedFieldsProperty()
        {
            // ExStart
            // ExFor: Asn.LinkedFields
            // ExSummary: Shows how to read Asn.LinkedFields property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");

            var assignment = project.ResourceAssignments.Add(task, resource);

            Console.WriteLine("Linked Fields: " + assignment.Get(Asn.LinkedFields));

            // ExEnd
        }

        [Test]
        public void GetSetMilestoneProperty()
        {
            // ExStart
            // ExFor: Asn.Milestone
            // ExSummary: Shows how to read Asn.Milestone property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");

            var assignment = project.ResourceAssignments.Add(task, resource);

            Console.WriteLine("Milestone: " + assignment.Get(Asn.Milestone));

            // ExEnd
        }

        [Test]
        public void GetSetOverallocatedProperty()
        {
            // ExStart
            // ExFor: Asn.Overallocated
            // ExSummary: Shows how to read Asn.Overallocated property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");

            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.Overallocated, true);

            Console.WriteLine("Overallocated: " + assignment.Get(Asn.Overallocated));

            // ExEnd
        }

        [Test]
        public void GetSetSummaryProperty()
        {
            // ExStart
            // ExFor: Asn.Summary
            // ExSummary: Shows how to read Asn.Summary property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");

            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.Summary, true);

            Console.WriteLine("Summary: " + assignment.Get(Asn.Summary));

            // ExEnd
        }

        [Test]
        public void GetSetVACProperty()
        {
            // ExStart
            // ExFor: Asn.VAC
            // ExSummary: Shows how to read Asn.VAC property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");

            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.VAC, 10);

            Console.WriteLine("VAC: " + assignment.Get(Asn.VAC));

            // ExEnd
        }
    }
}