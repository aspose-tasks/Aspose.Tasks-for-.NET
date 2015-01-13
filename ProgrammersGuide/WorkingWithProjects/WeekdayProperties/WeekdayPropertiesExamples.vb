Imports Helpers
Imports NUnit.Framework
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Assert = NUnit.Framework.Assert
Imports Description = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute

Namespace Examples.ProgrammersGuide.WorkingWithProjects.WeekdayProperties
	<TestClass, TestFixture> _
	Public Class WeekdayPropertiesExamples
        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub ReadingWeekdayProperties()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/WeekdayProperties/ReadingWeekdayProperties")
	
	            ReadingWeekdayPropertiesExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub WritingWeekdayProperties()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/WeekdayProperties/WritingWeekdayProperties")
	
	            WritingWeekdayPropertiesExample.Program.Main()
        End Sub

	End Class
End Namespace