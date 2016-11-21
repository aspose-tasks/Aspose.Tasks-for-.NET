
namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars.CreatingUpdatingAndRemoving
{
    public class ReplaceCalendarWithNewCalendar
    {
        public static void Run()
        {
            // ExStart:ReplaceCalendarWithNewCalendar
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Create project and new calendar instance
            Project project = new Project(dataDir + "Project5.mpp");
            Calendar calendar = new Calendar("New Cal");

            // Access project calendars
            CalendarCollection calColl = project.Calendars;
            foreach (Calendar myCalendar in calColl)
            {
                if (myCalendar.Name == "Standard")
                {
                    // Remove calendar
                    calColl.Remove(myCalendar);

                    // Add new calendar
                    calColl.Add("Standard", calendar);
                    break;
                }
            }
            // ExEnd:ReplaceCalendarWithNewCalendar
        }
    }
}