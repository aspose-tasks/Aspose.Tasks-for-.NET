﻿namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Net;
    using NUnit.Framework;

    [TestFixture]
    [SuppressMessage("ReSharper", "StyleCop.SA1108", Justification = "Reviewed. Suppression is OK here.")]
    public class ExProjectServerManager : ApiExampleBase
    {
        [Test, Ignore("Should be run explicitly.")]
        public void ProjectServerManager()
        {
            // ExStart:CreateProjectOnline
            // ExFor: ProjectServerManager
            // ExFor: ProjectServerManager.CreateNewProject(Project,ProjectServerSaveOptions)
            // ExSummary: Shows how to use Project Server manager to create a new project with predefined save options on Microsoft Project Online.
            try
            {
                const string sharepointDomainAddress = "https://contoso.sharepoint.com/sites/pwa";
                const string UserName = "admin@contoso.onmicrosoft.com";
                const string Password = "MyPassword";

                var credentials = new ProjectServerCredentials(sharepointDomainAddress, UserName, Password);

                var project = new Project(DataDir + @"Project1.mpp");

                var manager = new ProjectServerManager(credentials);
                var options = new ProjectServerSaveOptions
                {
                    Timeout = TimeSpan.FromSeconds(10)
                };
                manager.CreateNewProject(project, options);
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // ExEnd:CreateProjectOnline
        }

        [Test, Ignore("Should be run explicitly.")]
        public void ProjectServerManagerExecutingWebRequestEvent()
        {
            // ExStart:ExecutingWebRequestEvent
            // ExFor: ProjectServerManager.ExecutingWebRequest
            // ExSummary: Shows how to use ProjectServerManager.ExecutingWebRequest event to customize web requests issued to Project Server.
            try
            {
                const string SiteUrl = "https://myprojectserver/sites/pwa";
                const string UserName = "test_user";
                const string Password = "MyPassword";

                var credentials = new ProjectServerCredentials(SiteUrl, new NetworkCredential(UserName, Password));

                var project = new Project(DataDir + @"Project1.mpp");

                var manager = new ProjectServerManager(credentials);
                manager.ExecutingWebRequest += delegate (object sender, WebRequestEventArgs e)
                {
                    e.WebRequest.Headers.Add("XMyCustomHeader", "testvalue");
                };

                var list = manager.GetProjectList();
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // ExEnd:ExecutingWebRequestEvent
        }

        [Test, Ignore("Should be run explicitly.")]
        public void ProjectServerManagerCreateNewProject()
        {
            // ExStart:ProjectServerManagerCreateNewProject
            // ExFor: ProjectServerManager.CreateNewProject(Project)
            // ExSummary: Shows how to use ProjectServerManager to create a new project on Microsoft Project Online.
            try
            {
                const string SharepointDomainAddress = "https://contoso.sharepoint.com/sites/pwa";
                const string UserName = "admin@contoso.onmicrosoft.com";
                const string Password = "MyPassword";

                var credentials = new ProjectServerCredentials(SharepointDomainAddress, UserName, Password);

                var project = new Project(DataDir + @"Project1.mpp");

                var manager = new ProjectServerManager(credentials);
                manager.CreateNewProject(project);
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // ExEnd:ProjectServerManagerCreateNewProject
        }

        [SuppressMessage("ReSharper", "UnusedVariable", Justification = "Reviewed. Suppression is OK here.")]
        [Test, Ignore("Should be run explicitly.")]
        public void ReadingProjectOnline()
        {
            try
            {
                // ExStart:ReadingProjectOnline
                // ExFor: ProjectServerManager.#ctor(ProjectServerCredentials)
                // ExFor: ProjectServerManager.GetProjectList
                // ExFor: ProjectServerManager.GetProject(Guid)
                // ExSummary: Shows how to read a project from Microsoft Project Online.
                const string SharepointDomainAddress = "https://contoso.sharepoint.com/sites/pwa";
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

                // ExEnd:ReadingProjectOnline
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [SuppressMessage("ReSharper", "UnusedVariable", Justification = "Reviewed. Suppression is OK here.")]
        [Test, Ignore("Should be run explicitly.")]
        public void ReadingRawProjectData()
        {
            try
            {
                // ExStart:GetProjectRawData
                // ExFor: ProjectServerManager.GetProjectRawData(Guid)
                // ExSummary: Shows how to retrieve project's raw data from Microsoft Project Online for troubleshooting purposes.
                const string SharepointDomainAddress = "https://contoso.sharepoint.com/sites/pwa";
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

                    // The user can read the project as raw data stream for troubleshooting purposes.
                    using (FileStream fs = File.Create(OutDir + "projectRawData.zip"))
                    {
                        using (var stream = manager.GetProjectRawData(info.Id))
                        {
                            stream.CopyTo(fs);
                        }
                    }

                    // you can pass the resulting file to support.
                }

                // ExEnd:GetProjectRawData
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [Test]
        public void UpdateProjectServer()
        {
            // ExStart:UpdateProjectServer
            // ExFor: ProjectServerManager.UpdateProject(Project)
            // ExSummary: Shows how to update project on Microsoft Project Online.
            const string URL = "https://contoso.sharepoint.com/sites/pwa";
            const string Domain = "CONTOSO.COM";
            const string UserName = "Administrator";
            const string Password = "MyPassword";

            var windowsCredentials = new NetworkCredential(UserName, Password, Domain);
            var projectServerCredentials = new ProjectServerCredentials(URL, windowsCredentials);
            try
            {
                var manager = new ProjectServerManager(projectServerCredentials);

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

                manager.UpdateProject(project);
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine("Failed to update the project. Error: " + ex);
            }

            // ExEnd:UpdateProjectServer
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
            // ExFor: ProjectServerManager.UpdateProject(Project,ProjectServerSaveOptions)
            // ExSummary: Shows how to update project on Microsoft Project Online with an usage of Project Server save options.
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