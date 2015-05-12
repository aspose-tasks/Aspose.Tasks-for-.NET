using Helpers;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;
using Description = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute;

namespace Examples.ProgrammersGuide.WorkingWithProjects.GetNumberOfPagesInProject
{
    [TestClass, TestFixture]
    public class GetNumberOfPagesInProjectExamples
    {	
        [TestMethod, Test, Owner("Console")]
        public void GetNumberOfPages()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/GetNumberOfPagesInProject/GetNumberOfPages");

            GetNumberOfPagesExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void GetNumberOfPagesForDifferentViews()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/GetNumberOfPagesInProject/GetNumberOfPagesForDifferentViews");

            GetNumberOfPagesForDifferentViewsExample.Program.Main();
        }

    }
}
