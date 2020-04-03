namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Drawing;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExGanttChartView : ApiExampleBase
    {
        //ExStart:ImplementCustomBarStyleWriting
        //ExFor: GanttChartView.CustomBarStyles
        //ExSummary: Shows how to set custom bar styles of Gantt Chart project view.
        [Test] //ExSkip
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

                var options = new MPPSaveOptions();
                options.WriteViewData = true;

                project.Save(OutDir + "ImplementCustomBarStyleWriting_out.mpp", options);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        private static GanttBarStyle GetCustomBarStyle()
        {
            var style = new GanttBarStyle();
            style.ShowFor = "1";
            style.MiddleShape = GanttBarMiddleShape.RectangleBottom;
            style.MiddleFillPattern = GanttBarFillPattern.MediumFill;
            style.MiddleShapeColor = Color.Blue;

            style.StartShape = GanttBarEndShape.ArrowDown;
            style.StartShapeColor = Color.Red;

            style.EndShape = GanttBarEndShape.ArrowUp;
            style.EndShapeColor = Color.Yellow;

            style.LeftField = Field.TaskResourceNames;
            style.RightField = Field.TaskName;
            style.TopField = Field.TaskStart;
            style.BottomField = Field.TaskFinish;
            style.InsideField = Field.TaskDuration;

            return style;
        }
        //ExEnd:ImplementCustomBarStyleWriting

        [Test]
        public void SupportForTextStyle()
        {
            //ExStart:SupportForTextStyle
            //ExFor: GanttChartView.TableTextStyles
            //ExSummary: Shows how to add custom table text styles.
            var project = new Project(DataDir + "Project5.mpp");
            var view = (GanttChartView)project.Views.ToList()[0];
            
            view.TableTextStyles.Clear();
            view.TableTextStyles.Add(new TableTextStyle(1) { Color = Color.Red, Field = Field.TaskName });
            view.TableTextStyles.Add(new TableTextStyle(1) { Color = Color.Gray, Field = Field.TaskDurationText });
            view.TableTextStyles.Add(new TableTextStyle(2) { Color = Color.Blue, FontStyle = FontStyle.Bold | FontStyle.Italic | FontStyle.Underline });
            //ExEnd:SupportForTextStyle
        }

        [Test]
        public void ReadSpecificGanttChartViewData()
        {
            //ExStart:ReadSpecificGanttChartViewData
            //ExFor: GanttChartView
            //ExSummary: Shows how to read Gantt chart view data.
            var project = new Project(DataDir + @"ReadSpecificGantChartViewData.mpp"); 

            var view = (GanttChartView)project.Views.ToList()[0];
            Console.WriteLine("Is Bar Rounding: " + view.BarRounding);
            Console.WriteLine("Show Bar Splits? : " + view.ShowBarSplits);
            Console.WriteLine("Show Drawings? : " + view.ShowDrawings);
            Console.WriteLine("Roll Up Gantt Bars? " + view.RollUpGanttBars);
            Console.WriteLine("Hide Rollup Bars When Summary Expanded: " + view.HideRollupBarsWhenSummaryExpanded);
            Console.WriteLine("Bar Size: " + view.BarSize);
            Console.WriteLine("Bar Style: " + view.BarStyles.Count);
            Console.WriteLine("\n************************ RETRIEVING BAR STYLES INFORMATION FROM THE VIEW *********************");
            var i = 0;
            foreach (var barStyle in view.BarStyles)
            {
                Console.WriteLine("Name: " + barStyle.Name);
                Console.WriteLine("ShowFor: " + barStyle.ShowFor);
                Console.WriteLine("Row: " + barStyle.Row);
                Console.WriteLine("From: " + barStyle.From);
                Console.WriteLine("To: " + barStyle.To);
                Console.WriteLine("MiddleShape: " + barStyle.MiddleShape);
                Console.WriteLine("MiddleShapeColor: " + barStyle.MiddleShapeColor);
                Console.WriteLine("StartShape: " + barStyle.StartShape);
                Console.WriteLine("EndShape: " + barStyle.EndShape);
                Console.WriteLine("EndShapeColor: " + barStyle.EndShapeColor);
                i++;
            }

            Console.WriteLine("Grid Lines Count: " + view.Gridlines.Count);
            var gridlines = view.Gridlines[0];
            Console.WriteLine("\n************************ RETRIEVING GRID LINES PROPERTIES *********************");
            Console.WriteLine("GridLine Type: " + gridlines.Type);
            Console.WriteLine("Gridlines Interval: " + gridlines.Interval);
            Console.WriteLine("Gridlines Color: " + gridlines.NormalColor);
            Console.WriteLine("Gridlines NormalPattern: " + gridlines.NormalPattern);
            Console.WriteLine("Gridlines IntervalPattern: " + gridlines.IntervalPattern);
            Console.WriteLine("Gridlines IntervalColor: " + gridlines.IntervalColor);
            Console.WriteLine("\n************************ RETRIEVING PROGRESS LINES PROPERTIES *********************");
            Console.WriteLine("ProgressLInes.BeginAtDate: " + view.ProgressLines.BeginAtDate);
            Console.WriteLine("ProgressLines.isBaselinePlan: " + view.ProgressLines.IsBaselinePlan);
            Console.WriteLine("ProgressLines.DisplaySelected: " + view.ProgressLines.DisplaySelected);
            Console.WriteLine("ProgressLines.SelectedDates.Count: " + view.ProgressLines.SelectedDates.Count);
            Console.WriteLine("ProgressLines.SelectedDates[0]: " + view.ProgressLines.SelectedDates[0]);
            Console.WriteLine("ProgressLines.SelectedDates[1]: " + view.ProgressLines.SelectedDates[1]);
            Console.WriteLine("ProgressLines.SelectedDates[2]: " + view.ProgressLines.SelectedDates[2]);
            Console.WriteLine("ProgressLines.DisplayAtRecurringIntervals: " + view.ProgressLines.DisplayAtRecurringIntervals);
            Console.WriteLine("ProgressLines.RecurringInterval.Interval: " + Interval.Weekly, view.ProgressLines.RecurringInterval.Interval);
            Console.WriteLine("ProgressLines.RecurringInterval.WeeklyDays.Count" + view.ProgressLines.RecurringInterval.WeeklyDays.Count);
            Console.WriteLine("Recurring Interval.WeeklyDays: " + view.ProgressLines.RecurringInterval.WeeklyDays);
            Console.WriteLine("Recurring Interval.DayType.Saturday: " + view.ProgressLines.RecurringInterval.WeeklyDays);
            Console.WriteLine("Recurring Interval.DayType.Sunday: " + view.ProgressLines.RecurringInterval.WeeklyDays);
            Console.WriteLine("ProgressLines.ShowDate: " + view.ProgressLines.ShowDate);
            Console.WriteLine("ProgressLines.ProgressPointShape: " + view.ProgressLines.ProgressPointShape);
            Console.WriteLine("ProgressLines.ProgressPointColor: " + view.ProgressLines.ProgressPointColor);
            Console.WriteLine("ProgressLines.LineColor: " + Color.Red, view.ProgressLines.LineColor);
            Console.WriteLine("ProgressLines.LinePattern: " + LinePattern.Solid, view.ProgressLines.LinePattern);
            Console.WriteLine("ProgressLines.OtherProgressPointShape: " + view.ProgressLines.OtherProgressPointShape);
            Console.WriteLine("ProgressLines.OtherProgressPointColor: " + view.ProgressLines.OtherProgressPointColor);
            Console.WriteLine("ProgressLines.OtherLineColor: " + view.ProgressLines.OtherLineColor);
            Console.WriteLine("\n************************ BOTTOM TIMESCALE INFORMATION ******************");
            Console.WriteLine("BottomTimescaleTier.Count:" + view.BottomTimescaleTier.Count);
            Console.WriteLine("BottomTimescaleTier.Unit:" + TimescaleUnit.Days, view.BottomTimescaleTier.Unit.ToString());
            Console.WriteLine("BottomTimescaleTier.UsesFiscalYear: " + view.BottomTimescaleTier.UsesFiscalYear);
            Console.WriteLine("BottomTimescaleTier.Alignment: " + StringAlignment.Center, view.BottomTimescaleTier.Alignment.ToString());
            Console.WriteLine("BottomTimescaleTier.ShowTicks: " + view.BottomTimescaleTier.ShowTicks);
            Console.WriteLine("BottomTimescaleTier.Label:" + DateLabel.DayDi, view.BottomTimescaleTier.Label);
            Console.WriteLine("\n************************ MIDDLE TIMESCALE INFORMATION ******************");
            Console.WriteLine("MiddleTimescaleTier.Count:" + view.MiddleTimescaleTier.Count);
            Console.WriteLine("MiddleTimescaleTier.Unit:" + TimescaleUnit.Days, view.MiddleTimescaleTier.Unit.ToString());
            Console.WriteLine("MiddleTimescaleTier.UsesFiscalYear: " + view.MiddleTimescaleTier.UsesFiscalYear);
            Console.WriteLine("MiddleTimescaleTier.Alignment: " + StringAlignment.Center, view.MiddleTimescaleTier.Alignment.ToString());
            Console.WriteLine("MiddleTimescaleTier.ShowTicks: " + view.MiddleTimescaleTier.ShowTicks);
            Console.WriteLine("MiddleTimescaleTier.Label:" + DateLabel.DayDi, view.MiddleTimescaleTier.Label);
            Console.WriteLine("\n************************ TOP TIMESCALE INFORMATION ******************");
            Console.WriteLine("TopTimescaleTier.Unit:" + TimescaleUnit.Days, view.TopTimescaleTier.Unit.ToString());
            Console.WriteLine("TopTimescaleTier.UsesFiscalYear: " + view.TopTimescaleTier.UsesFiscalYear);
            Console.WriteLine("TopTimescaleTier.Alignment: " + StringAlignment.Center, view.TopTimescaleTier.Alignment.ToString());
            Console.WriteLine("TopTimescaleTier.ShowTicks: " + view.TopTimescaleTier.ShowTicks);
            Console.WriteLine("TopTimescaleTier.Label: " + view.TopTimescaleTier.Label); 
            //ExEnd:ReadSpecificGanttChartViewData
        }
        
        [Test]
        public void SetTimeScaleCount()
        {
            //ExStart:SetTimeScaleCount
            //ExFor: GanttChartView.TopTimescaleTier
            //ExFor: GanttChartView.MiddleTimescaleTier
            //ExFor: GanttChartView.BottomTimescaleTier
            //ExSummary: Shows how to modify timescale tiers.
            var project = new Project();

            // Init Gantt Chart View
            var view = new GanttChartView();
            view.TopTimescaleTier = new TimescaleTier();
            view.MiddleTimescaleTier = new TimescaleTier();
            view.BottomTimescaleTier = new TimescaleTier();

            // Set Time Scale count
            view.TopTimescaleTier.Count = 2;
            view.TopTimescaleTier.ShowTicks = false;
            view.MiddleTimescaleTier.Count = 2;
            view.MiddleTimescaleTier.ShowTicks = false;
            view.BottomTimescaleTier.Count = 2;
            view.BottomTimescaleTier.ShowTicks = false;
            
            // Add Gantt Chart View to project
            project.Views.Add(view);

            // Add some test data to project
            var task1 = project.RootTask.Children.Add("Task 1");
            var task2 = project.RootTask.Children.Add("Task 2");
            task1.Set(Tsk.Duration, task1.ParentProject.GetDuration(24, TimeUnitType.Hour));
            task2.Set(Tsk.Duration, task1.ParentProject.GetDuration(40, TimeUnitType.Hour));
            project.Save(OutDir + "SetTimeScaleCount_out.pdf", SaveFileFormat.PDF); 
            //ExEnd:SetTimeScaleCount
        }
    }
}