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
    using System.Data.SqlClient;

    using Aspose.Tasks.Connectivity;

    internal class ImportProjectFromPrimaveraDB
    {
        public static void Run()
        {
            //ExStart:ImportProjectFromPrimaveraDB
            //ExFor: PrimaveraDbSettings(String, int)
            //ExFor: Project(DbSettings)
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
    }
}
