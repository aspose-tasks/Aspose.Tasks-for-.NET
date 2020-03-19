/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    internal class WriteTaskCalendar
    {
        public static void Run()
        {
            //ExStart:WriteTaskCalendar
            //ExFor: Tsk.Calendar
            //ExSummary: Shows how to set a task calendar.
            // Create project instance
            var project = new Project();

            // Add task
            var task = project.RootTask.Children.Add("Task1");

            // Create calendar and assign to task
            var calendar = project.Calendars.Add("TaskCal1");
            task.Set(Tsk.Calendar, calendar);
            //ExEnd:WriteTaskCalendar      
        }
    }
}
