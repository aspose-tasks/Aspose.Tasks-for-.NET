/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.ImportingAndExporting
{
    using System;

    using Aspose.Tasks.Connectivity;
    using Aspose.Tasks.Saving;

    internal class SupportForSQLiteDatabase
    {
        public static void Run()
        {
             // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            try
            {
                //ExStart:SupportForSQLiteDatabase
                var connectionString = "Data Source=" + dataDir + "\\PPMDBSQLite.db";
                const int ProjectId = 4502;

                // Create Primavera DB Settings using connection string and project id
                var settings = new PrimaveraDbSettings(connectionString, ProjectId);
                settings.ProviderInvariantName = "System.Data.SQLite";

                // Create new project using primavera db settings
                var project = new Project(settings);
                project.Save(dataDir + "SupportForSQLiteDatabase_out.mpp", SaveFileFormat.MPP);
                //ExEnd:SupportForSQLiteDatabase
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nPlease setup proper data source (connectionString, ProviderInvariantName) etc");      
            }            
        }
    }
}