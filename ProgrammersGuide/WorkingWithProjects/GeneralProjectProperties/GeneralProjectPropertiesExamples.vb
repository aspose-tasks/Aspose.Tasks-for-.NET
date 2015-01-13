Imports Helpers
Imports NUnit.Framework
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Assert = NUnit.Framework.Assert
Imports Description = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute

Namespace Examples.ProgrammersGuide.WorkingWithProjects.GeneralProjectProperties
	<TestClass, TestFixture> _
	Public Class GeneralProjectPropertiesExamples
        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub ReadingProjectInformation()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/GeneralProjectProperties/ReadingProjectInformation")
	
	            ReadingProjectInformationExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub WritingProjectInformation()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/GeneralProjectProperties/WritingProjectInformation")
	
	            WritingProjectInformationExample.Program.Main()
        End Sub

	End Class
End Namespace