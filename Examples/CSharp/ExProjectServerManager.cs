namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using NUnit.Framework;

    [TestFixture]
    public class ExProjectServerManager : ApiExampleBase
    {
        [Test]
        public void ProjectServerManager()
        {
            //ExStart:CreateProjectOnline
            //ExFor: ProjectServerManager
            //ExSummary: Shows how to use Project Server manager.
            try
            {
                const string sharepointDomainAddress = "https://contoso.sharepoint.com";
                const string userName = "admin@contoso.onmicrosoft.com";
                const string password = "MyPassword";

                var credentials = new ProjectServerCredentials(sharepointDomainAddress, userName, password);

                var project = new Project(DataDir + @"Project1.mpp");

                var manager = new ProjectServerManager(credentials);
                manager.CreateNewProject(project);
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //ExEnd:CreateProjectOnline
        }
        
        [Test]
        public void ProjectServerManagerCreateNewProject()
        {
            //ExStart:ProjectServerManagerCreateNewProject
            //ExFor: ProjectServerManager.CreateNewProject(Project)
            //ExSummary: Shows how to use Project Server manager to create a new project on Microsoft Project Online.
            try
            {
                const string sharepointDomainAddress = "https://contoso.sharepoint.com";
                const string userName = "admin@contoso.onmicrosoft.com";
                const string password = "MyPassword";

                var credentials = new ProjectServerCredentials(sharepointDomainAddress, userName, password);

                var project = new Project(DataDir + @"Project1.mpp");

                var manager = new ProjectServerManager(credentials);
                manager.CreateNewProject(project);
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //ExEnd:ProjectServerManagerCreateNewProject
        }
        
        [Test]
        public void ReadingProjectOnline()
        {
            try
            {
                //ExStart:ReadingProjectOnline
                //ExFor: ProjectServerManager.#ctor(ProjectServerCredentials)
                //ExFor: ProjectServerManager.GetProjectList
                //ExFor: ProjectServerManager.GetProject(Guid)
                //ExSummary: Shows how to read a project from MS Project Online.
                const string SharepointDomainAddress = "https://contoso.sharepoint.com";
                const string UserName = "admin@contoso.onmicrosoft.com";
                const string Password = "MyPassword";

                var credentials = new ProjectServerCredentials(SharepointDomainAddress, UserName, Password);
                var manager = new ProjectServerManager(credentials);
                IEnumerable<ProjectInfo> list = manager.GetProjectList();

                foreach (var info in list)
                {
                    var project = manager.GetProject(info.Id);
                    Console.WriteLine("{0} - {1} - {2}", info.Name, info.CreatedDate, info.LastSavedDate);
                    Console.WriteLine("Resources count: {0}", project.Resources.Count);
                }
                //ExEnd:ReadingProjectOnline
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        [Test]
        public void UpdateProjectServer()
        {
            //ExStart:UpdateProjectServer
            //ExFor: ProjectServerManager.UpdateProject(Project)
            //ExSummary: Shows how to update project on Microsoft Project Online.
            const string url = "https://contoso.sharepoint.com";
            const string domain = "CONTOSO.COM";
            const string userName = "Administrator";
            const string password = "MyPassword";

            var windowsCredentials = new NetworkCredential(userName, password, domain);
            var projectServerCredentials = new ProjectServerCredentials(url, windowsCredentials);
            try
            {
                var manager = new ProjectServerManager(projectServerCredentials);

                var projectInfo = manager.GetProjectList().FirstOrDefault(p => p.Name == "My project");
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

                manager.UpdateProject(project);
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine("Failed to update the project. Error: " + ex);
            }
            //ExEnd:UpdateProjectServer
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void UpdateProjectInProjectOnlineWithOptions()
        {
            //ExStart:UpdateProjectOnlineWithOptions
            //ExFor: ProjectServerManager.UpdateProject(Project,ProjectServerSaveOptions)
            //ExSummary: Shows how to update project on Microsoft Project Online with an usage of Project Server save options.
            const string sharepointDomainAddress = "https://contoso.sharepoint.com";
            const string userName = "admin@contoso.onmicrosoft.com";
            const string password = "MyPassword";

            var credentials = new ProjectServerCredentials(sharepointDomainAddress, userName, password);
            
            try
            {
                var manager = new ProjectServerManager(credentials);

                var projectInfo = manager.GetProjectList().FirstOrDefault(p => p.Name == "My project");
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

                var options = new ProjectServerSaveOptions
                {
                    Timeout = TimeSpan.FromMinutes(5)
                };

                manager.UpdateProject(project, options);
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine("Failed to update the project. Error: " + ex);
            }
            //ExEnd:UpdateProjectOnlineWithOptions
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}