namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendarExceptions
{
    using System;
    using System.IO;

    internal class AddRemoveCalendarExceptions
    {
        public static void Run()
        {
            //ExStart:AddRemoveCalendarExceptions
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            using (var fs = new FileStream(dataDir + "project_test.mpp", FileMode.Open))
            {
                // Create project instance
                var prj = new Project(fs);
                
                // Remove an exception
                var cal = prj.Calendars.ToList()[0];
                if (cal.Exceptions.Count > 1)
                {
                    var exc = cal.Exceptions.ToList()[0];
                    cal.Exceptions.Remove(exc);
                }

                // Add an exception
                var calExc = new CalendarException();
                calExc.FromDate = new System.DateTime(2009, 1, 1);
                calExc.ToDate = new System.DateTime(2009, 1, 3);
                cal.Exceptions.Add(calExc);

                // Display exceptions
                foreach (var calExc1 in cal.Exceptions)
                {
                    Console.WriteLine("From" + calExc1.FromDate.ToShortDateString());
                    Console.WriteLine("To" + calExc1.ToDate.ToShortDateString());
                }
            }               
            //ExEnd:AddRemoveCalendarExceptions
        }
    }
}
