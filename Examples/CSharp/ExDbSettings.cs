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
                //ExFor: DbSettings
                //ExFor: DbSettings.#ctor(String)
                //ExFor: DbSettings.ConnectionString
                //ExFor: DbSettings.ProviderInvariantName
                //ExSummary: Shows how to read a project from a Primavera XML file with multiple projects by using a provider name.
                var connectionString = "Data Source=" + DataDir + "\\PPMDBSQLite.db";

                // Create Primavera DB Settings using connection string and project id
                var settings = new PrimaveraDbSettings(connectionString, 4502);
                settings.ProviderInvariantName = "System.Data.SQLite";

                Console.WriteLine("Connection String: " + settings.ConnectionString);
                Console.WriteLine("Provider Name: " + settings.ProviderInvariantName);
                
                var project = new Project(settings);
                project.Save(OutDir + "SupportForSQLiteDatabase_out.mpp", SaveFileFormat.MPP);
                //ExEnd:ImportProjectFromPrimaveraDBSQLite
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message + "\nPlease setup proper data source (connectionString, ProviderInvariantName) etc");      
            }
            catch (TasksReadingException ex)
            {
                Console.WriteLine(ex.Message + "\nPlease setup proper data source (connectionString, ProviderInvariantName) etc");      
            }          
        }
    }
}