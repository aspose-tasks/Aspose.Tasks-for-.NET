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
                ShowFor = "1",
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
        public void SetTimeScaleCount()
        {
            // ExStart:SetTimeScaleCount
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

            // ExEnd:SetTimeScaleCount
        }
    }
}