namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using NUnit.Framework;

    [TestFixture]
    public class ExProjectServerCredentials : ApiExampleBase
    {
        [Test]
        public void ProjectServerCredentials()
        {
            //ExStart:CreateProjectOnline
            //ExFor: ProjectServerCredentials
            //ExFor: ProjectServerCredentials.#ctor(String,String,String)
            //ExSummary: Shows how to use project server credentials to log on MS Project Online.
            try
            {
                var sharepointDomainAddress = "https://contoso.sharepoint.com";
                var userName = "admin@contoso.onmicrosoft.com";
                var password = "MyPassword";

                var credentials = new ProjectServerCredentials(sharepointDomainAddress, userName, password);

                var newProject = new Project(DataDir + @"Project1.mpp");

                var manager = new ProjectServerManager(credentials);
                manager.CreateNewProject(newProject);
                
                IEnumerable<ProjectInfo> list = manager.GetProjectList();

                foreach (var info in list)
                {
                    var project = manager.GetProject(info.Id);
                    Console.WriteLine("{0} - {1} - {2}", info.Name, info.CreatedDate, info.LastSavedDate);
                    Console.WriteLine("Resources count: {0}", project.Resources.Count);
                }
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //ExEnd:CreateProjectOnline
        }
        
        [Test]
        public void CreateProjectInProjectServer()
        {
            //ExStart:CreateProjectInProjectServer
            //ExFor: ProjectServerCredentials.#ctor(String,NetworkCredential)
            //ExSummary: Shows how to use Project Server credentials with network credentials while reading a project from Microsoft Project Online.
            try
            {
                var url = "https://contoso.sharepoint.com";
                var domain = "CONTOSO.COM";
                var userName = "Administrator";
                var password = "MyPassword";

                var project = new Project(DataDir + @"Project1.mpp");

                var windowsCredentials = new NetworkCredential(userName, password, domain);
                var projectServerCredentials = new ProjectServerCredentials(url, windowsCredentials);
                var manager = new ProjectServerManager(projectServerCredentials);
                manager.CreateNewProject(project);
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //ExEnd:CreateProjectInProjectServer
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}