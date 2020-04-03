namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExCalendarCollection : ApiExampleBase
    {
        [Test]
        public void CreateCalendar()
        {
            //ExStart
            //ExFor: CalendarCollection
            //ExFor: CalendarCollection.Add(String,Calendar)
            //ExSummary: Shows how to add new calendars.
            var project = new Project();

            // new calendars can be added to a project's calendar collection by using the collection's Add overloads.
            project.Calendars.Add("Calendar");
            var calendar = project.Calendars.Add("Parent");
            project.Calendars.Add("Child", calendar);

            project.Save(OutDir + "CreatingCalendar_out.xml", SaveFileFormat.XML);
            //ExEnd
        }
        
        [Test]
        public void ReplaceCalendarWithNewCalendar()
        {
            try
            {
                //ExStart:ReplaceCalendarWithNewCalendar
                //ExFor: CalendarCollection.GetByName(String)
                //ExFor: CalendarCollection.Remove(Calendar)
                //ExSummary: Shows how to replace a calendar in the collection. 
                var project = new Project(DataDir + "Project5.mpp");

                var calendar = project.Calendars.GetByName("TestCalendar");
                if (calendar != null)
                {
                    project.Calendars.Remove(calendar);
                }

                // add new calendar
                project.Calendars.Add("New Calendar");
                project.Save(OutDir + "ReplaceCalendarWithNewCalendar_out.mpp", SaveFileFormat.MPP);
                //ExEnd:ReplaceCalendarWithNewCalendar
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void MakeAStandardCalendar()
        {
            //ExStart:MakeAStandardCalendar
            //ExFor: CalendarCollection.Add(String)
            //ExSummary: Shows how to make a standard calendar.
            var project = new Project();

            // Define a calendar and make it standard
            var calendar = project.Calendars.Add("New Standard Calendar");
            Calendar.MakeStandardCalendar(calendar);

            project.Save(OutDir + "MakeAStandardCalendar_out.xml", SaveFileFormat.XML);
            //ExEnd:MakeAStandardCalendar
        }
    }
}