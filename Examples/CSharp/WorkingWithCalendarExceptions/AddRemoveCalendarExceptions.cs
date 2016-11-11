using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendarExceptions
{
    class AddRemoveCalendarExceptions
    {
        public static void Run()
        {
            // ExStart:AddRemoveCalendarExceptions
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            using (FileStream fs = new FileStream(dataDir + "project_test.mpp", FileMode.Open))
            {
                // Create project instance
                Project prj = new Project(fs);
                
                // Remove an exception
                Aspose.Tasks.Calendar cal = prj.Calendars.ToList()[0];
                if (cal.Exceptions.Count > 1)
                {
                    CalendarException exc = cal.Exceptions.ToList()[0];
                    cal.Exceptions.Remove(exc);
                }

                // Add an exception
                CalendarException calExc = new CalendarException();
                calExc.FromDate = new System.DateTime(2009, 1, 1);
                calExc.ToDate = new System.DateTime(2009, 1, 3);
                cal.Exceptions.Add(calExc);

                // Display exceptions
                foreach (CalendarException calExc1 in cal.Exceptions)
                {
                    Console.WriteLine("From" + calExc1.FromDate.ToShortDateString());
                    Console.WriteLine("To" + calExc1.ToDate.ToShortDateString());
                }
            }               
            // ExEnd:AddRemoveCalendarExceptions
        }
    }
}
