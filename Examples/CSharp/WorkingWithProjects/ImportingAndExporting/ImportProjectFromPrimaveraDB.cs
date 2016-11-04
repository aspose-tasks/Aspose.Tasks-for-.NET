using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Aspose.Tasks.Connectivity;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.ImportingAndExporting
{
    class ImportProjectFromPrimaveraDB
    {
        public static void Run()
        {
            // ExStart:ImportProjectFromPrimaveraDB
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = "192.168.56.3,1433";
            sb.Encrypt = true;
            sb.TrustServerCertificate = true;
            sb.InitialCatalog = "PrimaveraEDB";
            sb.NetworkLibrary = "DBMSSOCN";
            sb.UserID = "privuser";
            sb.Password = "***";

            // Initialize a new instance of the PrimaveraDbSettings class with connection string and project id
            PrimaveraDbSettings settings = new PrimaveraDbSettings(sb.ConnectionString, 4502);

            // Initialize a new instance of the Project class
            Project project = new Project(settings);
            // ExEnd:ImportProjectFromPrimaveraDB
        }

    }
}
