namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExCalendarExceptionCollection : ApiExampleBase
    {
        [Test]
        public void UseCalendarExceptionCollection()
        {
            try
            {
                //ExStart:UseCalendarExceptionCollection
                //ExFor: CalendarExceptionCollection.Add(CalendarException)
                //ExSummary: Shows how to use calendar exception collection to define calendar exceptions.
                var project = new Project(DataDir + "project_update_test.mpp");
                var calendar = project.Calendars.GetByUid(3);

                // Update the calendar information
                Calendar.MakeStandardCalendar(calendar);
                calendar.Name = "Test calendar";
                var exception = new CalendarException();
                exception.FromDate = DateTime.Now;
                exception.ToDate = DateTime.Now.AddDays(2);
                exception.DayWorking = true;

                var wt1 = new WorkingTime();
                wt1.FromTime = new DateTime(10, 1, 1, 9, 0, 0);
                wt1.ToTime = new DateTime(10, 1, 1, 13, 0, 0);

                var wt2 = new WorkingTime();
                wt2.FromTime = new DateTime(10, 1, 1, 14, 0, 0);
                wt2.ToTime = new DateTime(10, 1, 1, 19, 0, 0);

                var wt3 = new WorkingTime();
                wt3.FromTime = new DateTime(10, 1, 1, 20, 0, 0);
                wt3.ToTime = new DateTime(10, 1, 1, 21, 0, 0);

                exception.WorkingTimes.Add(wt1);
                exception.WorkingTimes.Add(wt2);
                exception.WorkingTimes.Add(wt3);
                calendar.Exceptions.Add(exception);

                var exception2 = new CalendarException();
                exception2.FromDate = DateTime.Now.AddDays(7);
                exception2.ToDate = exception2.FromDate;
                exception2.DayWorking = false;
                calendar.Exceptions.Add(exception2);

                project.Set(Prj.Calendar, calendar);

                project.Save(OutDir + "UseCalendarExceptionCollection_out.mpp", SaveFileFormat.MPP);
                //ExEnd:UseCalendarExceptionCollection
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}