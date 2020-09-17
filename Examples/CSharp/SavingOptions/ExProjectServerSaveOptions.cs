namespace Aspose.Tasks.Examples.CSharp.SavingOptions
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Net;
    using NUnit.Framework;

    [TestFixture]
    [SuppressMessage("ReSharper", "StyleCop.SA1108", Justification = "Reviewed. Suppression is OK here.")]
    public class ExProjectServerSaveOptions : ApiExampleBase
    {
        [Test]
        public void CreateProjectInProjectServerWithOptions()
        {
            // ExStart:CreateProjectInProjectServerWithOptions
            // ExFor: ProjectServerSaveOptions
            // ExFor: ProjectServerSaveOptions.#ctor
            // ExFor: ProjectServerSaveOptions.ProjectGuid
            // ExFor: ProjectServerSaveOptions.ProjectName
            // ExFor: ProjectServerSaveOptions.PollingInterval
            // ExSummary: Shows how to use <see cref="Aspose.Tasks.ProjectServerSaveOptions" /> options to create a new project in on-premise instance of Project Server.
            try
            {
                const string URL = "https://project_server.local/sites/pwa";
                const string Domain = "CONTOSO.COM";
                const string UserName = "Administrator";
                const string Password = "MyPassword";

                var project = new Project(DataDir + @"Project1.mpp");

                var windowsCredentials = new NetworkCredential(UserName, Password, Domain);
                var projectServerCredentials = new ProjectServerCredentials(URL, windowsCredentials);
                var manager = new ProjectServerManager(projectServerCredentials);
                var options = new ProjectServerSaveOptions
                                  {
                                      ProjectGuid = Guid.NewGuid(),
                                      ProjectName = "New project",
                                      Timeout = TimeSpan.FromMinutes(5),
                                      PollingInterval = TimeSpan.FromSeconds(3)
                                  };

                manager.CreateNewProject(project, options);
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // ExEnd:CreateProjectInProjectServerWithOptions
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void UpdateProjectInProjectOnlineWithOptions()
        {
            // ExStart:UpdateProjectOnlineWithOptions
            // ExFor: ProjectServerSaveOptions.Timeout
            // ExSummary: Shows how to update project on Microsoft Project Online and control save timeout value.
            const string SharepointDomainAddress = "https://contoso.sharepoint.com/sites/pwa";
            const string UserName = "admin@contoso.onmicrosoft.com";
            const string Password = "MyPassword";

            var credentials = new ProjectServerCredentials(SharepointDomainAddress, UserName, Password);
            try
            {
                var manager = new ProjectServerManager(credentials);

                ProjectInfo projectInfo = null;
                foreach (var info in manager.GetProjectList())
                {
                    if (info.Name == "My project")
                    {
                        projectInfo = info;
                    }
                }

                if (projectInfo == null)
                {
                    Console.WriteLine("Project 'My project' not found in working store of Project Online account.");
                    return;
                }

                var project = manager.GetProject(projectInfo.Id);
                project.Set(Prj.FinishDate, new DateTime(2020, 03, 01));

                var task = project.RootTask.Children.Add("New task");
                task.Set(Tsk.Start, new DateTime(2020, 02, 26));
                task.Set(Tsk.Duration, project.GetDuration(2, TimeUnitType.Day));

                var options = new ProjectServerSaveOptions { Timeout = TimeSpan.FromMinutes(5) };

                manager.UpdateProject(project, options);
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine("Failed to update the project. Error: " + ex);
            }

            // ExEnd:UpdateProjectOnlineWithOptions
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}