using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    internal class ReadAndCreateInProjectServer
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            ReadProjectFromProjectServer(dataDir);
            CreateProjectInProjectServer(dataDir);
        }

        public static void ReadProjectFromProjectServer(string dataDir)
        {
            try
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
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void CreateProjectInProjectServer(string dataDir)
        {
            try
            {
                // ExStart:CreateProjectInProjectServer
                string url = "https://contoso.sharepoint.com";
                string domain = "CONTOSO.COM";
                string userName = "Administrator";
                string password = "MyPassword";

                var project = new Project(dataDir + @"TestProject1.mpp");

                var windowsCredentials = new NetworkCredential(userName, password, domain);
                var projectServerCredentials = new ProjectServerCredentials(url, windowsCredentials);
                ProjectServerManager manager = new ProjectServerManager(projectServerCredentials);
                manager.CreateNewProject(project);
                // ExEnd:CreateProjectInProjectServer
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
