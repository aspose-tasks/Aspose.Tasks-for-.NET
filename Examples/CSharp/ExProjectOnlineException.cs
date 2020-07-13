namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Net;
    using NUnit.Framework;

    [TestFixture]
    [SuppressMessage("ReSharper", "StyleCop.SA1108", Justification = "Reviewed. Suppression is OK here.")]
    public class ExProjectOnlineException : ApiExampleBase
    {
        [Test]
        public void CreateProjectInProjectServer()
        {
            // ExStart:CreateProjectInProjectServer
            // ExFor: ProjectOnlineException
            // ExFor: ProjectOnlineException.#ctor(SerializationInfo,StreamingContext)
            // ExSummary: Shows how to catch exception while reading a project from MS Project Online.
            try
            {
                const string URL = "https://project_server.local/sites/pwa";
                const string Domain = "CONTOSO.COM";
                const string UserName = "Administrator";
                const string Password = "MyPassword";

                var project = new Project(DataDir + @"Project1.mpp");

                var windowsCredentials = new NetworkCredential(UserName, Password, Domain);
                var projectServerCredentials = new ProjectServerCredentials(URL, windowsCredentials);
                var manager = new ProjectServerManager(projectServerCredentials);
                manager.CreateNewProject(project);
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // ExEnd:CreateProjectInProjectServer
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}