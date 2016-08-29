Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks
Imports Aspose.Tasks.Saving

Namespace Aspose.Tasks.Examples.VisualBasic.HandlingBasicProperties
    Public Class WriteFiscalYearProperties
        Public Shared Sub Run()
            'ExStart: WriteFiscalYearProperties
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_HandlingBasicProperties()

            ''Create a project instance
            'Dim prj As New Project(dataDir & "WriteFiscalYearProperties.mpp")
            ''Set fiscal year properties
            '         prj.[Set](prj.FyStartDate, Month.July)
            '         prj.[Set](prj.FiscalYearStart, True)
            '         prj.Save(dataDir & "saved.mpp", SaveFileFormat.MPP)
            'ExEnd: WriteFiscalYearProperties
        End Sub
    End Class
End Namespace