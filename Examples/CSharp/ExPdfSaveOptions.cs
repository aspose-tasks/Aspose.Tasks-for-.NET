namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExPdfSaveOptions : ApiExampleBase
    {
        [Test]
        public void RenderResourceUsageView()
        {
            //ExStart:RenderResourceUsageView
            //ExFor: SaveOptions.PresentationFormat
            //ExSummary: Shows how to render resource usage view.
            var project = new Project(DataDir + "ResourceUsageView.mpp");
                        
            // Define the SaveOptions with required TimeScale settings as Days
            SaveOptions options = new PdfSaveOptions();
            options.Timescale = Timescale.Days;

            // Set the Presentation format to ResourceUsage
            options.PresentationFormat = PresentationFormat.ResourceUsage;
            project.Save(OutDir + "ResourceUsageView_days_out.pdf", options);

            // Set the Timescale settings to ThirdsOfMonths and save the Project
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(OutDir + "ResourceUsageView_thirdsOfMonths_out.pdf", options);

            // Set the Timescale settings to Months and save the Project
            options.Timescale = Timescale.Months;
            project.Save(OutDir + "ResourceUsageView_months_out.pdf", options);
            //ExEnd:RenderResourceUsageView
        }
        
        [Test]
        public void RenderResourceSheetView()
        {
            //ExStart:RenderResourceSheetView
            //ExFor: SaveOptions.PresentationFormat
            //ExSummary: Shows how to render resource sheet view by using save options.
            var project = new Project(DataDir + "ResourceSheetView.mpp");

            // Define rendering options
            SaveOptions options = new PdfSaveOptions();

            // Set the Presentation Format to Resource Sheet
            options.PresentationFormat = PresentationFormat.ResourceSheet;
            project.Save(OutDir + "ResourceSheetView_out.pdf", options);
            //ExEnd:RenderResourceSheetView
        }
        
        [Test]
        public void CustomizeTextWithTaskBars()
        {
            //ExStart:CustomizeTextWithTaskBars
            //ExFor: SaveOptions.BarStyles
            //ExSummary: Shows how to customize task bars by using <see cref="Aspose.Tasks.Visualization.BarStyle" />s.
            var project = new Project();

            var task1 = project.RootTask.Children.Add("Task 1");
            var task2 = project.RootTask.Children.Add("Task 2");

            task1.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));
            task2.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));

            project.TaskLinks.Add(task1, task2, TaskLinkType.FinishToStart);

            var task3 = project.RootTask.Children.Add("Task 3");
            var rsc1 = project.Resources.Add("Resource 1");
            var rsc2 = project.Resources.Add("Resource 2");
            var rsc3 = project.Resources.Add("Resource 3");

            project.ResourceAssignments.Add(task1, rsc1);
            project.ResourceAssignments.Add(task2, rsc2);
            project.ResourceAssignments.Add(task3, rsc3);

            SaveOptions options = new PdfSaveOptions();
            options.Timescale = Timescale.ThirdsOfMonths;

            var style = new BarStyle
                            {
                                ItemType = BarItemType.CriticalTask,
                                BarTextConverter = delegate(Task t)
                                    {
                                        return string.Format("This task (ID = {0}) is on critical path", t.Get(Tsk.Id));
                                    }
                            };

            var style2 = new BarStyle
                             {
                                 BarColor = Color.DarkOrchid, 
                                 ItemType = BarItemType.Task
                             };

            options.BarStyles = new List<BarStyle>
            {
                style, 
                style2
            };

            project.Save(OutDir + "CustomizeTextWithTaskBars_out.pdf", options);
            //ExEnd:CustomizeTextWithTaskBars
        }
        
        [Test]
        public void RenderGanttChartWithBarsRolledUp()
        {
            //ExStart:RenderGanttChartWithBarsRolledUp
            //ExFor: SaveOptions.RollUpGanttBars
            //ExSummary: Shows how to set a value indicating that subtasks on the summary task bar must be rolled up.
            var project = new Project(DataDir + "Project2.mpp");
            
            var options = new PdfSaveOptions();
            options.PresentationFormat = PresentationFormat.GanttChart;
            options.FitContent = true;
            options.RollUpGanttBars = true;
            // OR
            // options.RollUpGanttBars = false;
            options.DrawNonWorkingTime = true;
            options.PageSize = PageSize.A3;

            project.Save(OutDir + "RenderGanttChartWithBarsRolledUp_out.pdf", options);
            //ExEnd:RenderGanttChartWithBarsRolledUp
        }
        
        [Test]
        public void RenderProjectToPredefinedPageSizes()
        {
            //ExStart:RenderProjectToPredefinedPageSizes
            //ExFor: SaveOptions.PageSize
            //ExSummary: Shows how to set page size (can be one of the values of the <see cref="P:Aspose.Tasks.Visualization.TiffCompression" /> enumeration).
            var project = new Project(DataDir + "Project2.mpp");

            const PresentationFormat Format = PresentationFormat.GanttChart;

            // Render the project to all Pre-Defined page sizes
            foreach (var pageSize in (PageSize[])Enum.GetValues(typeof(PageSize)))
            {
                var options = new PdfSaveOptions();
                options.PresentationFormat = Format;
                options.FitContent = true;
                options.PageSize = pageSize;
                var resultFile = "result_PredefinedPageSizes_" + Format + "_" + pageSize + "_out.pdf";
                project.Save(OutDir + resultFile, options);
            }
            //ExEnd:RenderProjectToPredefinedPageSizes
        }
        
        //ExStart:SortTasksByColumnInGanttChart
        //ExFor: SaveOptions.TasksComparer
        //ExSummary: Shows how to set a comparer to sort tasks on Gantt chart and/or Task Sheet chart.
        [TestFixture] //ExSkip
        internal class SortTasksByColumnInGanttChart
        {
            [Test] //ExSkip
            public void SortTasksByColumnInGanttChartExample()
            {
                var project = new Project(DataDir + "Project2.mpp");
                SaveOptions options = new PdfSaveOptions();
                options.Timescale = Timescale.Months;

                options.TasksComparer = new TasksNameComparer();
                project.Save(OutDir + "SortedByNames_out.pdf", options);

                options.TasksComparer = new TasksDurationComparer();
                project.Save(OutDir + "SortedByDurations_out.pdf", options);
            }

            private class TasksNameComparer : IComparer<Task>
            {
                public int Compare(Task x, Task y)
                {
                    // ReSharper disable once ConvertIfStatementToSwitchStatement
                    if (x == null && y == null)
                    {
                        return 0;
                    }

                    if (x == null)
                    {
                        return -1;
                    }

                    return y == null ? 1 : string.Compare(x.Get(Tsk.Name), y.Get(Tsk.Name), StringComparison.Ordinal);
                }
            }

            private class TasksDurationComparer : IComparer<Task>
            {
                public int Compare(Task x, Task y)
                {
                    // ReSharper disable once ConvertIfStatementToSwitchStatement
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
                    
                    var durX = x.Get(Tsk.Duration);
                    var durY = y.Get(Tsk.Duration);
                    return durX.TimeSpan.CompareTo(durY.TimeSpan);
                }
            }
        }
        //ExEnd:SortTasksByColumnInGanttChart
        
        [Test]
        public void AddDefaultFontDuringSavingAsPDF()
        {
            //ExStart: AddDefaultFontDuringSavingAsPDF
            //ExFor: PdfSaveOptions.DefaultFontName
            //ExFor: PdfSaveOptions.UseProjectDefaultFont
            //ExSummary: Shows how to set custom font that will be used for print of output pdf.
            var project = new Project(DataDir + "CreateProject2.mpp");

            var options = new PdfSaveOptions
            {
                PresentationFormat = PresentationFormat.GanttChart,
                FitContent = true,
                UseProjectDefaultFont = false,
                DefaultFontName = "Segoe UI Black"
            };
            project.Save(OutDir + "CreateProject2_out.pdf", options);
            //ExEnd:AddDefaultFontDuringSavingAsPDF
        }
        
        [Test]
        public void FitContentsToCellSize()
        {
            //ExStart:FitContentsToCellSize
            //ExFor: SaveOptions.FitContent
            //ExSummary: Shows how to set the option whether row height should be increased to fit its content.
            var project = new Project(DataDir + "CreateProject2.mpp");
            SaveOptions saveOptions = new PdfSaveOptions();

            // Set option fit content to true
            saveOptions.FitContent = true;
            saveOptions.Timescale = Timescale.Months;
            saveOptions.PresentationFormat = PresentationFormat.TaskUsage;
            project.Save(OutDir + "FitContentsToCellSize_out.pdf", saveOptions);
            //ExEnd:FitContentsToCellSize
        }
        
        [Test]
        public void HideLegendsDuringSave()
        {
            //ExStart:HideLegendsDuringSave
            //ExFor: SaveOptions.LegendOnEachPage
            //ExSummary: Shows how to hide page legends.
            var project = new Project(DataDir + "CreateProject2.mpp");
            SaveOptions options = new PdfSaveOptions();

            // Set the LegendOnEachPage property to false to hide legends
            options.LegendOnEachPage = false;

            project.Save(OutDir + "HideLegendsDuringSave_out.pdf", options);
            //ExEnd:HideLegendsDuringSave
        }
        
        [Test]
        public void PrintProjectPagesToSeparateFiles()
        {
            //ExStart:PrintProjectPagesToSeparateFiles
            //ExFor: Gridline
            //ExFor: ImageSaveOptions.SaveToSeparateFiles
            //ExFor: SaveOptions.MarkCriticalTasks
            //ExSummary: Shows how to save project layout to separate files. 
            var project = new Project(DataDir + "CreateProject2.mpp");
            var options = new ImageSaveOptions(SaveFileFormat.PNG);
            options.StartDate = project.Get(Prj.StartDate).AddDays(-3);
            options.EndDate = project.Get(Prj.FinishDate);
            options.MarkCriticalTasks = true;
            options.LegendOnEachPage = false;
            
            options.Gridlines = new List<Gridline>();

            var gridline = new Gridline
            {
                GridlineType = GridlineType.GanttRow, 
                Color = Color.CornflowerBlue, 
                Pattern = LinePattern.Dashed
            };
            options.Gridlines.Add(gridline);
 
            project.Save(OutDir + "PrintProjectPagesToSeparateFiles1_out.png", options);
            
            // Save project layout to separate files
            options.SaveToSeparateFiles = true;
            project.Save(OutDir + "PrintProjectPagesToSeparateFiles2_out.png", options);
            //ExEnd:PrintProjectPagesToSeparateFiles
        }
        
        [Test]
        public void ReducingGapBetweenTasksListAndFooter()
        {
            //ExStart: ReducingGapBetweenTasksListAndFooter
            //ExFor: ImageSaveOptions.ReduceFooterGap
            //ExSummary: Shows how to set a value indicating whether a gap between last task and the footer must be reduced.
            var project = new Project(DataDir + "CreateProject2.mpp");

            //Use ReduceFooterGap property to reduce the gap between list of tasks and Footer
            var options =
                new ImageSaveOptions(SaveFileFormat.PNG) { ReduceFooterGap = true, /* set to true */ SaveToSeparateFiles = true, PageSize = PageSize.A0, Timescale = Timescale.Days };
            project.Save(OutDir + "ReducingGapBetweenTasksListAndFooter_out.png", options);

            var pdfSaveOptions = new PdfSaveOptions { ReduceFooterGap = true, /* set to true */ SaveToSeparateFiles = true, PageSize = PageSize.A0, Timescale = Timescale.Days };
            project.Save(OutDir + "ReducingGapBetweenTasksListAndFooter_out.pdf", pdfSaveOptions);

            var htmlSaveOptions = new HtmlSaveOptions
            {
                ReduceFooterGap = false, // set to true
                IncludeProjectNameInPageHeader = false,
                IncludeProjectNameInTitle = false,
                PageSize = PageSize.A0,
                Timescale = Timescale.Days
            };
            project.Save(OutDir + "ReducingGapBetweenTasksListAndFooter_out.html", htmlSaveOptions);
            //ExEnd:ReducingGapBetweenTasksListAndFooter
        }
        
        [Test]
        public void SaveToMultiplePdfFiles()
        {
            //ExStart:SaveToMultiplePdfFiles
            //ExFor: PdfSaveOptions
            //ExFor: PdfSaveOptions.SaveToSeparateFiles
            //ExFor: PdfSaveOptions.Pages
            //ExSummary: Shows how to save selected pages of a project into PDF file. 
            var project = new Project(DataDir + "Software Development Plan.mpp");
            var saveOptions = new PdfSaveOptions();
            saveOptions.SaveToSeparateFiles = true;
            saveOptions.Pages = new List<int>();
            saveOptions.Pages.Add(1);
            saveOptions.Pages.Add(4);
            project.Save(OutDir + "SaveToMultiplePDFFiles_out.pdf", saveOptions);
            //ExEnd:SaveToMultiplePdfFiles
        }
        
        [Test]
        public void RenderTaskSheetView()
        {
            //ExStart:RenderTaskSheetView
            //ExFor: SaveOptions.PresentationFormat
            //ExSummary: Shows how to render task sheet view.
            var project = new Project(DataDir + "TaskSheetView.mpp");

            // Set presentation format Task Sheet and save project as PDF
            SaveOptions options = new PdfSaveOptions();
            options.PresentationFormat = PresentationFormat.TaskSheet;

            project.Save(OutDir + "TaskSheetView_out.pdf", options);
            //ExEnd:RenderTaskSheetView
        }
    }
}