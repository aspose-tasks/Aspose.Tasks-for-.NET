namespace Aspose.Tasks.Examples.CSharp
{
    using System.IO;
    using NUnit.Framework;

    [TestFixture]
    public class ExCopyOptions : ApiExampleBase
    {
        [Test]
        public void ProjectCopyToTest()
        {
            //ExStart:ProjectCopyingWithOptions
            //ExFor: CopyToOptions
            //ExFor: CopyToOptions.#ctor
            //ExFor: CopyToOptions.CopyViewData
            //ExSummary: Shows how to use project copy options.
            var project = new Project(DataDir + "CopyToProjectEmpty.xml");
            File.Copy(DataDir + "CopyToProjectEmpty.mpp", OutDir + "ProjectCopying_out.mpp", true);

            var mppProject = new Project(OutDir + "ProjectCopying_out.mpp");

            // skip copying of view data while copying common project data.
            var copyToOptions = new CopyToOptions();
            copyToOptions.CopyViewData = false;
            project.CopyTo(mppProject, copyToOptions);
            //ExEnd:ProjectCopyingWithOptions
        }
    }
}