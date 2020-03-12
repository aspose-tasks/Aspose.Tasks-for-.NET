using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    class ReadAndCreateInProjectServer
    {
        public static void Run()
        {
            ReadProjectFromProjectServer();
            CreateProjectInProjectServer();
        }

        public static void ReadProjectFromProjectServer()
        {
            // ExStart:ReadProjectFromProjectServer
            string url = "https://contoso.sharepoint.com";
            string domain = "CONTOSO.COM";
            string userName = "Administrator";
            string password = "MyPassword";

            var windowsCredentials = new NetworkCredential(userName, password, domain);
            var projectServerCredentials = new ProjectServerCredentials(url, windowsCredentials);
            ProjectServerManager manager = new ProjectServerManager(projectServerCredentials);

            var list = manager.GetProjectList();
            foreach (var projectInfo in list)
            {
                Console.WriteLine("{0} - {1} - {2}", projectInfo.Id, projectInfo.CreatedDate, projectInfo.Name);
            }
            // ExEnd:ReadProjectFromProjectServer
        }

        public static void CreateProjectInProjectServer()
        {
            // ExStart:CreateProjectInProjectServer
            string url = "https://contoso.sharepoint.com";
            string domain = "CONTOSO.COM";
            string userName = "Administrator";
            string password = "MyPassword";

            var project = new Project(@"sample.mpp");

            var windowsCredentials = new NetworkCredential(userName, password, domain);
            var projectServerCredentials = new ProjectServerCredentials(url, windowsCredentials);
            ProjectServerManager manager = new ProjectServerManager(projectServerCredentials);
            manager.CreateNewProject(project);
            // ExEnd:CreateProjectInProjectServer
        }
    }
}
