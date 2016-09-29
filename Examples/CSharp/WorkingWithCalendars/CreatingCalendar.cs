using Aspose.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars
{
    class CreatingCalendar
    {
        public static void Run()
        {
            // ExStart:CreatingCalendar
            // New calendar can be added to a project's calendar collection using the collection's Add method.
            
            // Create a project instance
            Project project = new Project();

            // Define Calendar
            Aspose.Tasks.Calendar cal1 = project.Calendars.Add("New Info");
            Aspose.Tasks.Calendar cal2 = project.Calendars.Add("no name");
            Aspose.Tasks.Calendar cal3 = project.Calendars.Add("cal3");

            // Save the Project
            string dataDir = RunExamples.GetDataDir_WorkingWithCalendars();
            project.Save(dataDir + "Project_out.xml", Aspose.Tasks.Saving.SaveFileFormat.XML);
            // ExEnd:CreatingCalendar
        }
    }
}
