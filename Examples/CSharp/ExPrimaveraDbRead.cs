namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Data.SqlClient;
    using Connectivity;
    using NUnit.Framework;

    [TestFixture]
    public class ExPrimaveraDbRead : ApiExampleBase
    {
        [Test, Category("Database")]
        public void ImportProjectFromPrimaveraDb()
        {
            try
            {
                // ExStart:ImportProjectFromPrimaveraDB
                // ExFor: PrimaveraDbSettings
                // ExFor: PrimaveraDbSettings.#ctor(String,Int32)
                // ExFor: PrimaveraDbSettings.ProjectId
                // ExSummary: Shows how to import a project from a Primavera database.

                // Initialize a new instance of the PrimaveraDbSettings class with connection string and project id
                var settings = new PrimaveraDbSettings(GetConnectionString(), 4502);

                Console.WriteLine("Project UID to read: " + settings.ProjectId);

                // read the project with UID = 4502
                var project = new Project(settings);
                Console.WriteLine(project.Uid);
                Console.WriteLine(project.Name);
                Console.WriteLine(project.PrimaveraProperties.ShortName);

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

        [Test, Category("Database")]
        public void GetProjectInfosFromPrimaveraDb()
        {
            try
            {
                // ExStart:TestPrimaveraDbReader
                // ExFor: PrimaveraDbSettings
                // ExFor: PrimaveraDbReader
                // ExFor: PrimaveraDbReader.GetProjectInfos
                // ExSummary: Shows how to get brief info of projects from a Primavera database.

                var settings = new PrimaveraDbSettings(GetConnectionString(), 0);

                var reader = new PrimaveraDbReader(settings);
                var projectInfos = reader.GetProjectInfos();

                foreach (var info in projectInfos)
                {
                    Console.WriteLine("{0} - '{1}' - '{2}'", info.Uid, info.ShortName, info.Name);
                }

                var firstProject = reader.LoadProject(projectInfos[0].Uid);
                Console.WriteLine(firstProject.Uid);
                Console.WriteLine(firstProject.Name);
                Console.WriteLine(firstProject.PrimaveraProperties.ShortName);

                // ExEnd:TestPrimaveraDbReader
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

        private static string GetConnectionString()
        {
            var sb = new SqlConnectionStringBuilder();
            sb.DataSource = "192.168.56.3,1433";
            sb.Encrypt = true;
            sb.TrustServerCertificate = true;
            sb.InitialCatalog = "PrimaveraEDB";
            sb.NetworkLibrary = "DBMSSOCN";
            sb.UserID = "privuser";
            sb.Password = "***";
            sb.ConnectTimeout = 2; // ExSkip
            return sb.ConnectionString;
        }
    }
}