using Helpers;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;
using Description = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute;

namespace Examples.ProgrammersGuide.WorkingWithProjects.CurrencyProperties
{
    [TestClass, TestFixture]
    public class CurrencyPropertiesExamples
    {	
        [TestMethod, Test, Owner("Console")]
        public void ReadingCurrencyProperties()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/CurrencyProperties/ReadingCurrencyProperties");

            ReadingCurrencyPropertiesExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void SetCurrencyProperties()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/CurrencyProperties/SetCurrencyProperties");

            SetCurrencyPropertiesExample.Program.Main();
        }

    }
}
