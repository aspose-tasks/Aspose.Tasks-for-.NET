/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars.CreatingUpdatingAndRemoving
{
    internal class CreatingCalendar
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:CreatingCalendar
            //ExFor: CalendarCollection.Add(String)
            //ExFor: CalendarCollection.Add(String,Calendar)
            //ExSummary: Shows how to add new calendars.
            var project = new Project();

            // new calendars can be added to a project's calendar collection by using the collection's Add overloads.
            project.Calendars.Add("Calendar");
            var calendar = project.Calendars.Add("Parent");
            project.Calendars.Add("Child", calendar);

            project.Save(dataDir + "CreatingCalendar_out.Xml", Aspose.Tasks.Saving.SaveFileFormat.XML);
            //ExEnd:CreatingCalendar
        }
    }
}
