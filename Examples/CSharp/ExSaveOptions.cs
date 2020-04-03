namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExSaveOptions : ApiExampleBase
    {
        [Test]
        public void ChangeGanttBarsColorGradient()
        {
            //ExStart:ChangeGanttBarsColorGradient
            //ExFor: SaveOptions.UseGradientBrush
            //ExSummary: shows how to set a value indicating whether gradient brush should be used when rendering Gantt Chart.
            var project = new Project(DataDir + "Project2.mpp");
            
            SaveOptions options = new XamlOptions();
            options.UseGradientBrush = false;
            project.Save(OutDir + "ChangeGanttBarsColorGradient_Solid_out.xaml", options);

            options.UseGradientBrush = true;
            project.Save(OutDir + "ChangeGanttBarsColorGradient_Gradient_out.xaml", options);
            //ExEnd:ChangeGanttBarsColorGradient
        }
        
        [Test]
        public void TimescaleSettingsExample()
        {
            //ExStart:TimescaleSettings
            //ExFor: SaveOptions.Timescale
            //ExSummary: Shows how to set the minimal time period to render. The default value is <see cref="P:Aspose.Tasks.Saving.SaveOptions.Timescale">Days</see>.
            var project = new Project(DataDir + "Project2.mpp");

            // Save to one page image (Timescale.days by default)
            project.Save(OutDir + "NewProductDevDays_out.jpeg", new ImageSaveOptions(SaveFileFormat.JPEG));

            // Save to one page image (Timescale.ThirdsOfMonths)
            var options = new ImageSaveOptions(SaveFileFormat.JPEG);
            options.Timescale = Timescale.ThirdsOfMonths;

            project.Save(OutDir + "NewProductDevThirdsOfMonths_out.jpeg", options);

            // Save to one page image (Timescale.Months)
            options.Timescale = Timescale.Months;
            project.Save(OutDir + "NewProductDevMonths_out.jpeg", options);
            //ExEnd:TimescaleSettings
        }
        
        [Test]
        public void CustomizeTextStyle()
        {
            //ExStart
            //ExFor: SaveOptions.TextStyles
            //ExSummary: Shows how to use save options' text styles which are used to style different text items in a project.
            var project = new Project(DataDir + "CreateProject2.mpp");
            SaveOptions options = new PdfSaveOptions();
            options.PresentationFormat = PresentationFormat.ResourceSheet;

            var style = new TextStyle();
            style.Color = Color.OrangeRed;
            style.FontStyle = FontStyle.Bold;
            style.FontStyle |= FontStyle.Italic;
            style.ItemType = TextItemType.OverallocatedResources;

            options.TextStyles = new List<TextStyle>();
            options.TextStyles.Add(style);
            project.Save(OutDir + "CustomizeTextStyle_out.pdf", options);
            //ExEnd
        }
        
        [Test]
        public void UsingSaveOptionsView()
        {
            //ExStart
            //ExFor: SaveOptions.View
            //ExSummary: Shows how to use add columns of view to be exported during export project.
            var project = new Project(DataDir + "CreateProject2.mpp");

            var options = new Spreadsheet2003SaveOptions();
            var ganttChartColumn = new GanttChartColumn(
                "WBS", 
                100,
                delegate(Task task)
                {
                    return task.Get(Tsk.WBS);
                });
            options.View.Columns.Add(ganttChartColumn);

            var resourceViewColumn = new ResourceViewColumn(
                "Cost center",
                100,
                delegate(Resource resource)
                {
                    return resource.Get(Rsc.CostCenter);
                });
            options.ResourceView.Columns.Add(resourceViewColumn);

            var assignmentViewColumn = new AssignmentViewColumn(
                "Notes",
                200,
                delegate(ResourceAssignment assignment)
                {
                    return assignment.Get(Asn.Notes);
                });
            options.AssignmentView.Columns.Add(assignmentViewColumn);

            project.Save(OutDir + "UsingSpreadsheet2003SaveOptions_out.xml", options);
            //ExEnd
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
                var resultFile = "PredefinedPageSizes_" + Format + "_" + pageSize + "_out.pdf";
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
        public void FitContentsToCellSize()
        {
            //ExStart:FitContentsToCellSize
            //ExFor: SaveOptions.FitContent
            //ExSummary: Shows how to set the option whether row height should be increased to fit its content.
            var project = new Project(DataDir + "CreateProject2.mpp");
            SaveOptions options = new PdfSaveOptions();

            // Set option fit content to true
            options.FitContent = true;
            options.Timescale = Timescale.Months;
            options.PresentationFormat = PresentationFormat.TaskUsage;
            project.Save(OutDir + "FitContentsToCellSize_out.pdf", options);
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
            //ExFor: SaveOptions.MarkCriticalTasks
            //ExSummary: Shows how to print critical tasks while save in image file formats. 
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
    }
}