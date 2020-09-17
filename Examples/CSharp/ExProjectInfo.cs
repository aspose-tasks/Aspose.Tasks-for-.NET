namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExProjectInfo : ApiExampleBase
    {
        [Test, Ignore("Should be run explicitly.")]
        public void WorkWithProjectInfo()
        {
            // ExStart
            // ExFor: ProjectInfo
            // ExFor: ProjectInfo.#ctor
            // ExFor: ProjectInfo.Id
            // ExFor: ProjectInfo.Name
            // ExFor: ProjectInfo.CreatedDate
            // ExFor: ProjectInfo.Description
            // ExFor: ProjectInfo.IsCheckedOut
            // ExFor: ProjectInfo.LastPublishedDate
            // ExFor: ProjectInfo.LastSavedDate
            // ExSummary: Shows how to read information about projects from Project Online.
            const string SharepointDomainAddress = "https://contoso.sharepoint.com/sites/pwa";
            const string UserName = "admin@contoso.onmicrosoft.com";
            const string Password = "MyPassword";

            var credentials = new ProjectServerCredentials(SharepointDomainAddress, UserName, Password);

            var reader = new ProjectServerManager(credentials);
            IEnumerable<ProjectInfo> list = reader.GetProjectList();

            // read project's information
            Console.WriteLine("Print information about projects:");
            foreach (var info in list)
            {
                Console.WriteLine("Id: " + info.Id);
                Console.WriteLine("Name: " + info.Name);
                Console.WriteLine("Description: " + info.Description);
                Console.WriteLine("Created Date: " + info.CreatedDate);
                Console.WriteLine("Last Saved Date: " + info.LastSavedDate);
                Console.WriteLine("Last Published Date: " + info.LastPublishedDate);
                Console.WriteLine("Is Checked Out: " + info.IsCheckedOut);
            }

            // ExEnd
        }
    }
}