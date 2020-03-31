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
        public void CreateMultipleResourceAssignmentsForOneTask()
        {
            try
            {
                //ExStart:CreateMultipleResourceAssignmentsForOneTask
                //ExFor: ResourceAssignmentCollection.Add(Task,Resource)
                //ExSummary: Shows how to create multiple resource assignments.
                var project = new Project(DataDir + "TemplateResource2010.mpp")
                {
                    CalculationMode = CalculationMode.Automatic
                };

                project.Set(Prj.DateFormat, DateFormat.DateDddMmDdYy);
                project.Set(Prj.StartDate, new DateTime(2019, 9, 16, 9, 0, 0));
                project.Set(Prj.NewTasksAreManual, false);
                project.Set(Prj.ActualsInSync, false);

                var workResource = project.Resources.Add("Servente (Work)");
                workResource.Set(Rsc.Name, "Servente (Work)");
                workResource.Set(Rsc.Initials, "S");
                workResource.Set(Rsc.Type, ResourceType.Work);
                workResource.Set(Rsc.StandardRateFormat, RateFormatType.Hour);
                workResource.Set(Rsc.Code, "1503");

                var materialResource = project.Resources.Add("Tijolo (Material)");
                materialResource.Set(Rsc.Name, "Tijolo (Material)");
                materialResource.Set(Rsc.Initials, "T");
                materialResource.Set(Rsc.Type, ResourceType.Material);
                materialResource.Set(Rsc.StandardRateFormat, RateFormatType.MaterialResourceRate);
                materialResource.Set(Rsc.Code, "21341");

                var tsk1 = project.RootTask.Children.Add("Task - 01");
                tsk1.Set(Tsk.IsRollup, new NullableBool(true));
                tsk1.Set(Tsk.IsPublished, new NullableBool(false));
                var tsk2 = tsk1.Children.Add("Task - 01.01");
                tsk2.Set(Tsk.IsRollup, new NullableBool(true));
                tsk2.Set(Tsk.IsPublished, new NullableBool(false));
                var tsk3 = tsk2.Children.Add("Task - 01.01.001");
                tsk3.Set(Tsk.IsEstimated, new NullableBool(false));
                tsk3.Set(Tsk.Start, new DateTime(2019, 9, 16, 9, 0, 0));
                tsk3.Set(Tsk.Duration, project.GetDuration(10, TimeUnitType.Day));
                tsk3.Set(Tsk.Work, project.GetDuration(10, TimeUnitType.Day));
                tsk3.Set(Tsk.IsRollup, new NullableBool(true));
                tsk3.Set(Tsk.IsPublished, new NullableBool(false));

                var assignment1 = project.ResourceAssignments.Add(tsk3, materialResource);
                assignment1.Set(Asn.Delay, project.GetDuration(40, TimeUnitType.Hour));
                assignment1.Set(Asn.Start, new DateTime(2019, 9, 23, 9, 0, 0));
                assignment1.Set(Asn.Finish, new DateTime(2019, 9, 27, 18, 0, 0));
                var assignment2 = project.ResourceAssignments.Add(tsk3, workResource);
                assignment2.Set(Asn.Work, project.GetDuration(56, TimeUnitType.Hour));
                assignment2.Set(Asn.Start, new DateTime(2019, 9, 16, 9, 0, 0));
                assignment2.Set(Asn.Finish, new DateTime(2019, 9, 24, 18, 0, 0));

                assignment2.Set(Asn.WorkContour, WorkContourType.Contoured);
                tsk3.Set(Tsk.IsManual, new NullableBool(true));
                tsk1.Set(Tsk.IsManual, new NullableBool(true));

                project.Save(OutDir + @"Assignment_Dates_out.mpp", SaveFileFormat.MPP);
                //ExEnd:CreateMultipleResourceAssignmentsForOneTask
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
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
        public void CreateSplittedTasks()
        {
            //ExStart:CreateSplittedTasks
            //ExFor: ResourceAssignment.TimephasedDataFromTaskDuration(Calendar)
            //ExFor: ResourceAssignment.SplitTask(DateTime, DateTime, Calendar)
            //ExSummary: Shows how to add a split for a task.
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

            project.Save(OutDir + "CreateSplitTasks_out.xml", SaveFileFormat.XML);
            //ExEnd:CreateSplittedTasks
        }
        
        [Test]
        public void ReadWriteTimephasedData()
        {
            //ExStart:ReadWriteTimephasedData
            //ExFor: ResourceAssignment.GetTimephasedData(DateTime, DateTime)
            //ExFor: ResourceAssignment.GetTimephasedData(DateTime, DateTime, TimephasedDataType)
            //ExSummary: Shows how to read timephased data of a resource assignment.
            var project = new Project(DataDir + "ReadWriteTimephasedData.mpp");

            // Set project properties
            project.Set(Prj.StartDate, new DateTime(2013, 10, 30, 9, 0, 0));
            project.Set(Prj.NewTasksAreManual, false);

            // Add task and resources
            var task = project.RootTask.Children.Add("Task");
            var rsc = project.Resources.Add("Rsc");

            // Set resource rates and task duration
            rsc.Set(Rsc.StandardRate, 10);
            rsc.Set(Rsc.OvertimeRate, 15);            
            task.Set(Tsk.Duration, project.GetDuration(6));

            // Create resource assignment
            var assn = project.ResourceAssignments.Add(task, rsc);
            assn.Set(Asn.Stop, DateTime.MinValue);
            assn.Set(Asn.Resume, DateTime.MinValue);

            // Set Backloaded contour, it increases task duration from 6 to 10 days
            assn.Set(Asn.WorkContour, WorkContourType.BackLoaded);

            project.SetBaseline(BaselineType.Baseline);
            task.Set(Tsk.PercentComplete, 50);

            // Read timephased data
            List<TimephasedData> td = assn.GetTimephasedData(assn.Get(Asn.Start), assn.Get(Asn.Finish), TimephasedDataType.AssignmentRemainingWork).ToList();
            Console.WriteLine(td.Count);
            foreach (var timePhasedValue in td)
            {                    
                Console.WriteLine(timePhasedValue.Value);
            }
            //ExEnd:ReadWriteTimephasedData
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}