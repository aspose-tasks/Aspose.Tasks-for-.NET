namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using System;

    internal class CreateProjectOnline
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            try
            {
                // ExStart:CreateProjectOnline
                string sharepointDomainAddress = "https://contoso.sharepoint.com";
                string userName = "admin@contoso.onmicrosoft.com";
                string password = "MyPassword";

                var credentials = new ProjectServerCredentials(sharepointDomainAddress, userName, password);

                var project = new Project(dataDir + @"TestProject1.mpp");

                ProjectServerManager manager = new ProjectServerManager(credentials);
                manager.CreateNewProject(project);
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // ExEnd:CreateProjectOnline
        }
    }
}
