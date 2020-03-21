namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using Aspose.Tasks.Saving;

    internal class AddWBSCodes
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:AddWBSCodes
            //ExFor: Project.WBSCodeDefinition
            //ExFor: Project.WBSCodeDefinition.CodeMaskCollection
            //ExFor: WBSCodeMask
            //ExSummary: Shows how to add WBS codes.
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

            project.Save(dataDir + @"AddWBSCodes_out.xml", SaveFileFormat.XML);
            //ExEnd:AddWBSCodes
        }
    }
}
