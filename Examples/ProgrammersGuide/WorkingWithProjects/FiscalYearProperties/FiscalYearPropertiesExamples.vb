Imports Helpers
Imports NUnit.Framework
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Assert = NUnit.Framework.Assert
Imports Description = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute

Namespace Examples.ProgrammersGuide.WorkingWithProjects.FiscalYearProperties
	<TestClass, TestFixture> _
	Public Class FiscalYearPropertiesExamples
        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub ReadingFiscalYearProperties()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/FiscalYearProperties/ReadingFiscalYearProperties")
	
	            ReadingFiscalYearPropertiesExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub WritingFiscalYearProperties()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/FiscalYearProperties/WritingFiscalYearProperties")
	
	            WritingFiscalYearPropertiesExample.Program.Main()
        End Sub

	End Class
End Namespace