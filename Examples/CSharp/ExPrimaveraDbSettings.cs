namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Data.SqlClient;
    using Connectivity;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExPrimaveraDbSettings : ApiExampleBase
    {
        [Test]
        public void ImportProjectFromPrimaveraDB()
        {
            try
            {
                //ExStart:ImportProjectFromPrimaveraDB
                //ExFor: PrimaveraDbSettings.#ctor(String,Int32)
                //ExSummary: Shows how to import a project from a Primavera database.
                var sb = new SqlConnectionStringBuilder();
                sb.DataSource = "192.168.56.3,1433";
                sb.Encrypt = true;
                sb.TrustServerCertificate = true;
                sb.InitialCatalog = "PrimaveraEDB";
                sb.NetworkLibrary = "DBMSSOCN";
                sb.UserID = "privuser";
                sb.Password = "***";

                // Initialize a new instance of the PrimaveraDbSettings class with connection string and project id
                var settings = new PrimaveraDbSettings(sb.ConnectionString, 4502);

                // Initialize a new instance of the Project class
                var project = new Project(settings);
                Console.WriteLine(project.Get(Prj.Name));
                //ExEnd:ImportProjectFromPrimaveraDB
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nPlease setup proper data source (connectionString, ProviderInvariantName) etc");
            }
        }
    }
}