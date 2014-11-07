//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using System.Collections;
using System;

namespace SavingUpdatedResource
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
                     
            ProjectReader reader = new ProjectReader();
            
            // This is a project with one task and one resource without assignments
            Project project = reader.Read(dataDir + "project.mpp");

            Task task = project.RootTask.Children[0] as Task;
            Resource resource = project.Resources[1] as Resource;

            // Add new assignment and recalculate project
            project.ResourceAssignments = new ArrayList(1);
            ResourceAssignment ra = new ResourceAssignment();
            ra.Units = 1d;
            ra.Start = task.Start;
            ra.Stop = ra.Resume = ra.Start;
            ra.Task = task;
            ra.Resource = resource;
            ra.Work = ra.RegularWork = ra.RemainingWork = new TimeSpan(16, 0, 0);

            ra.Finish = task.Calendar.GetFinishDateByStartAndWork(ra.Start, new TimeSpan(16, 0, 0));
            project.ResourceAssignments.Add(ra);

            task.Duration = task.RemainingWork = ra.Work;
            task.Finish = project.Calendar.GetFinishDateByStartAndWork(task.Start, task.Duration);

            //Recalculate the Project now
            project.CalcTaskIds();
            project.CalcTaskUids();
            project.CalcResourceIds();
            project.CalcResourceUids();
            project.CalcResourceAssignmentIds();
            project.CalcResourceAssignmentUids();
            project.CalcCalendarUids();
            project.UpdateReferences();

            //Update the Resource Assignment data now
            ra.WorkContour = WorkContourType.Flat;
            ra.TimephasedData = new ArrayList();
            TimephasedData td = new TimephasedData();
            td.Uid = 1;
            td.Start = ra.Start;
            td.Finish = ra.Start.AddHours(9);
            td.Value = "PT8H0M0S";
            td.Unit = TimeUnitType.Day;
            td.TimephasedDataType = TimephasedDataType.AssignmentRemainingWork;
            ra.TimephasedData.Add(td);
            td = new TimephasedData();
            td.Uid = 2;
            td.Start = ra.Start.AddDays(1);
            td.Finish = ra.Start.AddDays(1).AddHours(9);
            td.Value = "PT8H0M0S";
            td.Unit = TimeUnitType.Day;
            td.TimephasedDataType = TimephasedDataType.AssignmentRemainingWork;
            ra.TimephasedData.Add(td);

            //Save the Project
            project.Save(dataDir + "Project1.Mpp", Aspose.Tasks.Saving.SaveFileFormat.MPP);

        }
    }
}