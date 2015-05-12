using Helpers;
using NUnit.Framework;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;
using Description = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute;

[assembly: AssemblyTitle("Aspose.Tasks Examples")]
[assembly: AssemblyDescription("A collection of examples which demonstrate how to use the Aspose.Tasks for .NET API.")]
[assembly: AssemblyConfiguration("CSharp")]

namespace Examples.ProgrammersGuide.WorkingWithProjects
{
    [TestClass, TestFixture]
    public class WorkingWithProjectsExamples
    {	
        [TestMethod, Test, Owner("Console")]
        public void SettingAttributesForNewTasks()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/SettingAttributesForNewTasks");

            SettingAttributesForNewTasksExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void DeterminingProjectVersion()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/DeterminingProjectVersion");

            DeterminingProjectVersionExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void DefaultProjectProperties()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/DefaultProjectProperties");

            DefaultProjectPropertiesExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void WriteMPPProjectSummary()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/WriteMPPProjectSummary");

            WriteMPPProjectSummaryExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void ReadingProjectFiles()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/ReadingProjectFiles");

            ReadingProjectFilesExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void RetrievingCalendarInformation()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/RetrievingCalendarInformation");

            RetrievingCalendarInformationExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void GetObjectByFieldMethods()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/GetObjectByFieldMethods");

            GetObjectByFieldMethodsExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void ExtendedAttributes()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/ExtendedAttributes");

            ExtendedAttributesExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void CalculateCriticalPath()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/CalculateCriticalPath");

            CalculateCriticalPathExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void ReplacingACalendar()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/ReplacingACalendar");

            ReplacingACalendarExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void PrintingTaskWritingException()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/PrintingTaskWritingException");

            PrintingTaskWritingExceptionExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void MicrosoftProjectMPPFileUpdate()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/MicrosoftProjectMPPFileUpdate");

            MicrosoftProjectMPPFileUpdateExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void WritingUpdatedExtendedAttributeDefinitions()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/WritingUpdatedExtendedAttributeDefinitions");

            WritingUpdatedExtendedAttributeDefinitionsExample.Program.Main();
        }

    }

    [TestClass, SetUpFixture]
    public class AsposeExamples
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext context)
        {
            Main();
        }

        [SetUp]
        public static void AssemblySetup()
        {
            Main();
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            TestHelper.Cleanup();
        }

        public static void Main()
        {
            // Provides an introduction of how to use this example project.
            TestHelper.ShowIntroForm();
        }
    }
}
