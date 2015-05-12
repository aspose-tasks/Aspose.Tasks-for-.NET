Imports Helpers
Imports NUnit.Framework
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Assert = NUnit.Framework.Assert
Imports Description = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute

Namespace Examples.ProgrammersGuide.WorkingWithProjects.CreatingEmptyProjectFile
	<TestClass, TestFixture> _
	Public Class CreatingEmptyProjectFileExamples
        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub CreateEmptyProjectAndSaveXMLFile()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/CreatingEmptyProjectFile/CreateEmptyProjectAndSaveXMLFile")
	
	            CreateEmptyProjectAndSaveXMLFileExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub CreateEmptyProjectSavetoStream()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/CreatingEmptyProjectFile/CreateEmptyProjectSavetoStream")
	
	            CreateEmptyProjectSavetoStreamExample.Program.Main()
        End Sub

	End Class
End Namespace