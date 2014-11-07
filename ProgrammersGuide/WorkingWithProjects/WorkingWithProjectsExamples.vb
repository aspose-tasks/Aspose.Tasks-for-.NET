Imports System.Reflection
Imports Helpers
Imports NUnit.Framework
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Assert = NUnit.Framework.Assert
Imports Description = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute

<Assembly: AssemblyTitle("Aspose.Tasks Examples")>
<Assembly: AssemblyDescription("A collection of examples which demonstrate how to use the Aspose.Tasks for .NET API.")>
<Assembly: AssemblyConfiguration("VisualBasic")>

Namespace Examples.ProgrammersGuide.WorkingWithProjects
	<TestClass, TestFixture> _
	Public Class WorkingWithProjectsExamples
        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub CreatingEmptyProjectFile()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/CreatingEmptyProjectFile")
	
	            CreatingEmptyProjectFileExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub SettingAttributesForNewTasks()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/SettingAttributesForNewTasks")
	
	            SettingAttributesForNewTasksExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub AddRemoveTasks()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/AddRemoveTasks")
	
	            AddRemoveTasksExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub DeterminingProjectVersion()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/DeterminingProjectVersion")
	
	            DeterminingProjectVersionExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub DefaultProjectProperties()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/DefaultProjectProperties")
	
	            DefaultProjectPropertiesExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub WriteMPPProjectSummary()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/WriteMPPProjectSummary")
	
	            WriteMPPProjectSummaryExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub FiscalYearProperties()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/FiscalYearProperties")
	
	            FiscalYearPropertiesExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub WeekdayProperties()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/WeekdayProperties")
	
	            WeekdayPropertiesExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub ReadingProjectFiles()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/ReadingProjectFiles")
	
	            ReadingProjectFilesExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub RetrievingCalendarInformation()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/RetrievingCalendarInformation")
	
	            RetrievingCalendarInformationExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub RetrievingTaskInformation()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/RetrievingTaskInformation")
	
	            RetrievingTaskInformationExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub WritingTasksToProject()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/WritingTasksToProject")
	
	            WritingTasksToProjectExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub RetrievingTaskLinks()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/RetrievingTaskLinks")
	
	            RetrievingTaskLinksExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub AddingAndRemovingTaskLinks()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/AddingAndRemovingTaskLinks")
	
	            AddingAndRemovingTaskLinksExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub DefiningRootTask()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/DefiningRootTask")
	
	            DefiningRootTaskExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub AddingAndRemovingResources()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/AddingAndRemovingResources")
	
	            AddingAndRemovingResourcesExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub WritingResourcesToProject()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/WritingResourcesToProject")
	
	            WritingResourcesToProjectExample.Program.Main()
        End Sub

	End Class

	<TestClass, SetUpFixture> _
	Public Class AsposeExamples
		<AssemblyInitialize> _
		Public Shared Sub AssemblyInitialize(ByVal context As Microsoft.VisualStudio.TestTools.UnitTesting.TestContext)
			Main()
		End Sub

		<SetUp> _
		Public Shared Sub AssemblySetup()
			Main()
		End Sub

		<AssemblyCleanup> _
		Public Shared Sub AssemblyCleanup()
			TestHelper.Cleanup()
		End Sub

		Public Shared Sub Main()
		    ' Provides an introduction of how to use this example project.
			TestHelper.ShowIntroForm()
		End Sub
	End Class
End Namespace