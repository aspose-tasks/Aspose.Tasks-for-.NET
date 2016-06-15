using System.IO;
using Aspose.Tasks;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class ReplaceCalendar
    {
        public static void Run()
        {
            //ExStart: ReplaceCalendar
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();
            Project project = new Project(dataDir+ "ReplaceCalendar.mpp");

            //Add a new calendar to the project's calendars collection
            project.Calendars.Add("New cal1", project.Get(Prj.Calendar));

            //Now traverse through project calendars and replace the already added calendar with a new one
            CalendarCollection calColl = project.Calendars;

            foreach (Aspose.Tasks.Calendar c in calColl)
            {
                if (c.Name == "New cal1")
                {
                    calColl.Remove(c);
                    calColl.Add("New cal2", project.Get(Prj.Calendar));
                    break;
                }
            }
            //ExEnd: ReplaceCalendar            
        }
    }
}