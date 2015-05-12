Imports Helpers
Imports NUnit.Framework
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Assert = NUnit.Framework.Assert
Imports Description = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute

Namespace Examples.ProgrammersGuide.WorkingWithProjects.GetNumberOfPagesInProject
	<TestClass, TestFixture> _
	Public Class GetNumberOfPagesInProjectExamples
        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub GetNumberOfPages()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/GetNumberOfPagesInProject/GetNumberOfPages")
	
	            GetNumberOfPagesExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub GetNumberOfPagesForDifferentViews()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithProjects/GetNumberOfPagesInProject/GetNumberOfPagesForDifferentViews")
	
	            GetNumberOfPagesForDifferentViewsExample.Program.Main()
        End Sub

	End Class
End Namespace