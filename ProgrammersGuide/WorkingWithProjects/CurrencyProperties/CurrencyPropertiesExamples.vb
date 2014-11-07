Imports Helpers
Imports NUnit.Framework
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Assert = NUnit.Framework.Assert
Imports Description = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute

Namespace Examples.ProgrammersGuide.WorkingWithProjects.CurrencyProperties
	<TestClass, TestFixture> _
	Public Class CurrencyPropertiesExamples
        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub ReadingCurrencyProperties()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/CurrencyProperties/ReadingCurrencyProperties")
	
	            ReadingCurrencyPropertiesExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub SetCurrencyProperties()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/CurrencyProperties/SetCurrencyProperties")
	
	            SetCurrencyPropertiesExample.Program.Main()
        End Sub

	End Class
End Namespace