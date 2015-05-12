using Helpers;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;
using Description = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute;

namespace Examples.ProgrammersGuide.WorkingWithProjects.GeneralProjectProperties
{
    [TestClass, TestFixture]
    public class GeneralProjectPropertiesExamples
    {	
        [TestMethod, Test, Owner("Console")]
        public void ReadingProjectInformation()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/GeneralProjectProperties/ReadingProjectInformation");

            ReadingProjectInformationExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void WritingProjectInformation()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/GeneralProjectProperties/WritingProjectInformation");

            WritingProjectInformationExample.Program.Main();
        }

    }
}
