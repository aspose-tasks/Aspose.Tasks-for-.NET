namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Miscellaneous
{
    using System;

    public class WorkWithBaselineSaveTime
    {
        public static void Run()
        {
            //ExStart:WorkWithBaselineSaveTime
            //ExFor: Project.SetBaselineSaveTime(BaselineType,DateTime)
            //ExFor: Project.GetBaselineSaveTime(BaselineType)
            //ExSummary: Shows how to read/write project's baseline save time.
            var project = new Project();
            var baselineSave = project.GetBaselineSaveTime(BaselineType.Baseline);
            Console.WriteLine("Baseline save time before: " + baselineSave);
            
            // set baseline save time
            project.SetBaselineSaveTime(BaselineType.Baseline, DateTime.Today);
            
            var baselineSaveNew = project.GetBaselineSaveTime(BaselineType.Baseline);
            Console.WriteLine("Baseline save time after: " + baselineSaveNew);
            //ExEnd:WorkWithBaselineSaveTime
        }
    }
}