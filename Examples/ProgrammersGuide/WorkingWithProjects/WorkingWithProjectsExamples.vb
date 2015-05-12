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
	        Public Sub SettingAttributesForNewTasks()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/SettingAttributesForNewTasks")
	
	            SettingAttributesForNewTasksExample.Program.Main()
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
	        Public Sub GetObjectByFieldMethods()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/GetObjectByFieldMethods")
	
	            GetObjectByFieldMethodsExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub ExtendedAttributes()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/ExtendedAttributes")
	
	            ExtendedAttributesExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub CalculateCriticalPath()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/CalculateCriticalPath")
	
	            CalculateCriticalPathExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub ReplacingACalendar()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/ReplacingACalendar")
	
	            ReplacingACalendarExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub PrintingTaskWritingException()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/PrintingTaskWritingException")
	
	            PrintingTaskWritingExceptionExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub MicrosoftProjectMPPFileUpdate()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/MicrosoftProjectMPPFileUpdate")
	
	            MicrosoftProjectMPPFileUpdateExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub WritingUpdatedExtendedAttributeDefinitions()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/WritingUpdatedExtendedAttributeDefinitions")
	
	            WritingUpdatedExtendedAttributeDefinitionsExample.Program.Main()
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