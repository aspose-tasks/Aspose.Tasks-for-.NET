namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using System;
    using System.Linq;

    internal class UpdateProjectOnline
    {
        public static void Run()
        {
            UpdateProjectInProjectOnline();
            UpdateProjectInProjectOnlineWithOptions();
        }

        private static void UpdateProjectInProjectOnline()
        {
            // ExStart:UpdateProjectOnline
            string sharepointDomainAddress = "https://contoso.sharepoint.com";
            string userName = "admin@contoso.onmicrosoft.com";
            string password = "MyPassword";

            var credentials = new ProjectServerCredentials(sharepointDomainAddress, userName, password);
            var manager = new ProjectServerManager(credentials);

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
            // ExEnd:UpdateProjectOnline
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        private static void UpdateProjectInProjectOnlineWithOptions()
        {
            // ExStart:UpdateProjectOnlineWithOptions
            string sharepointDomainAddress = "https://contoso.sharepoint.com";
            string userName = "admin@contoso.onmicrosoft.com";
            string password = "MyPassword";

            var credentials = new ProjectServerCredentials(sharepointDomainAddress, userName, password);
            var manager = new ProjectServerManager(credentials);

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

            ProjectServerSaveOptions saveOptions = new ProjectServerSaveOptions()
            {
                Timeout = TimeSpan.FromMinutes(5)
            };

            try
            {
                manager.UpdateProject(myProject, saveOptions);
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine("Failed to update the project. Error: " + ex);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }

            // ExEnd:UpdateProjectOnlineWithOptions
        }
    }
}
