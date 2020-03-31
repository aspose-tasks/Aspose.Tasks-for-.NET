namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using Connectivity;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExDbSettings : ApiExampleBase
    {
        [Test]
        public void ImportProjectFromPrimaveraDBSQLite()
        {
            try
            {
                //ExStart:ImportProjectFromPrimaveraDBSQLite
                //ExFor: DbSettings.ProviderInvariantName
                //ExSummary: Shows how to read a project from a Primavera XML file with multiple projects by using a provider name.
                var connectionString = "Data Source=" + DataDir + "\\PPMDBSQLite.db";
                const int ProjectId = 4502;

                // Create Primavera DB Settings using connection string and project id
                var settings = new PrimaveraDbSettings(connectionString, ProjectId);
                settings.ProviderInvariantName = "System.Data.SQLite";

                var project = new Project(settings);
                project.Save(OutDir + "SupportForSQLiteDatabase_out.mpp", SaveFileFormat.MPP);
                //ExEnd:ImportProjectFromPrimaveraDBSQLite
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nPlease setup proper data source (connectionString, ProviderInvariantName) etc");      
            }            
        }
    }
}