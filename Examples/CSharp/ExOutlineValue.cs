namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExOutlineValue : ApiExampleBase
    {
        [Test]
        public void CheckOutlineCodeIdUniqueness()
        {
            try
            {
                //ExStart:CheckOutlineCodeIdUniqueness
                //ExFor: OutlineValue
                //ExSummary: Shows how to work with outline values.
                var project = new Project(DataDir + "OutlineValues2010.mpp");

                var outline = new OutlineCodeDefinition();
                outline.FieldId = ExtendedAttributeTask.OutlineCode7.ToString("D");
                outline.Alias = "My Outline Code";

                project.OutlineCodes.Add(outline);

                var mask = new OutlineMask();
                mask.Type = MaskType.Characters;
                outline.Masks.Add(mask);

                var value = new OutlineValue();
                value.Value = "Text value 1";
                value.ValueId = 1;
                value.Type = OutlineValueType.Text;
                value.Description = "Text value descr 1";
                outline.Values.Add(value);

                project.Save(OutDir + "MultipleOutlineValues.mpp", SaveFileFormat.MPP);
                //ExEnd:CheckOutlineCodeIdUniqueness
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}