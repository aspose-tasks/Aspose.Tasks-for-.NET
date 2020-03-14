using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    class CreateMultipleResourceAssignmentsForOneTask
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:CreateMultipleResourceAssignmentsForOneTask
            Project project = new Project(dataDir + "TemplateResource2010.mpp")
            {
                CalculationMode = CalculationMode.Automatic
            };

            project.Set(Prj.DateFormat, DateFormat.DateDddMmDdYy);
            project.Set(Prj.StartDate, new DateTime(2019, 9, 16, 9, 0, 0));
            project.Set(Prj.NewTasksAreManual, false);
            project.Set(Prj.ActualsInSync, false);

            Resource workResource = project.Resources.Add("Servente (Work)");
            workResource.Set(Rsc.Name, "Servente (Work)");
            workResource.Set(Rsc.Initials, "S");
            workResource.Set(Rsc.Type, ResourceType.Work);
            workResource.Set(Rsc.StandardRateFormat, RateFormatType.Hour);
            workResource.Set(Rsc.Code, "1503");

            Resource materialResource = project.Resources.Add("Tijolo (Material)");
            materialResource.Set(Rsc.Name, "Tijolo (Material)");
            materialResource.Set(Rsc.Initials, "T");
            materialResource.Set(Rsc.Type, ResourceType.Material);
            materialResource.Set(Rsc.StandardRateFormat, RateFormatType.MaterialResourceRate);
            materialResource.Set(Rsc.Code, "21341");

            Task tsk1 = project.RootTask.Children.Add("Task - 01");
            tsk1.Set(Tsk.IsRollup, new NullableBool(true));
            tsk1.Set(Tsk.IsPublished, new NullableBool(false));
            Task tsk2 = tsk1.Children.Add("Task - 01.01");
            tsk2.Set(Tsk.IsRollup, new NullableBool(true));
            tsk2.Set(Tsk.IsPublished, new NullableBool(false));
            Task tsk3 = tsk2.Children.Add("Task - 01.01.001");
            tsk3.Set(Tsk.IsEstimated, new NullableBool(false));
            tsk3.Set(Tsk.Start, new DateTime(2019, 9, 16, 9, 0, 0));
            tsk3.Set(Tsk.Duration, project.GetDuration(10, TimeUnitType.Day));
            tsk3.Set(Tsk.Work, project.GetDuration(10, TimeUnitType.Day));
            tsk3.Set(Tsk.IsRollup, new NullableBool(true));
            tsk3.Set(Tsk.IsPublished, new NullableBool(false));

            ResourceAssignment assignment1 = project.ResourceAssignments.Add(tsk3, materialResource);
            assignment1.Set(Asn.Delay, project.GetDuration(40, TimeUnitType.Hour));
            assignment1.Set(Asn.Start, new DateTime(2019, 9, 23, 9, 0, 0));
            assignment1.Set(Asn.Finish, new DateTime(2019, 9, 27, 18, 0, 0));
            ResourceAssignment assignment2 = project.ResourceAssignments.Add(tsk3, workResource);
            assignment2.Set(Asn.Work, project.GetDuration(56, TimeUnitType.Hour));
            assignment2.Set(Asn.Start, new DateTime(2019, 9, 16, 9, 0, 0));
            assignment2.Set(Asn.Finish, new DateTime(2019, 9, 24, 18, 0, 0));

            // to match expected MPP fully
            assignment2.Set(Asn.WorkContour, WorkContourType.Contoured);
            tsk3.Set(Tsk.IsManual, new NullableBool(true));
            tsk1.Set(Tsk.IsManual, new NullableBool(true));

            project.Save(dataDir + @"Assignment_Dates.mpp", Saving.SaveFileFormat.MPP);
            //ExEnd:CreateMultipleResourceAssignmentsForOneTask
        }
    }
}
