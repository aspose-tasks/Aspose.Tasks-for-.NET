Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks
Imports System

Namespace WorkingWithProjects.WorkingWithProjectProperties
    Public Class ReadCurrencyProperties
        Public Shared Sub Run()
            ' ExStart: ReadCurrencyProperties
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create project instance
            Dim project As New Project(dataDir & "ReadCurrencyProperties.mpp")

            ' Display currency properties
            Console.WriteLine("Currency Code : " & project.Get(Prj.CurrencyCode).ToString())
            Console.WriteLine("<br>Currency Digits : " & project.Get(Prj.CurrencyDigits).ToString())
            Console.WriteLine("<br>Currency Symbol : " & project.Get(Prj.CurrencySymbol).ToString())
            Console.WriteLine("Currency Symbol Position" & project.Get(Prj.CurrencySymbolPosition).ToString())
            ' ExEnd: ReadCurrencyProperties
        End Sub
    End Class
End Namespace