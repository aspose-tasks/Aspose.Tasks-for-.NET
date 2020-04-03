namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExWbsCodeMask : ApiExampleBase
    {
        [Test]
        public void CreateWbsCodeMask()
        {
            //ExStart:CreateWbsCodeMask
            //ExFor: WBSCodeMask
            //ExFor: WBSCodeMask.#ctor
            //ExFor: WBSCodeMask.Length
            //ExFor: WBSCodeMask.Level
            //ExFor: WBSCodeMask.Separator
            //ExFor: WBSCodeMask.Sequence
            //ExSummary: Shows how to create WBS code masks.
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
            
            var task = project.RootTask.Children.Add("Task 1");
            task.Children.Add("Task 2");

            project.Recalculate();

            Console.WriteLine("Number of WBS masks: " + project.WBSCodeDefinition.CodeMaskCollection.Count);
            int i = 0;
            foreach (var cm in project.WBSCodeDefinition.CodeMaskCollection)
            {
                Console.WriteLine("WBS Mask #{0}: Level->{1}", ++i, cm.Level);
            }

            project.Save(OutDir + @"AddWBSCodes_out.xml", SaveFileFormat.XML);
            //ExEnd:CreateWbsCodeMask
        }
    }
}