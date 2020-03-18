namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using System;
    using System.Collections.Generic;

    internal class ReadingProjectOnline
    {
        public static void Run()
        {
            //ExStart:ReadingProjectOnline
            const string SharepointDomainAddress = "https://contoso.sharepoint.com";
            const string UserName = "admin@contoso.onmicrosoft.com";
            const string Password = "MyPassword";

            var credentials = new ProjectServerCredentials(SharepointDomainAddress, UserName, Password);
            var reader = new ProjectServerManager(credentials);
            IEnumerable<ProjectInfo> list = reader.GetProjectList();

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
