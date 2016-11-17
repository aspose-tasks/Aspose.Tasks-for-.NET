Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithCurrencies
    Public Class SetCurrencyDigits
        Public Shared Sub Run()
            ' ExStart:SetCurrencyDigits
            ' Create new project and set currency digits
            Dim project1 As Project = New Project()
            project1.Set(Prj.CurrencyDigits, 2)
            ' ExEnd:SetCurrencyDigits

            ' Save project as XML
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)
            project1.Save(dataDir & "project_CurrencyDigits_out.xml", SaveFileFormat.XML)
        End Sub
    End Class
End Namespace