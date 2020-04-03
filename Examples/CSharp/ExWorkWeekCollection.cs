namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExWorkWeekCollection : ApiExampleBase
    {
        [Test]
        public static void ReadWorkWeeksInformation()
        {
            //ExStart
            //ExFor: WorkWeekCollection
            //ExSummary: Shows how to read work week information from the project.
            var project = new Project(DataDir + "ReadWorkWeeksInformation.mpp");
            var calendar = project.Calendars.GetByUid(3);

            foreach (var workWeek in calendar.WorkWeeks)
            {
                // Display work week name, from and to dates
                var name = workWeek.Name;  
                var fromDate = workWeek.FromDate;  
                var toDate = workWeek.ToDate;
                Console.WriteLine("Name: " + name);
                Console.WriteLine("From Date: " + fromDate);
                Console.WriteLine("To Date: " + toDate);

                // This data is all about "Details." button you can set special working times for special WeekDay or even make it nonworking
                var weekDays = workWeek.WeekDays;  
                foreach (var day in weekDays) 
                {
                    // You can further traverse through working times and display these
                    var workingTimes = day.WorkingTimes;
                    foreach (var workingTime in workingTimes)
                    {
                        Console.WriteLine(workingTime.FromTime);
                        Console.WriteLine(workingTime.ToTime);
                    }
                }
            }
            //ExEnd
        }
    }
}