namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using System;
    using System.Collections.Generic;

    internal class ReadWriteTimephasedData
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:ReadWriteTimephasedData
            //ExFor: Asn.WorkContour
            //ExFor: ResourceAssignment.GetTimephasedData(DateTime, DateTime)
            //ExFor: ResourceAssignment.GetTimephasedData(DateTime, DateTime, TimephasedDataType)
            //ExSummary: Shows how to read timephased data of a resource assignment.
            var project = new Project(dataDir + "ReadWriteTimephasedData.mpp");

            // Set project properties
            project.Set(Prj.StartDate, new DateTime(2013, 10, 30, 9, 0, 0));
            project.Set(Prj.NewTasksAreManual, false);

            // Add task and resources
            var task = project.RootTask.Children.Add("Task");
            var rsc = project.Resources.Add("Rsc");

            // Set resource rates and task duration
            rsc.Set(Rsc.StandardRate, 10);
            rsc.Set(Rsc.OvertimeRate, 15);            
            task.Set(Tsk.Duration, project.GetDuration(6));

            // Create resource assignment
            var assn = project.ResourceAssignments.Add(task, rsc);
            assn.Set(Asn.Stop, DateTime.MinValue);
            assn.Set(Asn.Resume, DateTime.MinValue);

            // Set Backloaded contour, it increases task duration from 6 to 10 days
            assn.Set(Asn.WorkContour, WorkContourType.BackLoaded);

            project.SetBaseline(BaselineType.Baseline);
            task.Set(Tsk.PercentComplete, 50);

            // Read timephased data
            List<TimephasedData> td = assn.GetTimephasedData(assn.Get(Asn.Start), assn.Get(Asn.Finish), TimephasedDataType.AssignmentRemainingWork).ToList();
            Console.WriteLine(td.Count);
            foreach (var timePhasedValue in td)
            {                    
                Console.WriteLine(timePhasedValue.Value);
            }
            //ExEnd:ReadWriteTimephasedData
        }
    }
}
