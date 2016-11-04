Imports System.Data.SqlClient
Imports Aspose.Tasks.Connectivity

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects.ImportingAndExporting
    Public Class ImportProjectFromPrimaveraDB
        Public Shared Sub Run()
            ' ExStart:ImportProjectFromPrimaveraDB
            Dim sb As New SqlConnectionStringBuilder()
            sb.DataSource = "192.168.56.3,1433"
            sb.Encrypt = True
            sb.TrustServerCertificate = True
            sb.InitialCatalog = "PrimaveraEDB"
            sb.NetworkLibrary = "DBMSSOCN"
            sb.UserID = "privuser"
            sb.Password = "***"

            ' Initialize a new instance of the PrimaveraDbSettings class with connection string and project id
            Dim settings As New PrimaveraDbSettings(sb.ConnectionString, 4502)

            ' Initialize a new instance of the Project class
            Dim project As New Project(settings)
            ' ExEnd:ImportProjectFromPrimaveraDB
        End Sub
    End Class
End Namespace
