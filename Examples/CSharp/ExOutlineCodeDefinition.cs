namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExOutlineCodeDefinition : ApiExampleBase
    {
        [Test]
        public void CheckOutlineCodeIdUniqueness()
        {
            try
            {
                //ExStart:CheckOutlineCodeIdUniqueness
                //ExFor: OutlineCodeDefinition
                //ExFor: OutlineCodeDefinition.#ctor
                //ExFor: OutlineCodeDefinition.FieldId
                //ExFor: OutlineCodeDefinition.Alias
                //ExSummary:  how to work with outline code definitions.
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
        
        [Test]
        public void UpdateOutlineCodes()
        {
            try
            {
                //ExStart:UpdateOutlineCodes
                //ExFor: OutlineCodeDefinition.Values
                //ExSummary: Shows how to create new outline codes.
                var project = new Project(DataDir + "project.mpp");
                 
                // Define outline code and its outline mask
                var code1 = new OutlineCodeDefinition();
                code1.Alias = "New task outline code1";
                code1.FieldId = ((int)ExtendedAttributeTask.OutlineCode1).ToString();
                code1.FieldName = "Outline Code1";
                var mask = new OutlineMask();
                mask.Separator = "+";
                mask.Level = 1;
                mask.Type = MaskType.Numbers;
                code1.Masks.Add(mask);

                // Add outline value
                var value = new OutlineValue();
                value.Description = "Value description";
                value.ValueId = 1;
                value.Value = "123456";
                value.Type = OutlineValueType.Number;
                code1.Values.Add(value);

                // Add outline code to project
                project.OutlineCodes.Add(code1);

                // Define outline code and its outline mask
                var code2 = new OutlineCodeDefinition();
                code2.Alias = "New rsc outline code2";
                code2.FieldId = ((int)ExtendedAttributeResource.OutlineCode2).ToString();
                code2.FieldName = "Outline Code2";
                var mask2 = new OutlineMask();
                mask2.Separator = "/";
                mask2.Level = 1;
                mask2.Type = MaskType.Numbers;
                code2.Masks.Add(mask2);

                // Add outline value
                var value2 = new OutlineValue();
                value2.Description = "Value2 description";
                value2.ValueId = 2;
                value2.Value = "987654";
                value2.Type = OutlineValueType.Number;
                code2.Values.Add(value2);

                // Add outline code to project
                project.OutlineCodes.Add(code2);

                project.Save(OutDir + "Updated_project_out.mpp", SaveFileFormat.MPP);
                //ExEnd:UpdateOutlineCodes
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }         
        }
    }
}