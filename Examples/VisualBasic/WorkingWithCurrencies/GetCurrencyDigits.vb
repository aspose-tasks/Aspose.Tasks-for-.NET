
Namespace WorkingWithCurrencies
    Public Class GetCurrencyDigits
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:GetCurrencyDigits
            Dim project1 As Project = New Project(dataDir + "project.mpp")
            Console.WriteLine(project1.Get(Prj.CurrencyDigits))
            ' ExEnd:GetCurrencyDigits
        End Sub
    End Class
End Namespace