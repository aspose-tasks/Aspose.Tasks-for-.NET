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
            //ExStart:GenerateResourceAssignmentTimephasedData
            //ExFor: Asn.WorkContour
            //ExSummary: Shows how to set different timephased data contours for resource assignments.
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
            //ExEnd:GenerateResourceAssignmentTimephasedData
        }
        
        [Test]
        public void GetGeneralResourceAssignmentProperties()
        {
            //ExStart:GetGeneralResourceAssignmentProperties
            //ExFor: Asn
            //ExFor: Asn.Uid
            //ExFor: Asn.AssignmentOwner
            //ExFor: Asn.AssignmentOwnerGuid
            //ExFor: Asn.BookingType
            //ExFor: Asn.Created
            //ExFor: Asn.Start
            //ExFor: Asn.ActualStart
            //ExFor: Asn.Work
            //ExFor: Asn.ActualWork
            //ExFor: Asn.ActualWorkProtected
            //ExFor: Asn.ActualOvertimeWork
            //ExFor: Asn.ActualOvertimeWorkProtected
            //ExFor: Asn.Cost
            //ExFor: Asn.ActualCost
            //ExFor: Asn.ActualOvertimeCost
            //ExFor: Asn.Finish
            //ExFor: Asn.ActualFinish
            //ExFor: Asn.Confirmed
            //ExFor: Asn.ResponsePending
            //ExFor: Asn.CostRateTableType
            //ExFor: Asn.Task
            //ExFor: Asn.Resource
            //ExFor: Asn.Delay
            //ExFor: Asn.FixedMaterial
            //ExFor: Asn.HasFixedRateUnits
            //ExFor: Asn.Hyperlink
            //ExFor: Asn.HyperlinkAddress
            //ExFor: Asn.HyperlinkSubAddress
            //ExFor: Asn.LevelingDelay
            //ExFor: Asn.LevelingDelayFormat
            //ExFor: Asn.LinkedFields
            //ExFor: Asn.Milestone
            //ExFor: Asn.Overallocated
            //ExFor: Asn.Units
            //ExFor: Asn.PeakUnits
            //ExFor: Asn.RegularWork
            //ExFor: Asn.Summary
            //ExFor: Asn.UpdateNeeded
            //ExFor: Asn.VAC
            //ExSummary: Shows how to read/write common resource assignment's properties.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task 1");
            task.Set(Tsk.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(8));

            var resource = project.Resources.Add("Resource 1");
            resource.Set(Rsc.Type, ResourceType.Work);
            resource.Set(Rsc.StandardRate, 10m);
            resource.Set(Rsc.OvertimeRate, 15m);

            var assignment = project.ResourceAssignments.Add(task, resource);
            assignment.Set(Asn.AssignmentOwner, "Michael");
            assignment.Set(Asn.BookingType, BookingType.Proposed);
            assignment.Set(Asn.Confirmed, true);
            assignment.Set(Asn.ResponsePending, true);
            assignment.Set(Asn.AssignmentOwnerGuid, "1d440f0c-7839-4802-af5f-4bb30e8b75ab");
            assignment.Set(Asn.Delay, project.GetDuration(0, TimeUnitType.Day));
            assignment.Set(Asn.Start, new DateTime(2000, 1, 3, 8, 0, 0));
            assignment.Set(Asn.Work, project.GetWork(8));
            assignment.Set(Asn.Finish, new DateTime(2000, 1, 3, 17, 0, 0));
            assignment.Set(Asn.ActualStart, new DateTime(2000, 1, 3, 8, 0, 0));
            assignment.Set(Asn.ActualWork, project.GetDuration(8, TimeUnitType.Hour));
            assignment.Set(Asn.ActualFinish, new DateTime(2000, 1, 3, 17, 0, 0));
            assignment.Set(Asn.ActualOvertimeWork, project.GetWork(1));
            assignment.Set(Asn.ActualOvertimeCost, 1);
            assignment.Set(Asn.FixedMaterial, false);
            assignment.Set(Asn.Hyperlink, "aspose.com");
            assignment.Set(Asn.HyperlinkAddress, "products.aspose.com");
            assignment.Set(Asn.HyperlinkSubAddress, "/total/net");
            assignment.Set(Asn.LevelingDelayFormat, TimeUnitType.Hour);
            assignment.Set(Asn.LevelingDelay, project.GetDuration(0d));
            assignment.Set(Asn.LinkedFields, false);
            assignment.Set(Asn.Units, 1d);
            assignment.Set(Asn.PeakUnits, 1d);
            
            Console.WriteLine("UID: " + assignment.Get(Asn.Uid));
            Console.WriteLine("Assigned Task Name: " + assignment.Get(Asn.Task).Get(Tsk.Name));
            Console.WriteLine("Assigned Resource Name: " + assignment.Get(Asn.Resource).Get(Rsc.Name));
            Console.WriteLine("Assignment Owner: " + assignment.Get(Asn.AssignmentOwner));
            Console.WriteLine("Assignment Owner Guid: " + assignment.Get(Asn.AssignmentOwnerGuid));
            Console.WriteLine("Start: " + assignment.Get(Asn.Start));
            Console.WriteLine("Work: " + assignment.Get(Asn.Work));
            Console.WriteLine("Regular Work: " + assignment.Get(Asn.RegularWork));
            Console.WriteLine("Units: " + assignment.Get(Asn.Units));
            Console.WriteLine("Peak Units: " + assignment.Get(Asn.PeakUnits));
            Console.WriteLine("Finish: " + assignment.Get(Asn.Finish));
            Console.WriteLine("Delay: " + assignment.Get(Asn.Delay));
            Console.WriteLine("Booking Type: " + assignment.Get(Asn.BookingType));
            Console.WriteLine("Confirmed: " + assignment.Get(Asn.Confirmed));
            Console.WriteLine("Created: " + assignment.Get(Asn.Created));
            Console.WriteLine("Response Pending: " + assignment.Get(Asn.ResponsePending));
            Console.WriteLine("Actual Start: " + assignment.Get(Asn.ActualStart));
            Console.WriteLine("Actual Work: " + assignment.Get(Asn.ActualWork));
            Console.WriteLine("Actual Work Protected: " + assignment.Get(Asn.ActualWorkProtected));
            Console.WriteLine("Cost Rate Table Type: " + assignment.Get(Asn.CostRateTableType));
            Console.WriteLine("Actual Cost: " + assignment.Get(Asn.ActualCost));
            Console.WriteLine("Actual Finish: " + assignment.Get(Asn.ActualFinish));
            Console.WriteLine("Regular Work: " + assignment.Get(Asn.RegularWork));
            Console.WriteLine("Actual Overtime Work: " + assignment.Get(Asn.ActualOvertimeWork));
            Console.WriteLine("Actual Overtime Cost: " + assignment.Get(Asn.ActualOvertimeCost));
            Console.WriteLine("Actual Overtime Work Protected: " + assignment.Get(Asn.ActualOvertimeWorkProtected));
            Console.WriteLine("Fixed Material: " + assignment.Get(Asn.FixedMaterial));
            Console.WriteLine("Has Fixed Rate Units: " + assignment.Get(Asn.HasFixedRateUnits));
            Console.WriteLine("Hyperlink: " + assignment.Get(Asn.Hyperlink));
            Console.WriteLine("Hyperlink Address: " + assignment.Get(Asn.HyperlinkAddress));
            Console.WriteLine("Hyperlink Sub Address: " + assignment.Get(Asn.HyperlinkSubAddress));
            Console.WriteLine("Leveling Delay: " + assignment.Get(Asn.LevelingDelay));
            Console.WriteLine("Leveling Delay Format: " + assignment.Get(Asn.LevelingDelayFormat));
            Console.WriteLine("Linked Fields: " + assignment.Get(Asn.LinkedFields));
            Console.WriteLine("Milestone: " + assignment.Get(Asn.Milestone));
            Console.WriteLine("Overallocated: " + assignment.Get(Asn.Overallocated));
            Console.WriteLine("Summary: " + assignment.Get(Asn.Summary));
            Console.WriteLine("Units: " + assignment.Get(Asn.Units));
            Console.WriteLine("Peak Units: " + assignment.Get(Asn.PeakUnits));
            Console.WriteLine("Update Needed: " + assignment.Get(Asn.UpdateNeeded));
            Console.WriteLine("VAC: " + assignment.Get(Asn.VAC));
            //ExEnd:GetGeneralResourceAssignmentProperties
        }
        
        [Test]
        public void GetResourceAssignmentCosts()
        {
            //ExStart:GetResourceAssignmentCosts
            //ExFor: Asn.ACWP
            //ExFor: Asn.BCWP
            //ExFor: Asn.BCWS
            //ExFor: Asn.CV
            //ExFor: Asn.SV
            //ExSummary: Shows how to read assignment's costs.
            var project = new Project(DataDir + "ResourceAssignmentCosts.mpp");

            // Print resource assignment costs
            foreach (var ra in project.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.Cost));
                Console.WriteLine(ra.Get(Asn.ACWP));
                // CV = BCWP - ACWP
                Console.WriteLine(ra.Get(Asn.CV));
                
                Console.WriteLine(ra.Get(Asn.BCWP));
                Console.WriteLine(ra.Get(Asn.BCWS));
                // SV = BCWP - BCWS
                Console.WriteLine(ra.Get(Asn.SV));
            }
            //ExEnd:GetResourceAssignmentCosts
        }
        
        [Test]
        public void GetResourceAssignmentOvertimes()
        {
            //ExStart:GetResourceAssignmentOvertimes
            //ExFor: Asn.OvertimeWork
            //ExFor: Asn.OvertimeCost
            //ExFor: Asn.RemainingWork
            //ExFor: Asn.RemainingCost
            //ExFor: Asn.RemainingOvertimeWork
            //ExFor: Asn.RemainingOvertimeCost
            //ExSummary: Shows how to read overtime/remaining works/costs of an assignment.
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
            //ExEnd:GetResourceAssignmentOvertimes
        }
        
        [Test]
        public void GetResourceAssignmentPercentWorkComplete()
        {
            //ExStart:GetResourceAssignmentPercentWorkComplete
            //ExFor: Asn.PercentWorkComplete
            //ExSummary: Shows how to read percent work complete of an assignment.
            var project = new Project(DataDir + "ResourceAssignmentPercentWorkComplete.mpp");

            // Print assignment percent completion
            foreach (var ra in project.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.PercentWorkComplete).ToString()); 
            }
            //ExEnd:GetResourceAssignmentPercentWorkComplete
        }
        
        [Test]
        public void GetResourceAssignmentStopResumeDates()
        {
            //ExStart:GetResourceAssignmentStopResumeDates
            //ExFor: Asn.Stop
            //ExFor: Asn.Resume
            //ExSummary: Shows how to read assignment's stop/resume dates. 
            var project = new Project(DataDir + "ResourceAssignmentStopResumeDates.mpp");

            // Print resource assignment's stop and resume dates
            foreach (var ra in project.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.Stop).ToShortDateString() == "1/1/2000" ? "NA" : ra.Get(Asn.Stop).ToShortDateString());
                Console.WriteLine(ra.Get(Asn.Resume).ToShortDateString() == "1/1/2000" ? "NA" : ra.Get(Asn.Resume).ToShortDateString());
            }
            //ExEnd:GetResourceAssignmentStopResumeDates
        }
        
        [Test]
        public void GetResourceAssignmentVariance()
        {
            //ExStart:GetResourceAssignmentVariance
            //ExFor: Asn.WorkVariance
            //ExFor: Asn.CostVariance
            //ExFor: Asn.StartVariance
            //ExFor: Asn.FinishVariance
            //ExSummary: Shows how to read assignment's variances.
            var project = new Project(DataDir + "ResourceAssignmentVariance.mpp");

            // Print assignment variances
            foreach (var ra in project.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.WorkVariance));
                Console.WriteLine(ra.Get(Asn.CostVariance));
                Console.WriteLine(ra.Get(Asn.StartVariance));
                Console.WriteLine(ra.Get(Asn.FinishVariance));
            }
            //ExEnd:GetResourceAssignmentVariance
        }
        
        [Test]
        public void ReadWriteRateScaleForResourceAssignment()
        {
            try
            {
                //ExStart: ReadWriteRateScaleForResourceAssignment
                //ExFor: Asn.RateScale
                //ExSummary: Shows how to work with assignment's rate scale. 
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

                var resavedProject = new Project(DataDir + "ReadWriteRateScaleForResourceAssignment_out.mpp");

                var resavedMaterialResourceAssignment = resavedProject.ResourceAssignments.GetByUid(2);
                Console.WriteLine(resavedMaterialResourceAssignment.Get(Asn.RateScale));

                // only material resource assignments can have non-zero rate scale value.
                var resavedNonMaterialResourceAssignment = resavedProject.ResourceAssignments.GetByUid(3);
                Console.WriteLine(resavedNonMaterialResourceAssignment.Get(Asn.RateScale));
                //ExEnd:ReadWriteRateScaleForResourceAssignment
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void ReadBudgetWorkAndCost()
        {
            //ExStart:ReadBudgetWorkAndCost
            //ExFor: Asn.BudgetWork
            //ExFor: Asn.BudgetCost
            //ExSummary: Shows how to read budget work/cost values of a resource assignment.
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
            //ExEnd:ReadBudgetWorkAndCost
        }
        
        [Test]
        public void UpdateResourceAssignmentNotes()
        {
            try
            {
                //ExStart:UpdateResourceAssignmentNotes
                //ExFor: Asn.Notes
                //ExSummary: Shows how to add/update resource assignments in MPP file.
                var project = new Project(DataDir + "UpdateResourceAssignment.mpp");
                var task = project.RootTask.Children.GetById(1);
                var rsc = project.Resources.GetById(1);

                // Create resource assignment
                var assn = project.ResourceAssignments.Add(task, rsc);
                assn.Set(Asn.Notes, "Newly added assignment");

                project.Save(OutDir + "UpdateResourceAssignment_out.mpp", SaveFileFormat.MPP);
                //ExEnd:UpdateResourceAssignmentNotes
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}