using Aspose.Tasks.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.Miscellaneous
{
    class WriteMetadataToMPP
    {
        public static void Run()
        {
            try
            {
                // ExStart:WriteMetadataToMPP
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
                Project project = new Project(dataDir + "Project1.mpp");

                // Add working times to project calendar
                WorkingTime wt = new WorkingTime();
                wt.FromTime = new DateTime(2010, 1, 1, 19, 0, 0);
                wt.ToTime = new DateTime(2010, 1, 1, 20, 0, 0);
                WeekDay day = project.Get(Prj.Calendar).WeekDays.ToList()[1];
                day.WorkingTimes.Add(wt);

                // Change calendar name
                project.Get(Prj.Calendar).Name = "CHANGED NAME!";

                // Add tasks and set task meta data
                Task task = project.RootTask.Children.Add("Task 1");
                task.Set(Tsk.DurationFormat, TimeUnitType.Day);
                task.Set(Tsk.Duration, project.GetDuration(3));
                task.Set(Tsk.Contact, "Rsc 1");
                task.Set(Tsk.IsMarked, true);
                task.Set(Tsk.IgnoreWarnings, true);
                Task task2 = project.RootTask.Children.Add("Task 2");
                task2.Set(Tsk.DurationFormat, TimeUnitType.Day);
                task2.Set(Tsk.Contact, "Rsc 2");

                // Link tasks
                project.TaskLinks.Add(task, task2, TaskLinkType.FinishToStart, project.GetDuration(-1, TimeUnitType.Day));

                // Set project start date
                project.Set(Prj.StartDate, new DateTime(2013, 8, 13, 9, 0, 0));

                // Add resource and set resource meta data
                Resource rsc1 = project.Resources.Add("Rsc 1");
                rsc1.Set(Rsc.Type, ResourceType.Work);
                rsc1.Set(Rsc.Initials, "WR");
                rsc1.Set(Rsc.AccrueAt, CostAccrualType.Prorated);
                rsc1.Set(Rsc.MaxUnits, 1);
                rsc1.Set(Rsc.Code, "Code 1");
                rsc1.Set(Rsc.Group, "Workers");
                rsc1.Set(Rsc.EMailAddress, "1@gmail.com");
                rsc1.Set(Rsc.WindowsUserAccount, "user_acc1");
                rsc1.Set(Rsc.IsGeneric, new NullableBool(true));
                rsc1.Set(Rsc.AccrueAt, CostAccrualType.End);
                rsc1.Set(Rsc.StandardRate, 10);
                rsc1.Set(Rsc.StandardRateFormat, RateFormatType.Day);
                rsc1.Set(Rsc.OvertimeRate, 15);
                rsc1.Set(Rsc.OvertimeRateFormat, RateFormatType.Hour);

                rsc1.Set(Rsc.IsTeamAssignmentPool, true);
                rsc1.Set(Rsc.CostCenter, "Cost Center 1");

                // Create resource assignment and set resource assignment meta data
                ResourceAssignment assn = project.ResourceAssignments.Add(task, rsc1);
                assn.Set(Asn.Uid, 1);
                assn.Set(Asn.Work, task.Get(Tsk.Duration));
                assn.Set(Asn.RemainingWork, assn.Get(Asn.Work));
                assn.Set(Asn.RegularWork, assn.Get(Asn.Work));
                task.Set(Tsk.Work, assn.Get(Asn.Work));

                rsc1.Set(Rsc.Work, task.Get(Tsk.Work));
                assn.Set(Asn.Start, task.Get(Tsk.Start));
                assn.Set(Asn.Finish, task.Get(Tsk.Finish));

                // Add extended attribute for project and task
                ExtendedAttributeDefinition attr = new ExtendedAttributeDefinition();
                attr.FieldId = ((int)ExtendedAttributeTask.Flag1).ToString();
                attr.Alias = "Labeled";
                project.ExtendedAttributes.Add(attr);
                ExtendedAttribute taskAttr = new ExtendedAttribute();
                taskAttr.Value = "1";
                taskAttr.FieldId = attr.FieldId;
                task2.ExtendedAttributes.Add(taskAttr);

                // Save project as MPP
                project.Save(dataDir + "WriteMetaData_out.mpp", SaveFileFormat.MPP);
                // ExEnd:WriteMetadataToMPP
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
