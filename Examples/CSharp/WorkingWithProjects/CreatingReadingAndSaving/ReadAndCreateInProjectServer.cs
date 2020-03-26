using System;
using System.Net;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    internal class ReadAndCreateInProjectServer
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            ReadProjectFromProjectServer();
            CreateProjectInProjectServer(dataDir);
        }

        public static void ReadProjectFromProjectServer()
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
            // ExStart:CreateProjectInProjectServer
            try
            {
                string url = "https://contoso.sharepoint.com";
                string domain = "CONTOSO.COM";
                string userName = "Administrator";
                string password = "MyPassword";

                var project = new Project(dataDir + @"TestProject1.mpp");

                var windowsCredentials = new NetworkCredential(userName, password, domain);
                var projectServerCredentials = new ProjectServerCredentials(url, windowsCredentials);
                ProjectServerManager manager = new ProjectServerManager(projectServerCredentials);
                manager.CreateNewProject(project);
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // ExEnd:CreateProjectInProjectServer
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        private static void CreateProjectInProjectServerWithOptions(string dataDir)
        {
            // ExStart:CreateProjectInProjectServerWithOptions
            try
            {
                string url = "https://contoso.sharepoint.com";
                string domain = "CONTOSO.COM";
                string userName = "Administrator";
                string password = "MyPassword";

                var project = new Project(dataDir + @"TestProject1.mpp");

                var windowsCredentials = new NetworkCredential(userName, password, domain);
                var projectServerCredentials = new ProjectServerCredentials(url, windowsCredentials);
                ProjectServerManager manager = new ProjectServerManager(projectServerCredentials);
                ProjectServerSaveOptions saveOptions = new ProjectServerSaveOptions()
                {
                    ProjectGuid = Guid.NewGuid(),
                    ProjectName = "New project",
                    Timeout = TimeSpan.FromMinutes(5)
                };
                
                manager.CreateNewProject(project, saveOptions);
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // ExEnd:CreateProjectInProjectServerWithOptions
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

    }
}
