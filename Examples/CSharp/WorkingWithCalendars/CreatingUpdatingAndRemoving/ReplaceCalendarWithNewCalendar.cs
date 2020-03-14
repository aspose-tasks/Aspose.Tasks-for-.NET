using Aspose.Tasks.Saving;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars.CreatingUpdatingAndRemoving
{
    public class ReplaceCalendarWithNewCalendar
    {
        public static void Run()
        {
            try
            {				
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                //ExStart:ReplaceCalendarWithNewCalendar
                // Create project
                Project project = new Project(dataDir + "Project5.mpp");

                // Access project calendars
                CalendarCollection calColl = project.Calendars;
                foreach (Calendar myCalendar in calColl)
                {
                    if (myCalendar.Name == "TestCalendar")
                    {
                        // Remove calendar
                        calColl.Remove(myCalendar);
                    }
                }

                // Add new calendar
                Calendar newCalendar = calColl.Add("TestCalendar");
                project.Save(dataDir + "ReplaceCalendar_out.mpp", SaveFileFormat.MPP);
                //ExEnd:ReplaceCalendarWithNewCalendar
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}