using Aspose.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars.CreatingUpdatingAndRemoving
{
    class CreatingCalendar
    {
        public static void Run()
        {
            // ExStart:CreatingCalendar            
            // Create a project instance
            Project project = new Project();

            // New calendar can be added to a project's calendar collection using the collection's Add method.
            Aspose.Tasks.Calendar cal1 = project.Calendars.Add("New Info");
            Aspose.Tasks.Calendar cal2 = project.Calendars.Add("no name");
            Aspose.Tasks.Calendar cal3 = project.Calendars.Add("cal3");

            // Save the Project
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            project.Save(dataDir + "CreatingCalendar_out.Xml", Aspose.Tasks.Saving.SaveFileFormat.XML);
            // ExEnd:CreatingCalendar
        }
    }
}
