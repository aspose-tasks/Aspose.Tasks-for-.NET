using Helpers;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;
using Description = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute;

namespace Examples.ProgrammersGuide.WorkingWithProjects.CreatingEmptyProjectFile
{
    [TestClass, TestFixture]
    public class CreatingEmptyProjectFileExamples
    {	
        [TestMethod, Test, Owner("Console")]
        public void CreateEmptyProjectAndSaveXMLFile()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/CreatingEmptyProjectFile/CreateEmptyProjectAndSaveXMLFile");

            CreateEmptyProjectAndSaveXMLFileExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void CreateEmptyProjectSavetoStream()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/CreatingEmptyProjectFile/CreateEmptyProjectSavetoStream");

            CreateEmptyProjectSavetoStreamExample.Program.Main();
        }

    }
}
