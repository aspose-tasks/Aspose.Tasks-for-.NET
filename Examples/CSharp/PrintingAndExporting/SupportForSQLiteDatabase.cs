using System;
using Aspose.Tasks.Connectivity;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.PrintingAndExporting
{
    public class SupportForSQLiteDatabase
    {
        public static void Run()
        {
            // ExStart:SupportForSQLiteDatabase
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PrintingAndExporting();

            try
            {
                const string connectionString = "SQLiteDatabaseConnectionString";
                const int projectId = 4502;
                PrimaveraDbSettings primaveraDbSettings = new PrimaveraDbSettings(connectionString, projectId);
                primaveraDbSettings.ProviderInvariantName = "System.Data.SQLite";
                Project project = new Project(primaveraDbSettings);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nPlease setup proper datasource (connectionString, ProviderInvariantName) etc");      
            }
            // ExEnd:SupportForSQLiteDatabase
        }
    }
}