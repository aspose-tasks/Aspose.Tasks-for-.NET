using System;
using System.Data.SqlClient;
using Aspose.Tasks.Connectivity;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    public class ImportProjectDataFromDatabase
    {
        public static void Run()
        {
            // ExStart:ImportProjectDataFromDatabase   
            try
            {
                // Create connection string
                SqlConnectionStringBuilder sqlConnectionString = new SqlConnectionStringBuilder();
                sqlConnectionString.DataSource = "192.168.56.2,1433";
                sqlConnectionString.Encrypt = true;
                sqlConnectionString.TrustServerCertificate = true;
                sqlConnectionString.InitialCatalog = "ProjectServer_Published";
                sqlConnectionString.NetworkLibrary = "DBMSSOCN";
                sqlConnectionString.UserID = "sa";
                sqlConnectionString.Password = "*****";

                // Use Aspose.Tasks.Connectivity namespace
                MspDbSettings settings = new MspDbSettings(sqlConnectionString.ConnectionString, new Guid("E6426C44-D6CB-4B9C-AF16-48910ACE0F54"));
                Project project = new Project(settings);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nPlease setup proper datasource (DataSource, InitialCatalog etc)");
            }
            
            // ExEnd:ImportProjectDataFromDatabase
        }
    }
}