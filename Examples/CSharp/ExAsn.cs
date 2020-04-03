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
            var project = new Project(DataDir + "ResourceAssignmentTimephasedData.mpp");

            // Get the first task of the Project
            var task = project.RootTask.Children.GetById(1);

            // Get the First Resource Assignment of the Project
            var firstRA = project.ResourceAssignments.ToList()[0];

            // Flat contour is default contour
            Console.WriteLine("Flat contour");

            var collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            Console.WriteLine("Turtle contour");
            firstRA.Set(Asn.WorkContour, WorkContourType.Turtle);
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            Console.WriteLine("BackLoaded contour");
            firstRA.Set(Asn.WorkContour, WorkContourType.BackLoaded);
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            Console.WriteLine("FrontLoaded contour");
            firstRA.Set(Asn.WorkContour, WorkContourType.FrontLoaded);
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            Console.WriteLine("Bell contour");
            firstRA.Set(Asn.WorkContour, WorkContourType.Bell);
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            Console.WriteLine("EarlyPeak contour");
            firstRA.Set(Asn.WorkContour, WorkContourType.EarlyPeak);
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }

            // Change contour
            Console.WriteLine("LatePeak contour");
            firstRA.Set(Asn.WorkContour, WorkContourType.LatePeak);
            collection = task.GetTimephasedData(project.Get(Prj.StartDate), project.Get(Prj.FinishDate));
            foreach (var td in collection)
            {
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value);
            }
            
            // Change contour
            Console.WriteLine("DoublePeak contour");
            firstRA.Set(Asn.WorkContour, WorkContourType.DoublePeak);
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
            //ExFor: Asn.Uid
            //ExFor: Asn.Start
            //ExFor: Asn.Finish
            //ExSummary: Shows how to read common resource assignment's properties.
            var project = new Project(DataDir + "GetGeneralResourceAssignmentProperties.mpp");

            // Print general resource assignment properties
            foreach (var ra in project.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.Uid));
                Console.WriteLine(ra.Get(Asn.Start).ToShortDateString());
                Console.WriteLine(ra.Get(Asn.Finish).ToShortDateString());
            }
            //ExEnd:GetGeneralResourceAssignmentProperties
        }
        
        [Test]
        public void GetResourceAssignmentCosts()
        {
            //ExStart:GetResourceAssignmentCosts
            //ExFor: Asn.Cost
            //ExFor: Asn.ACWP
            //ExFor: Asn.BCWP
            //ExFor: Asn.BCWS
            //ExSummary: Shows how to read assignment's costs.
            var project = new Project(DataDir + "ResourceAssignmentCosts.mpp");

            // Print resource assignment costs
            foreach (var ra in project.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.Cost));
                Console.WriteLine(ra.Get(Asn.ACWP));
                Console.WriteLine(ra.Get(Asn.BCWP));
                Console.WriteLine(ra.Get(Asn.BCWS));
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