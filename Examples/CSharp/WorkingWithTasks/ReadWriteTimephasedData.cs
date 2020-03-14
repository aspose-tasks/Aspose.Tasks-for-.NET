using System;
using System.Collections.Generic;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    class ReadWriteTimephasedData
    {
        public static void Run()
        {
            //ExStart:ReadWriteTimephasedData
            // Create project instance
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            Project project1 = new Project(dataDir + "ReadWriteTimephasedData.mpp");

            // Set project properties
            project1.Set(Prj.StartDate, new DateTime(2013, 10, 30, 9, 0, 0));
            project1.Set(Prj.NewTasksAreManual, false);

            // Add task and resources
            Task task = project1.RootTask.Children.Add("Task");
            Resource rsc = project1.Resources.Add("Rsc");

            // Set resource rates and task duration
            rsc.Set(Rsc.StandardRate, 10);
            rsc.Set(Rsc.OvertimeRate, 15);            
            task.Set(Tsk.Duration, project1.GetDuration(6));

            // Create resource assignment
            ResourceAssignment assn = project1.ResourceAssignments.Add(task, rsc);
            assn.Set(Asn.Stop, DateTime.MinValue);
            assn.Set(Asn.Resume, DateTime.MinValue);

            // Set Backloaded contour, it increases task duration from 6 to 10 days
            assn.Set(Asn.WorkContour, WorkContourType.BackLoaded);

            project1.SetBaseline(BaselineType.Baseline);
            task.Set(Tsk.PercentComplete, 50);

            // Read timephased data
            List<TimephasedData> td = assn.GetTimephasedData(assn.Get(Asn.Start), assn.Get(Asn.Finish), TimephasedDataType.AssignmentRemainingWork).ToList();
            Console.WriteLine(td.Count);
            foreach (TimephasedData timePhasedValue in td)
            {                    
                Console.WriteLine(timePhasedValue.Value);
            }
            //ExEnd:ReadWriteTimephasedData
        }
    }
}
