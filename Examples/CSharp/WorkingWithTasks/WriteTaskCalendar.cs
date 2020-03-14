/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    class WriteTaskCalendar
    {
        public static void Run()
        {
            //ExStart:WriteTaskCalendar
            // Create project instance
            Project project = new Project();

            // Add task
            Task tsk1 = project.RootTask.Children.Add("Task1");

            // Create calendar and assign to task
            Aspose.Tasks.Calendar cal = project.Calendars.Add("TaskCal1");
            tsk1.Set(Tsk.Calendar, cal);
            //ExEnd:WriteTaskCalendar      
        }
    }
}
