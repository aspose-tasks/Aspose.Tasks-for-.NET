Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks
Imports Aspose.Tasks.Saving

Namespace WorkingWithProjects.WorkingWithProjectProperties
    Public Class WriteCurrencyProperties
        Public Shared Sub Run()
            ' Exstart: WriteCurrencyProperties
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' Create a project instance
            Dim project As New Project(dataDir & "WriteCurrencyProperties.mpp")

            ' Set currency properties
            project.Set(Prj.CurrencyCode, "AUD")
            project.Set(Prj.CurrencyDigits, 2)
            project.Set(Prj.CurrencySymbol, "$")
            project.Set(Prj.CurrencySymbolPosition, CurrencySymbolPositionType.After)

            ' Save the project as XML project file
            project.Save(dataDir & "WriteCurrencyProperties_out.xml", SaveFileFormat.XML)
            ' ExEnd: WriteCurrencyProperties
        End Sub
    End Class
End Namespace