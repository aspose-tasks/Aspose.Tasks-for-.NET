namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;

    [TestFixture]
    public class ExOutlineMask : ApiExampleBase
    {
        [Test]
        public void WorkWithOutlineMask()
        {
            // ExStart:WorkWithOutlineMask
            // ExFor: OutlineMask
            // ExFor: OutlineMask.#ctor
            // ExFor: OutlineMask.Type
            // ExFor: OutlineMask.Separator
            // ExFor: OutlineMask.Level
            // ExFor: OutlineMask.Length
            // ExSummary: Shows how to work with outline masks.
            var project = new Project(DataDir + "OutlineValues2010.mpp");

            var outline = new OutlineCodeDefinition();
            outline.FieldId = ExtendedAttributeTask.OutlineCode7.ToString("D");
            outline.Alias = "My Outline Code";

            project.OutlineCodes.Add(outline);

            var mask = new OutlineMask();

            // set the type of a mask
            mask.Type = MaskType.Characters;

            // set the separator of code values
            mask.Separator = "/";

            // set the level of a mask
            mask.Level = 1;

            // set the maximum length (in characters) of the outline code values. 0 if length is not defined.
            mask.Length = 2;

            // add the mask to the definition
            outline.Masks.Add(mask);

            var value = new OutlineValue();
            value.Value = "Text value 1";
            value.ValueId = 1;
            value.Type = OutlineValueType.Text;
            value.Description = "Text value descr 1";
            outline.Values.Add(value);

            // ...
            // ExEnd:WorkWithOutlineMask
        }
    }
}