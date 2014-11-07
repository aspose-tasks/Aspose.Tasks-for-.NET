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
        public void CreatingEmptyProjectFile()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/CreatingEmptyProjectFile");

            CreatingEmptyProjectFileExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void SettingAttributesForNewTasks()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/SettingAttributesForNewTasks");

            SettingAttributesForNewTasksExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void AddRemoveTasks()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/AddRemoveTasks");

            AddRemoveTasksExample.Program.Main();
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
        public void FiscalYearProperties()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/FiscalYearProperties");

            FiscalYearPropertiesExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void WeekdayProperties()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/WeekdayProperties");

            WeekdayPropertiesExample.Program.Main();
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
        public void RetrievingTaskInformation()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/RetrievingTaskInformation");

            RetrievingTaskInformationExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void WritingTasksToProject()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/WritingTasksToProject");

            WritingTasksToProjectExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void RetrievingTaskLinks()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/RetrievingTaskLinks");

            RetrievingTaskLinksExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void AddingAndRemovingTaskLinks()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/AddingAndRemovingTaskLinks");

            AddingAndRemovingTaskLinksExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void DefiningRootTask()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/DefiningRootTask");

            DefiningRootTaskExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void AddingAndRemovingResources()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/AddingAndRemovingResources");

            AddingAndRemovingResourcesExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void WritingResourcesToProject()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/WritingResourcesToProject");

            WritingResourcesToProjectExample.Program.Main();
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
