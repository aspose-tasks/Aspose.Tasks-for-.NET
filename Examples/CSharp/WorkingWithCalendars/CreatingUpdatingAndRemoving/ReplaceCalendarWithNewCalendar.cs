namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars.CreatingUpdatingAndRemoving
{
    using System;
    using Saving;

    internal class ReplaceCalendar
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            try
            {
                //ExStart:ReplaceCalendarWithNewCalendar
                //ExFor: CalendarCollection.Add(String)
                //ExFor: CalendarCollection.GetByName(String)
                //ExFor: CalendarCollection.Remove(Calendar)
                //ExSummary: Shows how to replace a calendar in the collection. 
                var project = new Project(dataDir + "Project5.mpp");

                var calendar = project.Calendars.GetByName("TestCalendar");
                if (calendar != null)
                {
                    project.Calendars.Remove(calendar);
                }

                // add new calendar
                project.Calendars.Add("New Calendar");
                project.Save(dataDir + "ReplaceCalendar_out.mpp", SaveFileFormat.MPP);
                //ExEnd:ReplaceCalendarWithNewCalendar
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}