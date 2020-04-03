namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExPrj : ApiExampleBase
    {
        [Test]
        public void GetWorkWithDefaultProjectFormat()
        {
            //ExStart
            //ExFor: Prj.WorkFormat
            //ExSummary: Shows how to get a duration with default work format.
            var project = new Project(DataDir + "Blank2010.mpp");

            Console.WriteLine("Project's work format: " + project.Get(Prj.WorkFormat));

            // create a work value with project's default work format
            var work = project.GetWork(2);
            Console.WriteLine("Work: " + work.TimeSpan);
            Console.WriteLine("Time unit: " + work.TimeUnit);
            //ExEnd
        }
        
        [Test]
        public void SetGanttChartViewStartDate()
        {            
            try
            {
                //ExStart
                //ExFor: Prj.TimescaleStart
                //ExSummary: Shows how to set timescale start date to tune the date where the view should start.
                var project = new Project(DataDir + "Project2.mpp");
                project.Set(Prj.TimescaleStart, new DateTime(2012, 4, 30));
                project.Save(OutDir + "SetGanttChartViewStartDate_out.mpp", SaveFileFormat.MPP);
                //ExEnd
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void RescheduleProjectFromFinishDate()
        {
            //ExStart:RescheduleProjectFromFinishDate
            //ExFor: Prj.ScheduleFromStart
            //ExFor: Prj.FinishDate
            //ExSummary: Shows how to reschedule the project from finish date instead of the start one.
            var project = new Project(DataDir + "Project2.mpp");
            project.Set(Prj.ScheduleFromStart, false);
            project.Set(Prj.FinishDate, new DateTime(2020, 1, 1));

            // Now all tasks dates (Start, Finish, EarlyStart, EarlyFinish, LateStart, LateFinish) are calculated. To get the critical path we need to calculate slacks (can be invoked in separate thread, but only after calculation of all early/late dates)
            project.Recalculate();

            foreach (var task in project.CriticalPath)
            {
                Console.WriteLine(task.Get(Tsk.Id));
                Console.WriteLine(task.Get(Tsk.Name));
            }
            //ExEnd:RescheduleProjectFromFinishDate
        }
        
        [Test]
        public void DetermineProjectVersion()
        {
            //ExStart:DetermineProjectVersion
            //ExFor: Prj.LastSaved
            //ExFor: Prj.SaveVersion
            //ExSummary: Shows how to check project's save version and save date.
            var project = new Project(DataDir + "DetermineProjectVersion.mpp");

            // Display project version
            Console.WriteLine("Project Version : " + project.Get(Prj.SaveVersion));
            Console.WriteLine("Last Saved : " + project.Get(Prj.LastSaved).ToShortDateString());
            //ExEnd:DetermineProjectVersion
        }
        
        [Test]
        public void ReadWriteCurrencyProperties()
        {
            //ExStart:ReadWriteCurrencyProperties
            //ExFor: Prj.CurrencyCode
            //ExFor: Prj.CurrencyDigits
            //ExFor: Prj.CurrencySymbol
            //ExFor: Prj.CurrencySymbolPosition
            //ExSummary: Shows how to write project's currency properties.
            var project = new Project(DataDir + "WriteCurrencyProperties.mpp");

            // Set currency properties
            project.Set(Prj.CurrencyCode, "AUD");
            project.Set(Prj.CurrencyDigits, 2);
            project.Set(Prj.CurrencySymbol, "$");
            project.Set(Prj.CurrencySymbolPosition, CurrencySymbolPositionType.After);
            
            // Display currency properties
            Console.WriteLine("Currency Code: " + project.Get(Prj.CurrencyCode));
            Console.WriteLine("Currency Digits: " + project.Get(Prj.CurrencyDigits));
            Console.WriteLine("Currency Symbol: " + project.Get(Prj.CurrencySymbol));
            Console.WriteLine("Currency Symbol Position: " + project.Get(Prj.CurrencySymbolPosition));

            project.Save(OutDir + "WriteCurrencyProperties_out.xml", SaveFileFormat.XML);
            //ExEnd:ReadWriteCurrencyProperties
        }
        
        [Test]
        public void ReadWriteProjectInfo()
        {    
            //ExStart:ReadWriteProjectInfo
            //ExFor: Prj.Author
            //ExFor: Prj.LastAuthor
            //ExFor: Prj.Revision
            //ExFor: Prj.Keywords
            //ExFor: Prj.Comments
            //ExSummary: Shows how to set project meta information.
            try
            {
                var project = new Project(DataDir + "WriteProjectInfo.mpp");
                
                // Set project information
                project.Set(Prj.Author, "Author");
                project.Set(Prj.LastAuthor, "Last Author");
                project.Set(Prj.Revision, 15);
                project.Set(Prj.Keywords, "MSP Aspose");
                project.Set(Prj.Comments, "Comments");
                
                Console.WriteLine(project.Get(Prj.Author));
                Console.WriteLine(project.Get(Prj.LastAuthor));
                Console.WriteLine(project.Get(Prj.Revision));
                Console.WriteLine(project.Get(Prj.Keywords));
                Console.WriteLine(project.Get(Prj.Comments));
                
                project.Save(OutDir + "WriteProjectInfo_out.mpp", SaveFileFormat.MPP);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }             
            //ExEnd:ReadWriteProjectInfo
        }
        
        [Test]
        public void ReadWriteWeekdayProperties()
        {
            //ExStart:ReadWriteWeekdayProperties
            //ExFor: Prj.WeekStartDay
            //ExFor: Prj.DaysPerMonth
            //ExFor: Prj.MinutesPerDay
            //ExFor: Prj.MinutesPerWeek
            //ExSummary: Shows how to read/write project's weekday properties.
            var project = new Project(DataDir + "WriteWeekdayProperties.mpp");

            // Set week days properties
            project.Set(Prj.WeekStartDay, DayType.Monday);
            project.Set(Prj.DaysPerMonth, 24);
            project.Set(Prj.MinutesPerDay, 540);
            project.Set(Prj.MinutesPerWeek, 3240);

            // Display week days properties
            Console.WriteLine("Week Start Date: " + project.Get(Prj.WeekStartDay));
            Console.WriteLine("Days Per Month: " + project.Get(Prj.DaysPerMonth));
            Console.WriteLine("Minutes Per Day: " + project.Get(Prj.MinutesPerDay));
            Console.WriteLine("Minutes Per Week: " + project.Get(Prj.MinutesPerWeek));

            project.Save(OutDir + "WriteWeekdayProperties_out.xml", SaveFileFormat.XML);
            //ExEnd:ReadWriteWeekdayProperties            
        }
        
        [Test]
        public void ReadWriteFiscalYearProperties()
        {
            try
            {
                //ExStart:ReadWriteFiscalYearProperties
                //ExFor: Prj.FyStartDate
                //ExFor: Prj.FiscalYearStart
                //ExSummary: Shows how to write fiscal year properties. 
                var project = new Project(DataDir + "WriteFiscalYearProperties.mpp");

                // Set fiscal year properties
                project.Set(Prj.FyStartDate, Month.July);
                project.Set(Prj.FiscalYearStart, true);
                
                // Display fiscal year properties
                Console.WriteLine("Fiscal Year Start Date: " + project.Get(Prj.FyStartDate));
                Console.WriteLine("Fiscal Year Numbering: " + project.Get(Prj.FiscalYearStart));

                project.Save(OutDir + "WriteFiscalYearProperties_out.mpp", SaveFileFormat.MPP);
                //ExEnd:ReadWriteFiscalYearProperties
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }            
        }
        
        [Test]
        public void ReadWriteDefaultProperties()
        {
            //ExStart:ReadWriteDefaultProperties
            //ExFor: Prj.DefaultStartTime
            //ExFor: Prj.DefaultTaskType
            //ExFor: Prj.DefaultStandardRate
            //ExFor: Prj.DefaultOvertimeRate
            //ExFor: Prj.DefaultTaskEVMethod
            //ExFor: Prj.DefaultFixedCostAccrual
            //ExSummary: Shows how to read project's default properties.
            var project = new Project(DataDir + "DefaultProperties.mpp");
            
            // Set default properties
            project.Set(Prj.ScheduleFromStart, true);
            project.Set(Prj.StartDate, DateTime.Now);
            project.Set(Prj.DefaultStartTime, project.Get(Prj.StartDate));
            project.Set(Prj.DefaultTaskType, TaskType.FixedDuration);
            project.Set(Prj.DefaultStandardRate, 15);
            project.Set(Prj.DefaultOvertimeRate, 12);
            project.Set(Prj.DefaultTaskEVMethod, EarnedValueMethodType.PercentComplete);
            project.Set(Prj.DefaultFixedCostAccrual, CostAccrualType.Prorated);

            // Display default properties
            Console.WriteLine("New Task Default Start: " + project.Get(Prj.DefaultStartTime).ToShortDateString());
            Console.WriteLine("New Task Default Type: " + project.Get(Prj.DefaultTaskType));
            Console.WriteLine("Resource Default Standard Rate: " + project.Get(Prj.DefaultStandardRate));
            Console.WriteLine("Resource Default Overtime Rate: " + project.Get(Prj.DefaultOvertimeRate));
            Console.WriteLine("Default Task EV Method: " + project.Get(Prj.DefaultTaskEVMethod));
            Console.WriteLine("Default Cost Accrual: " + project.Get(Prj.DefaultFixedCostAccrual));

            project.Save(OutDir + "WriteDefaultProperties_out.xml", SaveFileFormat.XML);
            //ExEnd:ReadWriteDefaultProperties
        }
        
        [Test]
        public void PrjNewTaskStartDate()
        {
            //ExStart:SetAttributesForNewTasks
            //ExFor: Prj.NewTaskStartDate
            //ExSummary: Shows how to set attributes for new tasks.
            var project = new Project();
            project.Set(Prj.NewTaskStartDate, TaskStartDateType.CurrentDate);
            project.Save(OutDir + "SetAttributesForNewTasks_out.xml", SaveFileFormat.XML);
            //ExEnd:SetAttributesForNewTasks
        }
    }
}