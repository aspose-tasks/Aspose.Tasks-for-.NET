using Helpers;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;
using Description = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute;

namespace Examples.ProgrammersGuide.WorkingWithProjects.WeekdayProperties
{
    [TestClass, TestFixture]
    public class WeekdayPropertiesExamples
    {	
        [TestMethod, Test, Owner("Console")]
        public void ReadingWeekdayProperties()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/WeekdayProperties/ReadingWeekdayProperties");

            ReadingWeekdayPropertiesExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void WritingWeekdayProperties()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/WeekdayProperties/WritingWeekdayProperties");

            WritingWeekdayPropertiesExample.Program.Main();
        }

    }
}
