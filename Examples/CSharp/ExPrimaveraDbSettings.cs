namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Data.SqlClient;
    using Connectivity;
    using NUnit.Framework;

    [TestFixture]
    public class ExPrimaveraDbSettings : ApiExampleBase
    {
        [Test, Category("Database")]
        public void ImportProjectFromPrimaveraDB()
        {
            try
            {
                // ExStart:ImportProjectFromPrimaveraDB
                // ExFor: PrimaveraDbSettings
                // ExFor: PrimaveraDbSettings.#ctor(String,Int32)
                // ExFor: PrimaveraDbSettings.ProjectId
                // ExSummary: Shows how to import a project from a Primavera database.
                var sb = new SqlConnectionStringBuilder();
                sb.DataSource = "192.168.56.3,1433";
                sb.Encrypt = true;
                sb.TrustServerCertificate = true;
                sb.InitialCatalog = "PrimaveraEDB";
                sb.NetworkLibrary = "DBMSSOCN";
                sb.UserID = "privuser";
                sb.Password = "***";
                sb.ConnectTimeout = 2; // ExSkip

                // Initialize a new instance of the PrimaveraDbSettings class with connection string and project id
                var settings = new PrimaveraDbSettings(sb.ConnectionString, 4502);

                Console.WriteLine("Project UID to read: " + settings.ProjectId);

                // read the project with UID = 4502
                var project = new Project(settings);
                Console.WriteLine(project.Get(Prj.Uid));

                // ExEnd:ImportProjectFromPrimaveraDB
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nPlease setup proper data source (connectionString, ProviderInvariantName) etc");
            }
            catch (TasksReadingException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}