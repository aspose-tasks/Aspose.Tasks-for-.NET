namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExWbsCodeDefinition : ApiExampleBase
    {
        [Test]
        public void AddWbsCodeDefinition()
        {
            // ExStart:AddWbsCodeDefinition
            // ExFor: WBSCodeDefinition
            // ExFor: WBSCodeDefinition.#ctor
            // ExFor: WBSCodeDefinition.CodeMaskCollection
            // ExFor: WBSCodeDefinition.GenerateWBSCode
            // ExFor: WBSCodeDefinition.VerifyUniqueness
            // ExFor: WBSCodeDefinition.CodePrefix
            // ExSummary: Shows how to add WBS code masks.
            var project = new Project();

            project.WBSCodeDefinition = new WBSCodeDefinition();
            project.WBSCodeDefinition.GenerateWBSCode = true;
            project.WBSCodeDefinition.VerifyUniqueness = true;
            project.WBSCodeDefinition.CodePrefix = "CRS-";

            var mask = new WBSCodeMask();
            mask.Length = 2;
            mask.Separator = "-";
            mask.Sequence = WBSSequence.OrderedNumbers;
            project.WBSCodeDefinition.CodeMaskCollection.Add(mask);

            mask = new WBSCodeMask();
            mask.Length = 1;
            mask.Separator = "-";
            mask.Sequence = WBSSequence.OrderedUppercaseLetters;
            project.WBSCodeDefinition.CodeMaskCollection.Add(mask);

            var tsk = project.RootTask.Children.Add("Task 1");
            tsk.Children.Add("Task 2");

            project.Recalculate();

            project.Save(OutDir + @"AddWBSCodes_out.xml", SaveFileFormat.Xml);

            // ExEnd:AddWbsCodeDefinition
        }
    }
}
