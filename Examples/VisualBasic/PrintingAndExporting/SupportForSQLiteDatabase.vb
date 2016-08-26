Imports System.Collections.Generic
Imports System.IO
Imports Aspose.Tasks
Imports Aspose.Tasks.Connectivity
Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Tasks.Examples.VisualBasic.PrintingAndExporting
    Public Class SupportForSQLiteDatabase
        Public Shared Sub Run()
            ' ExStart:SupportForSQLiteDatabase
            ' The path to the documents directory.
            Const connectionString As String = "SQLiteDatabaseConnectionString"
            Const projectId As Integer = 4502
            Dim primaveraDbSettings As New PrimaveraDbSettings(connectionString, projectId)
            primaveraDbSettings.ProviderInvariantName = "System.Data.SQLite"
            Dim project As New Project(primaveraDbSettings)
            ' ExEnd:SupportForSQLiteDatabase
        End Sub
    End Class
End Namespace