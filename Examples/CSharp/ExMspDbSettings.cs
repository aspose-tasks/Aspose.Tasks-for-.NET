namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Data.SqlClient;
    using Connectivity;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExMspDbSettings : ApiExampleBase
    {
        [Test]
        public void ImportProjectDataFromDatabase()
        {
            //ExStart:ImportProjectDataFromDatabase
            //ExFor: MspDbSettings
            //ExFor: MspDbSettings.#ctor(String, Guid)
            //ExFor: MspDbSettings.Schema
            //ExFor: MspDbSettings.ProjectGuid
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

                // create settings to load from MS database
                var settings = new MspDbSettings(connectionString.ConnectionString, new Guid("E6426C44-D6CB-4B9C-AF16-48910ACE0F54"));
                settings.Schema = "dbo";
                
                Console.WriteLine("Project GUID to load:" + settings.ProjectGuid);
                
                var project = new Project(settings);

                project.Save(OutDir + "ImportProjectDataFromDatabase_out.mpp", SaveFileFormat.MPP);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Please setup proper data source (DataSource, InitialCatalog etc)");
            }
            //ExEnd:ImportProjectDataFromDatabase
        }
    }
}