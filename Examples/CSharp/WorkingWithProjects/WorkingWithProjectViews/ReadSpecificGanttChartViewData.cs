/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectViews
{
    using System;
    using System.Drawing;

    using Aspose.Tasks.Visualization;

    internal class ReadSpecificGanttChartViewData
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            
            //ExStart:ReadSpecificGanttChartViewData   
            var project = new Project(dataDir + @"ReadSpecificGantChartViewData.mpp"); 

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
    }
}