namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using Aspose.Tasks.Saving;

    internal class AddWBSCodes
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:AddWBSCodes
            var proj = new Project();

            proj.WBSCodeDefinition = new WBSCodeDefinition();
            proj.WBSCodeDefinition.GenerateWBSCode = true;
            proj.WBSCodeDefinition.VerifyUniqueness = true;
            proj.WBSCodeDefinition.CodePrefix = "CRS-";

            var mask = new WBSCodeMask();
            mask.Length = 2;
            mask.Separator = "-";
            mask.Sequence = WBSSequence.OrderedNumbers;
            proj.WBSCodeDefinition.CodeMaskCollection.Add(mask);

            mask = new WBSCodeMask();
            mask.Length = 1;
            mask.Separator = "-";
            mask.Sequence = WBSSequence.OrderedUppercaseLetters;
            proj.WBSCodeDefinition.CodeMaskCollection.Add(mask);
            
            var tsk = proj.RootTask.Children.Add("Task 1");
            tsk.Children.Add("Task 2");

            proj.Recalculate();
            proj.Save(dataDir + @"AddWBSCodes_out.xml", SaveFileFormat.XML);
            //ExEnd:AddWBSCodes
        }
    }
}
