namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Net;
    using System.Security;
    using Microsoft.SharePoint.Client;
    using NUnit.Framework;

    [TestFixture]
    [SuppressMessage("ReSharper", "StyleCop.SA1108", Justification = "Reviewed. Suppression is OK here.")]
    public class ExProjectServerCredentials : ApiExampleBase
    {
        [Test]
        public void ProjectServerCredentials()
        {
            // ExStart:CreateProjectOnline
            // ExFor: ProjectServerCredentials
            // ExFor: ProjectServerCredentials.#ctor(String,String,String)
            // ExSummary: Shows how to use project server credentials to log on MS Project Online.
            try
            {
                const string SharepointDomainAddress = "https://contoso.sharepoint.com";
                const string UserName = "admin@contoso.onmicrosoft.com";
                const string Password = "MyPassword";

                var credentials = new ProjectServerCredentials(SharepointDomainAddress, UserName, Password);

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

            // ExEnd:CreateProjectOnline
        }

        [Test]
        public void CreateProjectInProjectServer()
        {
            // ExStart:CreateProjectInProjectServer
            // ExFor: ProjectServerCredentials.#ctor(String,NetworkCredential)
            // ExSummary: Shows how to use Project Server credentials with network credentials while reading a project from Microsoft Project Online.
            try
            {
                const string URL = "https://contoso.sharepoint.com";
                const string Domain = "CONTOSO.COM";
                const string UserName = "Administrator";
                const string Password = "MyPassword";

                var project = new Project(DataDir + @"Project1.mpp");

                var windowsCredentials = new NetworkCredential(UserName, Password, Domain);
                var projectServerCredentials = new ProjectServerCredentials(URL, windowsCredentials);
                var manager = new ProjectServerManager(projectServerCredentials);
                manager.CreateNewProject(project);
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // ExEnd:CreateProjectInProjectServer
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void CreateProjectInProjectServer2()
        {
            // ExStart
            // ExFor: ProjectServerCredentials.#ctor(String,String)
            // ExFor: ProjectServerCredentials.AuthToken
            // ExFor: ProjectServerCredentials.SiteUrl
            // ExFor: ProjectServerCredentials.UserName
            // ExSummary: Shows how to use Project Server credentials with SharePointOnlineCredentials while reading a project from Microsoft Project Online.
            try
            {
                const string Username = "your.login@nstincorporated.onmicrosoft.com";
                const string SecuredPassword = "MyPassword";
                var url = new Uri("https://contoso.sharepoint.com");
                var project = new Project(DataDir + "Project1.mpp");
                var password = new SecureString();
                foreach (var c in SecuredPassword)
                {
                    password.AppendChar(c);
                }

                var onlineCredentials = new SharePointOnlineCredentials(Username, password);
                var projectServerCredentials = new ProjectServerCredentials(url.ToString(), onlineCredentials.GetAuthenticationCookie(url, true));

                Console.WriteLine("Project Server Auth Token: " + projectServerCredentials.AuthToken);
                Console.WriteLine("Project Server Site Url: " + projectServerCredentials.SiteUrl);
                Console.WriteLine("Project Server User Name: " + projectServerCredentials.UserName);

                var manager = new ProjectServerManager(projectServerCredentials);
                manager.CreateNewProject(project);
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // ExEnd
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}