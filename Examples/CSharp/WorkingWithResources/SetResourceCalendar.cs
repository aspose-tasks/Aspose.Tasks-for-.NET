/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    using Aspose.Tasks.Saving;

    internal class SetResourceCalendar
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:SetResourceCalendar
            //ExFor: Rsc.Calendar
            //ExSummary: Shows how to set resource calendar.
            var project = new Project();
            var res = project.Resources.Add("Resource1");

            // Add standard calendar and assign to resource
            var cal = project.Calendars.Add("Resource1");
            res.Set(Rsc.Calendar, cal);
            //ExEnd:SetResourceCalendar

            // Save project as XML
            project.Save(dataDir + "SetResourceCalendar_out.xml", SaveFileFormat.XML);
        }
    }
}
