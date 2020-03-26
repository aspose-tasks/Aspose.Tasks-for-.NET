namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using System;
    using System.Linq;
    using System.Net;

    internal class UpdateInProjectServer
    {
        public static void Run()
        {
            // ExStart:UpdateProjectServer
            string url = "https://contoso.sharepoint.com";
            string domain = "CONTOSO.COM";
            string userName = "Administrator";
            string password = "MyPassword";

            var windowsCredentials = new NetworkCredential(userName, password, domain);
            var projectServerCredentials = new ProjectServerCredentials(url, windowsCredentials);
            ProjectServerManager manager = new ProjectServerManager(projectServerCredentials);

            var myProjectInfo = manager.GetProjectList().FirstOrDefault(p => p.Name == "My project");

            if (myProjectInfo == null)
            {
                Console.WriteLine("Project 'My project' not found in working store of Project Online account.");
                return;
            }

            var myProject = manager.GetProject(myProjectInfo.Id);

            myProject.Set(Prj.FinishDate, new DateTime(2020, 03, 01));

            var task = myProject.RootTask.Children.Add("New task");
            task.Set(Tsk.Start, new DateTime(2020, 02, 26));
            task.Set(Tsk.Duration, myProject.GetDuration(2, TimeUnitType.Day));

            try
            {
                manager.UpdateProject(myProject);
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine("Failed to update the project. Error: " + ex);
            }
            // ExEnd:UpdateProjectServer
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
