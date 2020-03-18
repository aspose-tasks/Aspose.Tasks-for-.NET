/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using System;
    using System.Data.SqlClient;

    using Aspose.Tasks.Connectivity;
    using Aspose.Tasks.Saving;

    public class ImportProjectDataFromDatabase
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:ImportProjectDataFromDatabase   
            try
            {
                // Create connection string
                var sqlConnectionString = new SqlConnectionStringBuilder();
                sqlConnectionString.DataSource = "192.168.56.2,1433";
                sqlConnectionString.Encrypt = true;
                sqlConnectionString.TrustServerCertificate = true;
                sqlConnectionString.InitialCatalog = "ProjectServer_Published";
                sqlConnectionString.NetworkLibrary = "DBMSSOCN";
                sqlConnectionString.UserID = "sa";
                sqlConnectionString.Password = "*****";

                // Use Aspose.Tasks.Connectivity namespace
                var settings = new MspDbSettings(sqlConnectionString.ConnectionString, new Guid("E6426C44-D6CB-4B9C-AF16-48910ACE0F54"));
                var project = new Project(settings);
                project.Save(dataDir + "ImportProjectDataFromDatabase_out.mpp", SaveFileFormat.MPP);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nPlease setup proper data source (DataSource, InitialCatalog etc)");
            }
            //ExEnd:ImportProjectDataFromDatabase
        }
    }
}