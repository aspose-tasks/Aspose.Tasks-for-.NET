namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExCalendarCollection : ApiExampleBase
    {
        [Test]
        public void CreateCalendar()
        {
            // ExStart
            // ExFor: CalendarCollection
            // ExFor: CalendarCollection.Add(String,Calendar)
            // ExFor: CalendarCollection.GetEnumerator()
            // ExSummary: Shows how to add new calendars.
            var project = new Project();

            // new calendars can be added to a project's calendar collection by using the collection's Add overloads.
            project.Calendars.Add("Calendar");
            var newCalendar = project.Calendars.Add("Parent");
            project.Calendars.Add("Child", newCalendar);

            foreach (var calendar in project.Calendars)
            {
                Console.WriteLine("Calendar Name: " + calendar.Name);
            }

            // ExEnd
        }

        [Test]
        public void ReplaceCalendarWithNewCalendar()
        {
            try
            {
                // ExStart:ReplaceCalendarWithNewCalendar
                // ExFor: CalendarCollection.Remove(Calendar)
                // ExSummary: Shows how to replace a calendar in the collection. 
                var project = new Project(DataDir + "Project5.mpp");

                var calendar = project.Calendars.GetByName("TestCalendar");
                if (calendar != null)
                {
                    project.Calendars.Remove(calendar);
                }

                // add new calendar
                project.Calendars.Add("New Calendar");
                project.Save(OutDir + "ReplaceCalendarWithNewCalendar_out.mpp", SaveFileFormat.MPP);

                // ExEnd:ReplaceCalendarWithNewCalendar
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void GetCalendarByNameOrId()
        {
            // ExStart
            // ExFor: CalendarCollection.GetByName(String)
            // ExFor: CalendarCollection.GetByUid(Int32)
            // ExSummary: Shows how to get calendars by name or by id. 
            var project = new Project(DataDir + "Project5.mpp");

            var calendarByName = project.Calendars.GetByName("TestCalendar");
            var calendarByUid = project.Calendars.GetByUid(4);

            Console.WriteLine("Calendar Name: " + calendarByName.Name);
            Console.WriteLine("Calendar Name: " + calendarByUid.Name);
            Console.WriteLine("Are calendars equals: " + calendarByName.Equals(calendarByUid));

            // ExEnd
            Assert.AreEqual(calendarByName, calendarByUid);
        }

        [Test]
        public void GetParentProjectName()
        {
            // ExStart
            // ExFor: CalendarCollection.ParentProject
            // ExSummary: Shows how to read calendar parent project properties. 
            var project = new Project(DataDir + "Project5.mpp");

            var calendarByName = project.Calendars.GetByName("TestCalendar");

            Console.WriteLine("Calendar Name: " + calendarByName.ParentProject.Get(Prj.Name));

            // ExEnd
        }

        [Test]
        public void IterateOverCalendars()
        {
            // ExStart
            // ExFor: CalendarCollection.Count
            // ExFor: CalendarCollection.ToList()
            // ExSummary: Shows how to iterate over calendar collection. 
            var project = new Project(DataDir + "Project5.mpp");

            Console.WriteLine("Number of calendars in the project: " + project.Calendars.Count);
            List<Calendar> calendars = project.Calendars.ToList();
            foreach (var calendar in calendars)
            {
                Console.WriteLine("Calendar Name: " + calendar.Name);
            }

            // ExEnd
        }

        [Test]
        public void MakeAStandardCalendar()
        {
            // ExStart:MakeAStandardCalendar
            // ExFor: CalendarCollection.Add(String)
            // ExSummary: Shows how to make a standard calendar.
            var project = new Project();

            // Define a calendar and make it standard
            var calendar = project.Calendars.Add("New Standard Calendar");
            Calendar.MakeStandardCalendar(calendar);

            project.Save(OutDir + "MakeAStandardCalendar_out.xml", SaveFileFormat.XML);

            // ExEnd:MakeAStandardCalendar
        }
    }
}