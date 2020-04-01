namespace Aspose.Tasks.Examples.CSharp
{
    using System.IO;
    using NUnit.Framework;
    using Visualization;

    [TestFixture]
    public class ExReportType : ApiExampleBase
    {
        [Test]
        public void SaveBurnDownReport()
        {
            //ExStart:SaveBurnDownReport
            //ExFor: ReportType.Burndown
            //ExSummary: Shows how to save the project burndown report in PDF format to the specified stream.
            var project = new Project(DataDir + "Homemoveplan.mpp");
            using (var stream = new FileStream(OutDir + "Burndown_out.pdf", FileMode.Create))
            {
                project.SaveReport(stream, ReportType.Burndown);
            }
            //ExEnd:SaveBurnDownReport
        }
    
        [Test]
        public void SaveCashFlowReport()
        {
            //ExStart:SaveCashFlowReport
            //ExFor: ReportType.CashFlow
            //ExSummary: Shows how to save the project cash flow report to PDF format to the specified file path.
            var project = new Project(DataDir + "OzBuild 16 Orig.mpp");
            project.SaveReport(OutDir + "CashFlow_out.pdf", ReportType.CashFlow);
            //ExEnd:SaveCashFlowReport
        }
    
        [Test]
        public void SaveCostOverrunsReport()
        {
            //ExStart:SaveCostOverrunsReport
            //ExFor: ReportType.CostOverruns
            //ExSummary: Shows how to save the project cost overrun report in PDF format to the specified stream.
            var project = new Project(DataDir + "Software Development.mpp");
            using (var stream = new FileStream(OutDir + "CostOverruns_out.pdf", FileMode.Create))
            {
                project.SaveReport(stream, ReportType.CostOverruns);
            }
            //ExEnd:SaveCostOverrunsReport
        }
    
        [Test]
        public void SaveWorkOverviewReport()
        {
            //ExStart:SaveWorkOverviewReport
            //ExFor: ReportType.WorkOverview
            //ExSummary: Shows how to save the project work overview report in PDF format to the specified file path.
            var project = new Project(DataDir + "Residential Construction.mpp");
            project.SaveReport(OutDir + "WorkOverview_out.pdf", ReportType.WorkOverview);
            //ExEnd:SaveWorkOverviewReport
        }
    
        [Test]
        public void SaveUpcomingTasksReport()
        {
            //ExStart:SaveUpcomingTasksReport
            //ExFor: ReportType.UpcomingTask
            //ExSummary: Shows how to save the project upcoming task report in PDF format to the specified stream.
            var project = new Project(DataDir + "UpcomingTasks.mpp");
            using (var stream = new FileStream(OutDir + "UpcomingTasks_out.pdf", FileMode.Create))
            {
                project.SaveReport(stream, ReportType.UpcomingTask);
            }
            //ExEnd:SaveUpcomingTasksReport
        }
    
        [Test]
        public void SaveTaskCostOverviewReport()
        {
            //ExStart:SaveTaskCostOverviewReport
            //ExFor: ReportType.TaskCostOverview
            //ExSummary: Shows how to save the project task cost overview report in PDF format to the specified file path.
            var project = new Project(DataDir + "Software Development.mpp");
            project.SaveReport(OutDir + "TaskCostOverview_out.pdf", ReportType.TaskCostOverview);
            //ExEnd:SaveTaskCostOverviewReport
        }
    
        [Test]
        public void SaveSlippingTasksReport()
        {
            //ExStart:SaveSlippingTasksReport
            //ExFor: ReportType.SlippingTasks
            //ExSummary: Shows how to save the project slipping task report in PDF format to the specified stream.
            var project = new Project(DataDir + "Homemoveplan.mpp");
            using (var stream = new FileStream(OutDir + "SlippingTasks_out.pdf", FileMode.Create))
            {
                project.SaveReport(stream, ReportType.SlippingTasks);
            }
            //ExEnd:SaveSlippingTasksReport
        }
    
        [Test]
        public void SaveResourceOverviewReport()
        {
            //ExStart:SaveResourceOverviewReport
            //ExFor: ReportType.ResourceOverview
            //ExSummary: Shows how to save the project resource overview report in PDF format to the specified file path.
            var project = new Project(DataDir + "Software Development Plan.mpp");
            project.SaveReport(OutDir + "ResourceOverview_out.pdf", ReportType.ResourceOverview);
            //ExEnd:SaveResourceOverviewReport
        }
    
        [Test]
        public void SaveResourceCostOverviewReport()
        {
            //ExStart:SaveResourceCostOverviewReport
            //ExFor: ReportType.ResourceCostOverview
            //ExSummary: Shows how to save the project resource cost overview report in PDF format to the specified stream.
            var project = new Project(DataDir + "OzBuild 16 Orig.mpp");
            using (var stream = new FileStream(OutDir + "ResourceCostOverview_out.pdf", FileMode.Create))
            {
                project.SaveReport(stream, ReportType.ResourceCostOverview);
            }
            //ExEnd:SaveResourceCostOverviewReport
        }
    
        [Test]
        public void SaveOverallocatedResourcesReport()
        {
            //ExStart:SaveOverallocatedResourcesReport
            //ExFor: ReportType.OverallocatedResources
            //ExSummary: Shows how to save the project overallocated resource report in PDF format to the specified file path.
            var project = new Project(DataDir + "Software Development Plan.mpp");
            project.SaveReport(OutDir + "OverAllocatedResources_out.pdf", ReportType.OverallocatedResources);
            //ExEnd:SaveOverallocatedResourcesReport
        }
    
        [Test]
        public void SaveMilestonesReport()
        {
            //ExStart:SaveMilestonesReport
            //ExFor: ReportType.Milestones
            //ExSummary: Shows how to save the project milestone report in PDF format to the specified stream.
            var project = new Project(DataDir + "Residential Construction.mpp");
            using (var stream = new FileStream(OutDir + "Milestones_out.pdf", FileMode.Create))
            {
                project.SaveReport(stream, ReportType.Milestones);
            }
            //ExEnd:SaveMilestonesReport
        }
    
        [Test]
        public void SaveCostOverviewReport()
        {
            //ExStart:SaveCostOverviewReport
            //ExFor: ReportType.CostOverview
            //ExSummary: Shows how to save the project cost overview report in PDF format to the specified file path.
            var project = new Project(DataDir + "OzBuild 16 Orig.mpp");
            project.SaveReport(OutDir + "CostOverview_out.pdf", ReportType.CostOverview);
            //ExEnd:SaveCostOverviewReport
        }
    
        [Test]
        public void SaveCriticalTasksReport()
        {
            //ExStart:SaveCriticalTasksReport
            //ExFor: ReportType.CriticalTasks
            //ExSummary: Shows how to save the project critical tasks report in PDF format to the specified stream.
            var project = new Project(DataDir + "Residential Construction.mpp");
            using (var stream = new FileStream(OutDir + "CriticalTasks_out.pdf", FileMode.Create))
            {
                project.SaveReport(stream, ReportType.CriticalTasks);
            }
            //ExEnd:SaveCriticalTasksReport
        }
    
        [Test]
        public void SaveLateTasksReport()
        {
            //ExStart:SaveLateTasksReport
            //ExFor: ReportType.LateTasks
            //ExSummary: Shows how to save the project late task report in PDF format to the specified file path.
            var project = new Project(DataDir + "Residential Construction.mpp");
            project.SaveReport(OutDir + "LateTasks_out.pdf", ReportType.LateTasks);
            //ExEnd:SaveLateTasksReport
        }
        
        [Test]
        public void SaveBestPracticeAnalyzerReport()
        {
            //ExStart:SaveBestPracticeAnalyzerReport
            //ExFor: ReportType.BestPracticeAnalyzer
            //ExSummary: Shows how to save the project best practice analyzer report in PDF format to the specified file path.
            var project = new Project(DataDir + "Cyclic stucture.mpp");
            project.SaveReport(OutDir + "BestPracticeAnalyzer_out.pdf", ReportType.BestPracticeAnalyzer);
            //ExEnd:SaveBestPracticeAnalyzerReport
        }
    }
}