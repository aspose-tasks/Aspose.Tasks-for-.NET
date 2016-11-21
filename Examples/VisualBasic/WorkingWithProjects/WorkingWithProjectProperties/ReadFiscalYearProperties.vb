Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks
Imports System

Namespace WorkingWithProjects.WorkingWithProjectProperties
    Public Class ReadFiscalYearProperties
        Public Shared Sub Run()
            ' ExStart: ReadFiscalYearProperties
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' Create a project instance
            Dim project As New Project(dataDir & "ReadFiscalYearProperties.mpp")

            ' Display fiscal year properties
            Console.WriteLine("Fiscal Year Start Date : " & project.Get(Prj.FyStartDate).ToString())
            Console.WriteLine("Fiscal Year Numbering : " & project.Get(Prj.FiscalYearStart).ToString())
            ' ExEnd: ReadFiscalYearProperties
        End Sub
    End Class
End Namespace