using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    class ReadingProjectOnline
    {
        public static void Run()
        {
            //ExStart:ReadingProjectOnline
            string sharepointDomainAddress = "https://contoso.sharepoint.com";
            string userName = "admin@contoso.onmicrosoft.com";
            string password = "MyPassword";

            var credentials = new ProjectServerCredentials(sharepointDomainAddress, userName, password);
            var reader = new ProjectServerManager(credentials);
            var list = reader.GetProjectList();

            foreach (var p in list)
            {
                var project = reader.GetProject(p.Id);
                Console.WriteLine("{0} - {1} - {2}", p.Name, p.CreatedDate, p.LastSavedDate);
                Console.WriteLine("Resources count: {0}", project.Resources.Count);
            }
            //ExEnd:ReadingProjectOnline
        }
    }
}
