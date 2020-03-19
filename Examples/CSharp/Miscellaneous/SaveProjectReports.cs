/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.Miscellaneous
{
    using System.IO;
    using Aspose.Tasks.Visualization;

    internal class SaveProjectReports
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            {
                //ExStart:SaveProjectReports
                //ExFor: Project.SaveReport(String, ReportType)
                //ExSummary: Shows how to save the project best practice analyzer report in PDF format to the specified file path.
                var project = new Project(dataDir + "Cyclic stucture.mpp");
                project.SaveReport(dataDir + "BestPracticeAnalyzer_out.pdf", ReportType.BestPracticeAnalyzer);
                //ExEnd:SaveProjectReports
            }

            {
                //ExStart:SaveBurnDownReport
                //ExFor: Project.SaveReport(Stream, ReportType)
                //ExSummary: Shows how to save the project burndown report in PDF format to the specified stream.
                var project = new Project(dataDir + "Homemoveplan.mpp");
                using (var stream = new FileStream(dataDir + "Burndown_out.pdf", FileMode.Create))
                {
                    project.SaveReport(stream, ReportType.Burndown);
                }
                //ExEnd:SaveBurnDownReport
            }

            {
                //ExStart:SaveCashFlowReport
                //ExFor: Project.SaveReport(String, ReportType)
                //ExSummary: Shows how to save the project cash flow report to PDF format to the specified file path.
                var project = new Project(dataDir + "OzBuild 16 Orig.mpp");
                project.SaveReport(dataDir + "CashFlow_out.pdf", ReportType.CashFlow);
                //ExEnd:SaveCashFlowReport
            }
            
            {
                //ExStart:SaveCostOverrunsReport
                //ExFor: Project.SaveReport(Stream, ReportType) 
                //ExSummary: Shows how to save the project cost overrun report in PDF format to the specified stream.
                var project = new Project(dataDir + "Software Development.mpp");
                using (var stream = new FileStream(dataDir + "CostOverruns_out.pdf", FileMode.Create))
                {
                    project.SaveReport(stream, ReportType.CostOverruns);
                }
                //ExEnd:SaveCostOverrunsReport
            }

            {
                //ExStart:SaveWorkOverviewReport
                //ExFor: Project.SaveReport(String, ReportType) 
                //ExSummary: Shows how to save the project work overview report in PDF format to the specified file path.
                var project = new Project(dataDir + "Residential Construction.mpp");
                project.SaveReport(dataDir + "WorkOverview_out.pdf", ReportType.WorkOverview);
                //ExEnd:SaveWorkOverviewReport
            }

            {
                //ExStart:SaveUpcomingTasksReport
                //ExFor: Project.SaveReport(Stream, ReportType) 
                //ExSummary: Shows how to save the project upcoming task report in PDF format to the specified stream.
                var project = new Project(dataDir + "UpcomingTasks.mpp");
                using (var stream = new FileStream(dataDir + "UpcomingTasks_out.pdf", FileMode.Create))
                {
                    project.SaveReport(stream, ReportType.UpcomingTask);
                }
                //ExEnd:SaveUpcomingTasksReport
            }

            {
                //ExStart:SaveTaskCostOverviewReport
                //ExFor: Project.SaveReport(String, ReportType) 
                //ExSummary: Shows how to save the project task cost overview report in PDF format to the specified file path.
                var project = new Project(dataDir + "Software Development.mpp");
                project.SaveReport(dataDir + "TaskCostOverview_out.pdf", ReportType.TaskCostOverview);
                //ExEnd:SaveTaskCostOverviewReport
            }

            {
                //ExStart:SaveSlippingTasksReport
                //ExFor: Project.SaveReport(Stream, ReportType) 
                //ExSummary: Shows how to save the project slipping task report in PDF format to the specified stream.
                var project = new Project(dataDir + "Homemoveplan.mpp");
                using (var stream = new FileStream(dataDir + "SlippingTasks_out.pdf", FileMode.Create))
                {
                    project.SaveReport(stream, ReportType.SlippingTasks);
                }
                //ExEnd:SaveSlippingTasksReport
            }

            {
                //ExStart:SaveResourceOverviewReport
                //ExFor: Project.SaveReport(String, ReportType) 
                //ExSummary: Shows how to save the project resource overview report in PDF format to the specified file path.
                var project = new Project(dataDir + "Software Development Plan.mpp");
                project.SaveReport(dataDir + "ResourceOverview_out.pdf", ReportType.ResourceOverview);
                //ExEnd:SaveResourceOverviewReport
            }

            {
                //ExStart:SaveResourceCostOverviewReport
                //ExFor: Project.SaveReport(Stream, ReportType) 
                //ExSummary: Shows how to save the project resource cost overview report in PDF format to the specified stream.
                var project = new Project(dataDir + "OzBuild 16 Orig.mpp");
                using (var stream = new FileStream(dataDir + "ResourceCostOverview_out.pdf", FileMode.Create))
                {
                    project.SaveReport(stream, ReportType.ResourceCostOverview);
                }
                //ExEnd:SaveResourceCostOverviewReport
            }

            {
                //ExStart:SaveOverallocatedResourcesReport
                //ExFor: Project.SaveReport(String, ReportType) 
                //ExSummary: Shows how to save the project overallocated resource report in PDF format to the specified file path.
                var project = new Project(dataDir + "Software Development Plan.mpp");
                project.SaveReport(dataDir + "OverAllocatedResources_out.pdf", ReportType.OverallocatedResources);
                //ExEnd:SaveOverallocatedResourcesReport
            }

            {
                //ExStart:SaveMilestonesReport
                //ExFor: Project.SaveReport(Stream, ReportType) 
                //ExSummary: Shows how to save the project milestone report in PDF format to the specified stream.
                var project = new Project(dataDir + "Residential Construction.mpp");
                using (var stream = new FileStream(dataDir + "Milestones_out.pdf", FileMode.Create))
                {
                    project.SaveReport(stream, ReportType.Milestones);
                }
                //ExEnd:SaveMilestonesReport
            }

            {
                //ExStart:SaveCostOverviewReport
                //ExFor: Project.SaveReport(String, ReportType) 
                //ExSummary: Shows how to save the project cost overview report in PDF format to the specified file path.
                var project = new Project(dataDir + "OzBuild 16 Orig.mpp");
                project.SaveReport(dataDir + "CostOverview_out.pdf", ReportType.CostOverview);
                //ExEnd:SaveCostOverviewReport
            }

            {
                //ExStart:SaveCriticalTasksReport
                //ExFor: Project.SaveReport(Stream, ReportType) 
                //ExSummary: Shows how to save the project critical tasks report in PDF format to the specified stream.
                var project = new Project(dataDir + "Residential Construction.mpp");
                using (var stream = new FileStream(dataDir + "CriticalTasks_out.pdf", FileMode.Create))
                {
                    project.SaveReport(stream, ReportType.CriticalTasks);
                }
                //ExEnd:SaveCriticalTasksReport
            }

            {
                //ExStart:SaveLateTasksReport
                //ExFor: Project.SaveReport(String, ReportType) 
                //ExSummary: Shows how to save the project late task report in PDF format to the specified file path.
                var project = new Project(dataDir + "Residential Construction.mpp");
                project.SaveReport(dataDir + "LateTasks_out.pdf", ReportType.LateTasks);
                //ExEnd:SaveLateTasksReport
            }
        }
    }
}
