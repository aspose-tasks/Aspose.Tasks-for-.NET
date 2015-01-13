using Helpers;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;
using Description = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute;

namespace Examples.ProgrammersGuide.WorkingWithProjects.FiscalYearProperties
{
    [TestClass, TestFixture]
    public class FiscalYearPropertiesExamples
    {	
        [TestMethod, Test, Owner("Console")]
        public void ReadingFiscalYearProperties()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/FiscalYearProperties/ReadingFiscalYearProperties");

            ReadingFiscalYearPropertiesExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void WritingFiscalYearProperties()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/FiscalYearProperties/WritingFiscalYearProperties");

            WritingFiscalYearPropertiesExample.Program.Main();
        }

    }
}
