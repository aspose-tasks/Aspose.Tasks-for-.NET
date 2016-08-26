namespace Aspose.Tasks.Examples.CSharp.CustomizingCreatedProject
{
    public class ReplaceCalendarWithNewCalendar
    {
        public static void Run()
        {
            // ExStart:ReplaceCalendarWithNewCalendar
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CustomizingCreatedProject();

            Project project = new Project(dataDir + "Project5.mpp");
            Calendar calendar = new Calendar("New Cal");
            CalendarCollection calColl = project.Calendars;
            foreach (Calendar getcalendar in calColl)
            {
                if (getcalendar.Name == "Standard")
                {
                    calColl.Remove(getcalendar);
                    calColl.Add("Standard", getcalendar);
                    break;
                }
            }
            // ExEnd:ReplaceCalendarWithNewCalendar
        }
    }
}