namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExTimephasedData : ApiExampleBase
    {
        [Test]
        public void WorkWithTimephasedData()
        {
            // ExStart
            // ExFor: TimephasedData
            // ExFor: TimephasedData.#ctor
            // ExFor: TimephasedData.CreateCostTimephased(Int32,DateTime,DateTime,Double,TimeUnitType,TimephasedDataType)
            // ExFor: TimephasedData.CreateUnitTimephased(Int32,DateTime,DateTime,Double,TimephasedDataType)
            // ExFor: TimephasedData.CreateWorkTimephased(Int32,DateTime,DateTime,TimeSpan,TimeUnitType,TimephasedDataType)
            // ExFor: TimephasedData.Finish
            // ExFor: TimephasedData.Start
            // ExFor: TimephasedData.TimephasedDataType
            // ExFor: TimephasedData.Uid
            // ExFor: TimephasedData.Unit
            // ExFor: TimephasedData.Value
            // ExFor: TimephasedData.ValueToCost
            // ExFor: TimephasedData.ValueToDuration
            // ExFor: TimephasedData.ValueToUnits
            // ExFor: TimephasedDataType
            // ExSummary: Shows how to work with custom timephased data.
            var project = new Project(DataDir + "Project1.mpp") { CalculationMode = CalculationMode.None };

            var workResource = project.Resources.Add("Work Resource");
            workResource.Set(Rsc.Type, ResourceType.Work);
            var costResource = project.Resources.Add("Cost Resource");
            costResource.Set(Rsc.Type, ResourceType.Cost);

            var task = project.RootTask.Children.Add("Task");
            task.Set(Tsk.Start, new DateTime(2018, 1, 1, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));

            var workAssignment = project.ResourceAssignments.Add(task, workResource);
            workAssignment.Set(Asn.WorkContour, WorkContourType.Contoured);
            var costAssignment = project.ResourceAssignments.Add(task, costResource);
            costAssignment.Set(Asn.WorkContour, WorkContourType.Contoured);

            // lets add custom timephased tds
            workAssignment.TimephasedData.Clear();

            // add work days
            var td1 = TimephasedData.CreateWorkTimephased(
                workAssignment.Get(Asn.Uid),
                new DateTime(2018, 1, 2, 8, 0, 0),
                new DateTime(2018, 1, 5, 17, 0, 0),
                TimeSpan.FromHours(40),
                TimeUnitType.Hour,
                TimephasedDataType.AssignmentRemainingWork);

            // add weekend
            var td2 = TimephasedData.CreateWorkTimephased(
                workAssignment.Get(Asn.Uid),
                new DateTime(2018, 1, 6, 8, 0, 0),
                new DateTime(2018, 1, 8, 8, 0, 0),
                TimeSpan.Zero,
                TimeUnitType.Hour,
                TimephasedDataType.AssignmentRemainingWork);

            workAssignment.TimephasedData.Add(td1);
            workAssignment.TimephasedData.Add(td2);

            costAssignment.TimephasedData.Clear();

            // add work days
            var td11 = TimephasedData.CreateCostTimephased(
                costAssignment.Get(Asn.Uid),
                new DateTime(2018, 1, 2, 8, 0, 0),
                new DateTime(2018, 1, 5, 17, 0, 0),
                1,
                TimeUnitType.Hour,
                TimephasedDataType.AssignmentCost);

            // add weekend
            var td22 = TimephasedData.CreateCostTimephased(
                costAssignment.Get(Asn.Uid),
                new DateTime(2018, 1, 6, 8, 0, 0),
                new DateTime(2018, 1, 8, 8, 0, 0),
                0,
                TimeUnitType.Hour,
                TimephasedDataType.AssignmentCost);

            costAssignment.TimephasedData.Add(td11);
            costAssignment.TimephasedData.Add(td22);

            Console.WriteLine("Print assignment timephased data:");
            foreach (var assignment in project.ResourceAssignments)
            {
                Console.WriteLine("Assignment UID: " + assignment.Get(Asn.Uid));
                foreach (var tds in assignment.TimephasedData)
                {
                    Console.WriteLine("  Uid: " + tds.Uid);
                    Console.WriteLine("  Start: " + tds.Start);
                    Console.WriteLine("  Finish: " + tds.Finish);
                    Console.WriteLine("  Type: " + tds.TimephasedDataType);
                    Console.WriteLine("  Unit: " + tds.Unit);
                    Console.WriteLine("  Value: " + tds.Value);
                    Console.WriteLine("  ValueToCost: " + tds.ValueToCost);
                    Console.WriteLine("  ValueToDuration: " + tds.ValueToDuration);
                    Console.WriteLine("  ValueToUnits: " + tds.ValueToUnits);
                    Console.WriteLine();
                }
            }

            project.Recalculate();

            // ExEnd
        }
    }
}