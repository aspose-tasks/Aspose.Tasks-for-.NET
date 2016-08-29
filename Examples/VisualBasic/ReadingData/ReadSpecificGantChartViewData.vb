Imports System.Drawing
Imports Aspose.Tasks.Visualization

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Tasks.Examples.VisualBasic.ReadingData
    Public Class ReadSpecificGantChartViewData
        Public Shared Sub Run()
            ' ExStart:ReadSpecificGantChartViewData

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ReadingData()
            Dim project As New Project(dataDir & Convert.ToString("Project1.mpp"))
            ' Attached test project
            Dim view As GanttChartView = TryCast(project.Views.ToList()(1), GanttChartView)
            Console.WriteLine("Is Bar Rounding: " + view.BarRounding)
            Console.WriteLine("Show Bar Splits? : " + view.ShowBarSplits)
            Console.WriteLine("Show Drawings? : " + view.ShowDrawings)
            Console.WriteLine("Roll Up Gantt Bars? " + view.RollUpGanttBars)
            Console.WriteLine("Hide Rollup Bars When Summary Expanded: " + view.HideRollupBarsWhenSummaryExpanded)
            Console.WriteLine("Bar Size: " + view.BarSize.ToString())
            Console.WriteLine("Bar Style: " + view.BarStyles.Count)
            Console.WriteLine(vbLf & "************************ RETREIVING BAR STYLES INFORMATION FROM THE VIEW *********************")
            Dim i As Integer = 0
            For Each barStyle As GanttBarStyle In view.BarStyles
                Console.WriteLine("Name: " + barStyle.Name)
                Console.WriteLine("ShowFor: " + barStyle.ShowFor.ToString())
                Console.WriteLine("Row: " + barStyle.Row)
                Console.WriteLine("From: " + barStyle.From)
                Console.WriteLine("To: " + barStyle.[To])
                Console.WriteLine("MiddleShape: " + barStyle.MiddleShape)
                Console.WriteLine("MiddleShapeColor: " + barStyle.MiddleShapeColor.ToString())
                Console.WriteLine("StartShape: " + barStyle.StartShape)
                Console.WriteLine("EndShape: " + barStyle.EndShape)
                Console.WriteLine("EndShapeColor: " + barStyle.EndShapeColor.ToString())
                i += 1
            Next

            Console.WriteLine("Grid Lines Count: " + view.Gridlines.Count)
            Dim gridlines As Gridlines = view.Gridlines(0)
            Console.WriteLine(vbLf & "************************ RETREIVING GRID LINES PROPERTIES *********************")
            Console.WriteLine("GridLine Type: " + gridlines.Type)
            Console.WriteLine("Gridlines Internval: " + gridlines.Interval)
            Console.WriteLine("Gridlines Color: " + gridlines.NormalColor.ToString())
            Console.WriteLine("Gridlines NormalPattern: " + gridlines.NormalPattern)
            Console.WriteLine("Gridlines IntervalPattern: " + gridlines.IntervalPattern)
            Console.WriteLine("Gridlines IntervalColor: " + gridlines.IntervalColor.ToString())
            Console.WriteLine(vbLf & "************************ RETREIVING PROGRESS LINES PROPERTIES *********************")
            Console.WriteLine("ProgressLInes.BeginAtDate: ", view.ProgressLines.BeginAtDate)
            Console.WriteLine("ProgressLines.isBaselinePlan: " + view.ProgressLines.IsBaselinePlan)
            Console.WriteLine("ProgressLines.DisplaySelected: " + view.ProgressLines.DisplaySelected)
            Console.WriteLine("ProgressLines.SelectedDates.Count: " + view.ProgressLines.SelectedDates.Count)
            Console.WriteLine("ProgressLines.SelectedDates[0]: " + view.ProgressLines.SelectedDates(0))
            Console.WriteLine("ProgressLines.SelectedDates[1]: " + view.ProgressLines.SelectedDates(1))
            Console.WriteLine("ProgressLines.SelectedDates[2]: " + view.ProgressLines.SelectedDates(2))
            Console.WriteLine("ProgressLines.DisplayAtRecurringIntervals: " + view.ProgressLines.DisplayAtRecurringIntervals)
            Console.WriteLine("ProgressLines.RecurringInterval.Interval: " + Interval.Weekly.ToString(), view.ProgressLines.RecurringInterval.Interval.ToString())
            Console.WriteLine("ProgressLines.RecurringInterval.WeeklyDays.Count" + view.ProgressLines.RecurringInterval.WeeklyDays.Count)
            Console.WriteLine("Recurring Interval.WeeklyDays: " + view.ProgressLines.RecurringInterval.WeeklyDays.ToString())
            Console.WriteLine("Recurring Interval.DayType.Saturday: " + view.ProgressLines.RecurringInterval.WeeklyDays.ToString())
            Console.WriteLine("Recurring Interval.DayType.Sunday: " + view.ProgressLines.RecurringInterval.WeeklyDays.ToString())
            Console.WriteLine("ProgressLines.ShowDate: " + view.ProgressLines.ShowDate)
            Console.WriteLine("ProgressLines.ProgressPointShape: " + view.ProgressLines.ProgressPointShape.ToString())
            Console.WriteLine("ProgressLines.ProgressPointColor: " + view.ProgressLines.ProgressPointColor.ToString())
            Console.WriteLine("ProgressLines.LineColor: " + Color.Red.ToString(), view.ProgressLines.LineColor)
            Console.WriteLine("ProgressLines.LinePattern: " + LinePattern.Solid.ToString(), view.ProgressLines.LinePattern)
            Console.WriteLine("ProgressLines.OtherProgressPointShape: " + view.ProgressLines.OtherProgressPointShape.ToString())
            Console.WriteLine("ProgressLines.OtherProgressPointColor: " + view.ProgressLines.OtherProgressPointColor.ToString())
            Console.WriteLine("ProgressLines.OtherLineColor: " + view.ProgressLines.OtherLineColor.ToString())
            Console.WriteLine(vbLf & "************************ BOTTOM TIMESCALE IFORMATION ******************")
            Console.WriteLine("BottomTimescaleTier.Count:" + view.BottomTimescaleTier.Count)
            Console.WriteLine("BottomTimescaleTier.Unit:" + TimescaleUnit.Days.ToString(), view.BottomTimescaleTier.Unit.ToString())
            Console.WriteLine("BottomTimescaleTier.UsesFiscalYear: " + view.BottomTimescaleTier.UsesFiscalYear)
            Console.WriteLine("BottomTimescaleTier.Alignment: " + StringAlignment.Center.ToString(), view.BottomTimescaleTier.Alignment.ToString())
            Console.WriteLine("BottomTimescaleTier.ShowTicks: " + view.BottomTimescaleTier.ShowTicks.ToString())
            Console.WriteLine("BottomTimescaleTier.Label:" + DateLabel.Day_di.ToString(), view.BottomTimescaleTier.Label.ToString())
            Console.WriteLine(vbLf & "************************ MIDDLE TIMESCALE IFORMATION ******************")
            Console.WriteLine("MiddleTimescaleTier.Count:" + view.MiddleTimescaleTier.Count)
            Console.WriteLine("MiddleTimescaleTier.Unit:" + TimescaleUnit.Days.ToString(), view.MiddleTimescaleTier.Unit.ToString())
            Console.WriteLine("MiddleTimescaleTier.UsesFiscalYear: " + view.MiddleTimescaleTier.UsesFiscalYear)
            Console.WriteLine("MiddleTimescaleTier.Alignment: " + StringAlignment.Center.ToString(), view.MiddleTimescaleTier.Alignment.ToString())
            Console.WriteLine("MiddleTimescaleTier.ShowTicks: " + view.MiddleTimescaleTier.ShowTicks.ToString())
            Console.WriteLine("MiddleTimescaleTier.Label:" + DateLabel.Day_di.ToString(), view.MiddleTimescaleTier.Label.ToString())
            Console.WriteLine(vbLf & "************************ TOP TIMESCALE IFORMATION ******************")
            Console.WriteLine("TopTimescaleTier.Unit:" + TimescaleUnit.Days.ToString(), view.TopTimescaleTier.Unit.ToString())
            Console.WriteLine("TopTimescaleTier.UsesFiscalYear: " + view.TopTimescaleTier.UsesFiscalYear)
            Console.WriteLine("TopTimescaleTier.Alignment: " + StringAlignment.Center.ToString(), view.TopTimescaleTier.Alignment.ToString())
            Console.WriteLine("TopTimescaleTier.ShowTicks: " + view.TopTimescaleTier.ShowTicks.ToString())
            Console.WriteLine("TopTimescaleTier.Label: ", view.TopTimescaleTier.Label.ToString())
            ' ExEnd:ReadSpecificGantChartViewData
        End Sub
    End Class
End Namespace