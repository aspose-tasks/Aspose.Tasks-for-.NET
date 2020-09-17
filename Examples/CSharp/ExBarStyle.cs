namespace Aspose.Tasks.Examples.CSharp
{
    using System.Collections.Generic;
    using System.Drawing;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExBarStyle : ApiExampleBase
    {
        [Test]
        public void WorkWithBarStyle()
        {
            // ExStart
            // ExFor: BarStyle
            // ExFor: BarStyle.#ctor
            // ExFor: BarStyle.ItemType
            // ExFor: BarStyle.BarColor
            // ExFor: BarStyle.BarShape
            // ExFor: BarStyle.StartShape
            // ExFor: BarStyle.StartShapeColor
            // ExFor: BarStyle.EndShape
            // ExFor: BarStyle.EndShapeColor
            // ExFor: BarStyle.TextStyle
            // ExFor: BarStyle.BarTextConverter
            // ExFor: BarStyle.TaskToBarTextConverter
            // ExFor: BarShape
            // ExFor: Shape
            // ExSummary: Shows how to use custom bar styles.
            var project = new Project(DataDir + "Project2.mpp");
            SaveOptions options = new PdfSaveOptions
            {
                BarStyles = new List<BarStyle>()
            };
            
            // add a bar style for milestone tasks
            var style = new BarStyle();
            // set <see cref="T:Aspose.Tasks.Visualization.BarItemType" /> of the bar style
            style.ItemType = BarItemType.Milestone;
            // set <see cref="T:System.Drawing.Color" /> of the bar style.
            style.BarColor = Color.Green;
            // set <see cref="P:Aspose.Tasks.Visualization.BarStyle.BarShape" /> of the bar style
            style.BarShape = BarShape.HalfHeight;
            // set <see cref="T:Aspose.Tasks.Visualization.Shape" /> at the beginning of the bar
            style.StartShape = Shape.LeftBracket;
            // set <see cref="T:System.Drawing.Color" /> of the shape at the beginning of the bar
            style.StartShapeColor = Color.Aqua;
            // set <see cref="T:Aspose.Tasks.Visualization.Shape" /> at the end of the bar
            style.EndShape = Shape.RightBracket;
            // set <see cref="T:System.Drawing.Color" /> of the shape at the end of the bar
            style.EndShapeColor = Color.Aquamarine;
            // set of the text to render on the right of the bar.
            style.TextStyle = new TextStyle();
            style.TextStyle.BackgroundColor = Color.Black;
            
            // there is exists a feature that allow to convert a text of the bar
            // lets set converter to get text for the bar to render.
            style.BarTextConverter = task =>
            {
                if (!task.Get(Tsk.Name).StartsWith("T"))
                {
                    task.Set(Tsk.Name, "T" + task.Get(Tsk.Name));
                }

                return task.Get(Tsk.Name);
            };

            options.BarStyles.Add(style);

            // save the project
            project.Save(OutDir + "WorkWithBarStyle_out.mpp", options);
            // ExEnd
        }
    }
}