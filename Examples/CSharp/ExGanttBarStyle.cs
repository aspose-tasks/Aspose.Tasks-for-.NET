﻿namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using Aspose.Tasks.Saving;
    using NUnit.Framework;
    using Visualization;

    [TestFixture]
    public class ExGanttBarStyle: ApiExampleBase
    {
        [Test]
        public void WorkWithGanttBarStyle()
        {
            // ExStart:ReadCustomBarStyle
            // ExFor: GanttBarStyle
            // ExFor: GanttBarStyle.#ctor
            // ExFor: GanttBarStyle.LeftField
            // ExFor: GanttBarStyle.TopField
            // ExFor: GanttBarStyle.InsideField
            // ExFor: GanttBarStyle.RightField
            // ExFor: GanttBarStyle.BottomField
            // ExFor: GanttBarStyle.MiddleShape
            // ExFor: GanttBarStyle.MiddleFillPattern
            // ExFor: GanttBarStyle.MiddleShapeColor
            // ExFor: GanttBarStyle.StartShapeType
            // ExFor: GanttBarStyle.EndShape
            // ExFor: GanttBarStyle.EndShapeColor
            // ExFor: GanttBarStyle.EndShapeType
            // ExFor: GanttBarStyle.StartShapeColor
            // ExFor: GanttBarStyle.StartShape
            // ExFor: GanttBarStyle.ParentStyle
            // ExFor: GanttChartView.BarStyles
            // ExFor: GanttBarStyle.From
            // ExFor: GanttBarStyle.To
            // ExFor: GanttBarStyle.Row
            // ExFor: GanttBarType
            // ExSummary: Shows how to read custom bar styles of a view. 
            var project = new Project(DataDir + "CustomBarStyle.mpp");

            var view = (GanttChartView)project.DefaultView;
            Console.WriteLine("Custom bar styles count: {0}", view.CustomBarStyles.Count);

            var style1 = view.CustomBarStyles[0];
            Console.WriteLine("Style1.ParentStyle Name: {0}", style1.ParentStyle.Name);
            Console.WriteLine("Style1.LeftField: {0}", style1.LeftField);
            Console.WriteLine("Style1.RightField: {0}", style1.RightField);
            Console.WriteLine("Style1.TopField: {0}", style1.TopField);
            Console.WriteLine("Style1.BottomField: {0}", style1.BottomField);
            Console.WriteLine("Style1.InsideField: {0}", style1.InsideField);
            Console.WriteLine("Style1.From: {0}", style1.From);
            Console.WriteLine("Style1.To: {0}", style1.To);
            Console.WriteLine("Style1.Row: {0}", style1.Row);

            var style2 = view.CustomBarStyles[1];
            Console.WriteLine("Style2.LeftField: {0}", style2.LeftField);
            Console.WriteLine("Style2.RightField: {0}", style2.RightField);
            Console.WriteLine("Style2.TopField: {0}", style2.TopField);
            Console.WriteLine("Style2.BottomField: {0}", style2.BottomField);
            Console.WriteLine("Style2.InsideField: {0}", style2.InsideField);
            Console.WriteLine("Style2.From: {0}", style2.From);
            Console.WriteLine("Style2.To: {0}", style2.To);
            Console.WriteLine("Style2.Row: {0}", style1.Row);

            var style3 = view.CustomBarStyles[2];
            Console.WriteLine("Style3.LeftField: {0}", style3.LeftField);
            Console.WriteLine("Style3.RightField: {0}", style3.RightField);
            Console.WriteLine("Style3.TopField: {0}", style3.TopField);
            Console.WriteLine("Style3.BottomField: {0}", style3.BottomField);
            Console.WriteLine("Style3.InsideField: {0}", style3.InsideField);

            Console.WriteLine("Style3.StartShape: {0}", style3.StartShape);
            Console.WriteLine("Style3.StartShapeType: {0}", style3.StartShapeType);
            Console.WriteLine("Style3.StartShapeColor: {0}", style3.StartShapeColor);

            Console.WriteLine("Style3.EndShape: {0}", style3.EndShape);
            Console.WriteLine("Style3.EndShapeType: {0}", style3.EndShapeType);
            Console.WriteLine("Style3.EndShapeColor: {0}", style3.EndShapeColor);

            Console.WriteLine("Style3.MiddleShape: {0}", style3.MiddleShape);
            Console.WriteLine("Style3.MiddleFillPattern: {0}", style3.MiddleFillPattern);
            Console.WriteLine("Style3.MiddleShapeColor: {0}", style3.MiddleShapeColor);
            Console.WriteLine("Style3.From: {0}", style3.From);
            Console.WriteLine("Style3.To: {0}", style3.To);
            Console.WriteLine("Style3.Row: {0}", style1.Row);

            // ExEnd:ReadCustomBarStyle
        }
        
        [Test]
        public void TestCanAddCommonBarStyle2010()
        {
            // ExStart
            // ExFor: GanttBarShowFor
            // ExFor: GanttBarStyle.Name
            // ExFor: GanttBarStyle.ShowForCategories
            // ExFor: GanttBarStyle.ShowForTaskUid
            // ExSummary: Shows how to use ShowFor categories.

            var project = new Project(DataDir + "Project2.mpp");
            var view = (GanttChartView)project.DefaultView;

            var barStyle = this.GetCustomBarStyle();
            barStyle.ShowForTaskUid = null;

            var showForCategories = new[]
            {
                GanttBarShowFor.Active,
                GanttBarShowFor.NotSummary,
                GanttBarShowFor.Milestone,
                GanttBarShowFor.Finished
            };
            
            barStyle.ShowForCategories = new List<GanttBarShowFor>(showForCategories);
            barStyle.Name = "My common style";
            view.BarStyles.Add(barStyle);

            // work with project...

            // ExEnd
        }

        [Test]
        public void CustomizeGanttChartViewBarStyles()
        {
            // ExStart
            // ExFor: GanttBarStyle
            // ExFor: GanttBarStyle.MiddleShapeColor
            // ExFor: GanttBarStyle.MiddleShape
            // ExFor: GanttBarStyle.StartShape
            // ExFor: GanttBarStyle.StartShapeColor
            // ExFor: GanttBarStyle.EndShape
            // ExFor: GanttBarStyle.EndShapeColor
            // ExFor: Aspose.Tasks.Visualization.TaskBarTextConverter
            // ExFor: GanttBarStyle.LeftBarTextConverter
            // ExFor: GanttBarStyle.RightBarTextConverter
            // ExFor: GanttBarStyle.TopBarTextConverter
            // ExFor: GanttBarStyle.BottomBarTextConverter
            // ExFor: GanttBarStyle.InsideBarTextConverter
            // ExFor: GanttBarMiddleShape
            // ExFor: GanttBarEndShape
            // ExSummary: Shows how to use custom bar styles of Gantt Chart view.
            var project = new Project(DataDir + "Project2.mpp");

            var ganttChartView = (GanttChartView)project.Views.First(v => v.Name == "Gantt &Chart");
            PdfSaveOptions saveOptions = new PdfSaveOptions();
            saveOptions.Timescale = Timescale.DefinedInView;
            saveOptions.ViewSettings = ganttChartView;

            // Bar styles can be either task-specific (located in GanttChartView.CustomBarStyles)
            // of category-specific (located in GanttChartView.BarStyles)
            foreach (GanttBarStyle ganttBarStyle in ganttChartView.CustomBarStyles)
            {
                if (ganttBarStyle.ShowForTaskUid != 4)
                {
                    continue;
                }

                // For demonstration purposes we are modifying style for Task with Unique ID = 4
                // Here we set field (TaskName) to render to the left of the task bar.
                ganttBarStyle.LeftField = Field.TaskName;
                // Here we set custom converter to control which text should be rendered inside the task bar.
                ganttBarStyle.InsideBarTextConverter = task => "Hours rem.: " + (int)task.Get(Tsk.RemainingWork).TimeSpan.TotalHours;

                ganttBarStyle.MiddleShapeColor = Color.Green;
                ganttBarStyle.MiddleShape = GanttBarMiddleShape.LineTop;
                ganttBarStyle.StartShape = GanttBarEndShape.LeftBracket;
                ganttBarStyle.StartShapeColor = Color.Aqua;
                ganttBarStyle.EndShape = GanttBarEndShape.RightBracket;
                ganttBarStyle.EndShapeColor = Color.Aquamarine;
            }

            foreach (GanttBarStyle ganttBarStyle in ganttChartView.BarStyles)
            {
                if (!ganttBarStyle.ShowForCategories.Contains(GanttBarShowFor.Milestone))
                {
                    continue;
                }

                // For demonstration purposes we are modifying styles applicable to milestone tasks.

                ganttBarStyle.StartShape = GanttBarEndShape.Diamond;
                ganttBarStyle.RightField = Field.TaskActualFinish;
                ganttBarStyle.TopBarTextConverter = task => task.Get(Tsk.ActualStart).Day.ToString();
            }

            project.Save(OutDir + "WorkWithGanttChartViewBarStyles_out.pdf", saveOptions);
            // ExEnd
        }

        private GanttBarStyle GetCustomBarStyle()
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
    }
}