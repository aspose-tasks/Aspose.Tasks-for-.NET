Imports System.Data.SqlClient
Imports Aspose.Tasks.Connectivity

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Tasks.Examples.VisualBasic.CreatingAndSaving
    Public Class ImportProjectDataFromDatabase
        Public Shared Sub Run()
            Try
                Dim sqlConnectionString As New SqlConnectionStringBuilder()
                sqlConnectionString.DataSource = "192.168.56.2,1433"
                sqlConnectionString.Encrypt = True
                sqlConnectionString.TrustServerCertificate = True
                sqlConnectionString.InitialCatalog = "ProjectServer_Published"
                sqlConnectionString.NetworkLibrary = "DBMSSOCN"
                sqlConnectionString.UserID = "sa"
                sqlConnectionString.Password = "*****"

                ' Use Aspose.Tasks.Connectivity namespace
                Dim settings As New MspDbSettings(sqlConnectionString.ConnectionString, New Guid("E6426C44-D6CB-4B9C-AF16-48910ACE0F54"))
                Dim project As New Project(settings)
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "Please setup proper datasource (DataSource, InitialCatalog etc)")
            End Try
        End Sub
    End Class
End Namespace