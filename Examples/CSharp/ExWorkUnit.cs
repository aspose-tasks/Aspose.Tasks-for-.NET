namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExWorkUnit : ApiExampleBase
    {
        [Test]
        public static void WorkWithWorkUnit()
        {
            //ExStart
            //ExFor: WorkUnit
            //ExFor: WorkUnit.#ctor(DateTime,DateTime)
            //ExFor: WorkUnit.From
            //ExFor: WorkUnit.To
            //ExFor: WorkUnit.WorkingHours
            //ExSummary: Shows how to work with work unit information.
            var project = new Project(DataDir + "Project1.mpp");

            var calendar = project.Calendars.GetByUid(1);

            // get working hours for specific date
            var workUnit = calendar.GetWorkingHours(new DateTime(2020, 4, 8, 8, 0, 0), new DateTime(2020, 4, 9, 17, 0, 0));

            Console.WriteLine("From: " + workUnit.From);
            Console.WriteLine("To: " + workUnit.To);
            Console.WriteLine("Working hours: " + workUnit.WorkingHours);
            //ExEnd
            
            Assert.AreEqual(16, workUnit.WorkingHours.TotalHours);
        }
    }
}