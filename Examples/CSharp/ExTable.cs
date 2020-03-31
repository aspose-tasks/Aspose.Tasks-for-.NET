namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Drawing;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExTable : ApiExampleBase
    {
        [Test]
        public void ConfigureGanttChart()
        {
            try
            {
                //ExStart:ConfigureGanttChart
                //ExFor: Table
                //ExFor: Table.TableFields
                //ExSummary: Shows how to work project's tables.
                var project = new Project(DataDir + "Project5.mpp");
                var task = project.RootTask.Children.Add("New Activity");

                // Define new custom attribute
                var definition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Text1, null);
                project.ExtendedAttributes.Add(definition);
                // Add custom text attribute to created task.
                task.ExtendedAttributes.Add(definition.CreateExtendedAttribute("Activity attribute"));

                // Customize table by adding text attribute field
                var field = new TableField();
                field.Field = Field.TaskText1;
                field.Width = 20;
                field.Title = "Custom attribute";
                field.AlignTitle = StringAlignment.Center;
                field.AlignData = StringAlignment.Center;

                var table = project.Tables.ToList()[0];
                table.TableFields.Insert(3, field);

                project.Save(OutDir + @"ConfigureGantChart_out.mpp", new MPPSaveOptions { WriteViewData = true });
                //ExEnd:ConfigureGanttChart
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}