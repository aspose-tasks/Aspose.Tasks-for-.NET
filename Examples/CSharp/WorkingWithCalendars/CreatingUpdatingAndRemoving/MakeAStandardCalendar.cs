/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars.CreatingUpdatingAndRemoving
{
    internal class MakeAStandardCalendar
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);   
            
            //ExStart:MakeAStandardCalendar
            //ExFor: Project.Calendars.Add(String)
            //ExSummary: Shows how to make a standard calendar.
            // Create a project instance
            var project = new Project();

            // Define a calendar and make it standard
            var calendar = project.Calendars.Add("New Standard Calendar");
            Calendar.MakeStandardCalendar(calendar);

            // Save the Project
            project.Save(dataDir + "Project_MakeStandardCalendar_out.xml", Aspose.Tasks.Saving.SaveFileFormat.XML);
            //ExEnd:MakeAStandardCalendar
        }
    }
}
