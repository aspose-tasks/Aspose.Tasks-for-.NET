using Aspose.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars.CreatingUpdatingAndRemoving
{
    class MakeAStandardCalendar
    {
        public static void Run()
        { 
            // ExStart:MakeAStandardCalendar
            // Create a project instance
            Project project = new Project();

            // Define Calendar and make it standard
            Aspose.Tasks.Calendar cal1 = project.Calendars.Add("My Cal");
            Aspose.Tasks.Calendar.MakeStandardCalendar(cal1);

            // Save the Project
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            project.Save(dataDir + "Project_MakeStandardCalendar_out.xml", Aspose.Tasks.Saving.SaveFileFormat.XML);
            // ExEnd:MakeAStandardCalendar
        }
    }
}
