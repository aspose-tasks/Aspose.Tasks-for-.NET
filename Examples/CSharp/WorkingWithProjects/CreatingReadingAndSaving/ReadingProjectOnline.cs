using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    class ReadingProjectOnline
    {
        public static void Run()
        {
            // ExStart:ReadingProjectOnline
            string sharepointDomainAddress = "https://contoso.sharepoint.com";
            string userName = "admin@contoso.onmicrosoft.com";
            string password = "MyPassword";

            var credentials = new ProjectServerCredentials(sharepointDomainAddress, userName, password);
            ProjectOnlineReader reader = new ProjectOnlineReader(credentials);
            var list = reader.GetProjectList();

            foreach (var p in list)
            {
                Console.WriteLine("{0} - {1} - {2}", p.Name, p.CreatedDate, p.LastSavedDate);
            }

            foreach (var p in list)
            {
                var project = reader.GetProject(p.Id);
                Console.WriteLine("Project '{0}' loaded. Resources count: {1}",
                    p.Name,
                    project.Resources.Count);
            }
            // ExEnd:ReadingProjectOnline
        }
    }
}
