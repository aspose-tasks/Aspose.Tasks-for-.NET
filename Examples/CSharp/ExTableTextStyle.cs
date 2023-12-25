namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExTableTextStyle : ApiExampleBase
    {
        [Test]
        public void WorkWithTableTextStyle()
        {
            try
            {
                // ExStart:WorkWithTableTextStyle
                // ExFor: TableTextStyle
                // ExFor: TableTextStyle.#ctor(Int32)
                // ExFor: TableTextStyle.Field
                // ExFor: TableTextStyle.ItemType
                // ExFor: TableTextStyle.RowUid
                // ExFor: Field
                // ExSummary: Shows how to customize table text styles which are used to style different text items in a project.
                var project = new Project(DataDir + "Project2.mpp");
                project.Set(Prj.NewTasksAreManual, false);

                var view = (GanttChartView)project.Views.ToList()[0];

                // set first task name text style
                var style1 = new TableTextStyle(1);
                // set a field the style is to be applied to.
                style1.Field = Field.TaskName;
                // set <see cref="P:Aspose.Tasks.Visualization.TextStyle.Font" /> of the text style.
                style1.Font = new FontDescriptor("Impact", 12F, FontStyles.Bold | FontStyles.Italic);
                // set size in points of the text style font.

                // set second task duration text style
                var style2 = new TableTextStyle(2);
                style2.Field = Field.TaskDurationText;
                style2.Font = new FontDescriptor("Impact", 16F, FontStyles.Underline);
            
                view.TableTextStyles.Add(style1);
                view.TableTextStyles.Add(style2);

                SimpleSaveOptions options = new MPPSaveOptions
                {
                    // set a flag indicating that view data must be written
                    WriteViewData = true
                };
                project.Save(OutDir + "WorkWithTableTextStyle_out.mpp", options);

                // ExEnd:WorkWithTableTextStyle
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}