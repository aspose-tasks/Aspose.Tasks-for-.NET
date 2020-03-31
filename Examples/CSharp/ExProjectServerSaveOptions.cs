namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Linq;
    using System.Net;
    using NUnit.Framework;

    [TestFixture]
    public class ExProjectServerSaveOptions : ApiExampleBase
    {
        [Test]
        public void CreateProjectInProjectServerWithOptions()
        {
            //ExStart:CreateProjectInProjectServerWithOptions
            //ExFor: ProjectServerSaveOptions
            //ExSummary: Shows how to use <see cref="Aspose.Tasks.ProjectServerSaveOptions" /> options to create a new project in Microsoft Project Online.
            try
            {
                const string url = "https://contoso.sharepoint.com";
                const string domain = "CONTOSO.COM";
                const string userName = "Administrator";
                const string password = "MyPassword";

                var project = new Project(DataDir + @"TestProject1.mpp");

                var windowsCredentials = new NetworkCredential(userName, password, domain);
                var projectServerCredentials = new ProjectServerCredentials(url, windowsCredentials);
                var manager = new ProjectServerManager(projectServerCredentials);
                var saveOptions = new ProjectServerSaveOptions
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
            //ExEnd:CreateProjectInProjectServerWithOptions
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void UpdateProjectInProjectOnlineWithOptions()
        {
            //ExStart:UpdateProjectOnlineWithOptions
            //ExFor: ProjectServerSaveOptions.Timeout
            //ExSummary: Shows how to update project on Microsoft Project Online and control save timeout value.
            var sharepointDomainAddress = "https://contoso.sharepoint.com";
            var userName = "admin@contoso.onmicrosoft.com";
            var password = "MyPassword";

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