using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    class CreateProjectOnline
    {
        public static void Run()
        {
            // ExStart:CreateProjectOnline
            string sharepointDomainAddress = "https://contoso.sharepoint.com";
            string userName = "admin@contoso.onmicrosoft.com";
            string password = "MyPassword";

            var credentials = new ProjectServerCredentials(sharepointDomainAddress, userName, password);

            var project = new Project(@"sample.mpp");

            ProjectServerManager manager = new ProjectServerManager(credentials);
            manager.CreateNewProject(project);
            // ExEnd:CreateProjectOnline
        }
    }
}
