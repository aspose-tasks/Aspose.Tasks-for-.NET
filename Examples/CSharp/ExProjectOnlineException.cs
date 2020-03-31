namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Net;
    using NUnit.Framework;

    [TestFixture]
    public class ExProjectOnlineException : ApiExampleBase
    {
        [Test]
        public void CreateProjectInProjectServer()
        {
            //ExStart:CreateProjectInProjectServer
            //ExFor: ProjectOnlineException
            //ExSummary: Shows how to catch exception while reading a project from MS Project Online.
            try
            {
                const string url = "https://contoso.sharepoint.com";
                const string domain = "CONTOSO.COM";
                const string userName = "Administrator";
                const string password = "MyPassword";

                var project = new Project(DataDir + @"TestProject1.mpp");

                var windowsCredentials = new NetworkCredential(userName, password, domain);
                var projectServerCredentials = new ProjectServerCredentials(url, windowsCredentials);
                var manager = new ProjectServerManager(projectServerCredentials);
                manager.CreateNewProject(project);
            }
            catch (ProjectOnlineException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //ExEnd:CreateProjectInProjectServer
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}