#pragma warning disable 618
namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    using NUnit.Framework;

    [TestFixture]
    public class ExProjectOnlineReader : ApiExampleBase
    {
        [Test]
        [SuppressMessage("ReSharper", "UnusedVariable", Justification = "Reviewed. Suppression is OK here.")]
        public void WorkWithProjectOnlineReader()
        {
            // ExStart:WorkWithProjectOnlineReader
            // ExFor: ProjectOnlineReader
            // ExFor: ProjectOnlineReader.#ctor(ProjectServerCredentials)
            // ExFor: ProjectOnlineReader.GetProject(Guid)
            // ExFor: ProjectOnlineReader.GetProjectList
            // ExFor: ProjectOnlineReader.GetProjectRawData(Guid)
            // ExSummary: Shows how to use <see cref="Aspose.Tasks.ProjectOnlineReader" /> to read work with Microsoft Project Online.
            try
            {
                const string SharepointDomainAddress = "https://contoso.sharepoint.com";
                const string UserName = "admin@contoso.onmicrosoft.com";
                const string Password = "MyPassword";

                var credentials = new ProjectServerCredentials(SharepointDomainAddress, UserName, Password);

                var reader = new ProjectOnlineReader(credentials);
                IEnumerable<ProjectInfo> list = reader.GetProjectList();

                foreach (var info in list)
                {
                    var project = reader.GetProject(info.Id);
                    Console.WriteLine("{0} - {1} - {2}", info.Name, info.CreatedDate, info.LastSavedDate);
                    Console.WriteLine("Resources count: {0}", project.Resources.Count);

                    // one can read project as raw binary date
                    var stream = reader.GetProjectRawData(info.Id);

                    // work with binary representation of the project
                }
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // ExEnd:WorkWithProjectOnlineReader
        }
    }
}