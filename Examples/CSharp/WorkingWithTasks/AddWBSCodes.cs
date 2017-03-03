using Aspose.Tasks.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    class AddWBSCodes
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:AddWBSCodes
            Project proj = new Project();

            proj.WBSCodeDefinition = new WBSCodeDefinition();
            proj.WBSCodeDefinition.GenerateWBSCode = true;
            proj.WBSCodeDefinition.VerifyUniqueness = true;
            proj.WBSCodeDefinition.CodePrefix = "CRS-";

            WBSCodeMask mask = new WBSCodeMask();
            mask.Length = 2;
            mask.Separator = "-";
            mask.Sequence = WBSSequence.OrderedNumbers;
            proj.WBSCodeDefinition.CodeMaskCollection.Add(mask);

            mask = new WBSCodeMask();
            mask.Length = 1;
            mask.Separator = "-";
            mask.Sequence = WBSSequence.OrderedUppercaseLetters;
            proj.WBSCodeDefinition.CodeMaskCollection.Add(mask);
            
            Task tsk = proj.RootTask.Children.Add("Task 1");
            Task child = tsk.Children.Add("Task 2");

            proj.Recalculate();
            proj.Save(dataDir + @"AddWBSCodes_out.xml", SaveFileFormat.XML);
            // ExEnd:AddWBSCodes
        }
    }
}
