namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    [SuppressMessage("ReSharper", "StyleCop.SA1600", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global", Justification = "Reviewed. Suppression is OK here.")]
    public class ExGanttChartView : ApiExampleBase
    {
        // ExStart:ImplementCustomBarStyleWriting
        // ExFor: GanttChartView.CustomBarStyles
        // ExFor: GanttBarEndShape
        // ExFor: GanttBarFillPattern
        // ExFor: GanttBarMiddleShape
        // ExFor: GanttBarStyle.ShowFor
        // ExSummary: Shows how to set custom bar styles of Gantt Chart project view.
        [Test] // ExSkip
        public void ImplementCustomBarStyle()
        {
            try
            {
                var project = new Project(DataDir + "Blank2010.mpp");
                project.RootTask.Children.Add("Task");

                var view = (GanttChartView)project.DefaultView;
                var custom = GetCustomBarStyle();

                // Add the custom bar style to the custom bar collection of the project view
                view.CustomBarStyles.Add(custom);

                var options = new MPPSaveOptions
                {
                    WriteViewData = true
                };

                project.Save(OutDir + "ImplementCustomBarStyleWriting_out.mpp", options);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        public static GanttBarStyle GetCustomBarStyle()
        {
            var style = new GanttBarStyle
            {
                ShowForTaskUid = 1,
                MiddleShape = GanttBarMiddleShape.RectangleBottom,
                MiddleFillPattern = GanttBarFillPattern.MediumFill,
                MiddleShapeColor = Color.Blue,

                StartShape = GanttBarEndShape.ArrowDown,
                StartShapeColor = Color.Red,

                EndShape = GanttBarEndShape.ArrowUp,
                EndShapeColor = Color.Yellow,

                LeftField = Field.TaskResourceNames,
                RightField = Field.TaskName,
                TopField = Field.TaskStart,
                BottomField = Field.TaskFinish,
                InsideField = Field.TaskDuration
            };

            return style;
        }

        // ExEnd:ImplementCustomBarStyleWriting
        [Test]
        public void SupportForTextStyle()
        {
            // ExStart:SupportForTextStyle
            // ExFor: GanttChartView.TableTextStyles
            // ExSummary: Shows how to add custom table text styles.
            var project = new Project(DataDir + "Project5.mpp");
            var view = (GanttChartView)project.Views.ToList()[0];

            view.TableTextStyles.Clear();
            view.TableTextStyles.Add(new TableTextStyle(1) { Color = Color.Red, Field = Field.TaskName });
            view.TableTextStyles.Add(new TableTextStyle(1) { Color = Color.Gray, Field = Field.TaskDurationText });
            view.TableTextStyles.Add(new TableTextStyle(2) { Color = Color.Blue, FontStyle = FontStyle.Bold | FontStyle.Italic | FontStyle.Underline });

            // ExEnd:SupportForTextStyle
        }

        [Test]
        public void WorkWithTimescaleTier()
        {
            // ExStart:WorkWithTimescaleTier
            // ExFor: GanttChartView
            // ExFor: GanttChartView.#ctor
            // ExFor: GanttChartView.TopTimescaleTier
            // ExFor: GanttChartView.MiddleTimescaleTier
            // ExFor: GanttChartView.BottomTimescaleTier
            // ExSummary: Shows how to modify timescale tiers.
            var project = new Project();

            // Init Gantt Chart View
            var view = new GanttChartView
            {
                TopTimescaleTier = new TimescaleTier(),
                MiddleTimescaleTier = new TimescaleTier(),
                BottomTimescaleTier = new TimescaleTier()
            };

            // set Time Scale count
            view.TopTimescaleTier.Count = 2;
            view.TopTimescaleTier.ShowTicks = false;
            view.MiddleTimescaleTier.Count = 2;
            view.MiddleTimescaleTier.ShowTicks = false;
            view.BottomTimescaleTier.Count = 2;
            view.BottomTimescaleTier.ShowTicks = false;

            // add Gantt Chart View to project
            project.Views.Add(view);

            // add some test data to project
            var task1 = project.RootTask.Children.Add("Task 1");
            var task2 = project.RootTask.Children.Add("Task 2");
            task1.Set(Tsk.Duration, task1.ParentProject.GetDuration(24, TimeUnitType.Hour));
            task2.Set(Tsk.Duration, task1.ParentProject.GetDuration(40, TimeUnitType.Hour));
            project.Save(OutDir + "SetTimeScaleCount_out.pdf", SaveFileFormat.PDF);

            // ExEnd:WorkWithTimescaleTier
        }
        
        [Test]
        public void WorkWithAutoFilters()
        {
            // ExStart
            // ExFor: GanttChartView.AutoFilters
            // ExSummary: Shows how to read auto filters of a Gantt chart view.
            var project = new Project(DataDir + "Project2.mpp");
            project.Set(Prj.StatusDate, project.Get(Prj.StartDate));
                
            var view = (GanttChartView)project.Views.ToList()[0];

            // lets iterate over auto filters of the Gantt chart view
            foreach (var filter in view.AutoFilters)
            {
                Console.WriteLine("Name: " + filter.Name);
                Console.WriteLine("Criteria: " + filter.Criteria);
                Console.WriteLine();
            }
            
            // work with the project...
            
            // ExEnd
        }
        
        [Test]
        public void WorkWithGanttChartViews()
        {
            // ExStart
            // ExFor: GanttChartView.BarSize
            // ExFor: GanttChartView.BarRounding
            // ExFor: GanttChartView.ShowDrawings
            // ExFor: GanttChartView.ShowBarSplits
            // ExFor: GanttChartView.RollUpGanttBars
            // ExFor: GanttChartView.NonWorkingTimeColor
            // ExFor: GanttChartView.TimescaleSizePercentage
            // ExFor: GanttChartView.HideRollupBarsWhenSummaryExpanded
            // ExFor: GanttBarSize
            // ExSummary: Shows how to set some useful properties of Gantt chart view.
            var project = new Project(DataDir + "Project2.mpp");
            project.Set(Prj.StatusDate, project.Get(Prj.StartDate));
                
            var view = (GanttChartView)project.Views.ToList()[0];

            // set a value indicating whether the bars round to the nearest day
            view.BarRounding = false;
            // set the height, in points, of the Gantt bars in the Gantt Chart
            view.BarSize = GanttBarSize.BarSize24;
            // set a value indicating whether rollup bars will be hidden when expanding summary task
            view.HideRollupBarsWhenSummaryExpanded = true;
            // set non-working time color
            view.NonWorkingTimeColor = Color.Azure;
            // set a value indicating whether bars on the Gantt Chart must be rolled up
            view.RollUpGanttBars = true;
            // set a value indicating whether task splits on the Gantt Chart must be shown
            view.ShowBarSplits = true;
            // set a value indicating whether drawings on the Gantt Chart must be shown
            view.ShowDrawings = true;
            // set a percentage to reduce or enlarge the spacing between units on the timescale tier
            view.TimescaleSizePercentage = 10;

            project.Save(OutDir + "WorkWithGanttChartViews_out.pdf", SaveFileFormat.PDF);

            // ExEnd
        }
        
        [Test]
        public void WorkWithGanttChartViewTextStyles()
        {
            // ExStart
            // ExFor: GanttChartView.TextStyles
            // ExSummary: Shows how to read Gantt chart text styles.
            var project = new Project(DataDir + "Project2.mpp");
            project.Set(Prj.StatusDate, project.Get(Prj.StartDate));
                
            var view = (GanttChartView)project.Views.ToList()[0];

            // iterate over text styles of the Gantt chart view
            foreach (var style in view.TextStyles)
            {
                Console.WriteLine("Style Item Type: " + style.ItemType);
                Console.WriteLine("Style Item Type: " + style.FontFamily);
                Console.WriteLine();
            }

            // ExEnd
        }
    }
}