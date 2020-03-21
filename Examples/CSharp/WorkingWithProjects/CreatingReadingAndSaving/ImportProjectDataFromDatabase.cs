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

    internal class ImportProjectDataFromDatabase
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:ImportProjectDataFromDatabase
            //ExFor: MspDbSettings(String, Guid)
            //ExFor: Project(MspDbSettings)
            //ExSummary: Shows how to import a project from a database.
            try
            {
                // Create connection string
                var connectionString = new SqlConnectionStringBuilder();
                connectionString.DataSource = "192.168.56.2,1433";
                connectionString.Encrypt = true;
                connectionString.TrustServerCertificate = true;
                connectionString.InitialCatalog = "ProjectServer_Published";
                connectionString.NetworkLibrary = "DBMSSOCN";
                connectionString.UserID = "sa";
                connectionString.Password = "*****";

                // Use Aspose.Tasks.Connectivity namespace
                var settings = new MspDbSettings(connectionString.ConnectionString, new Guid("E6426C44-D6CB-4B9C-AF16-48910ACE0F54"));
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