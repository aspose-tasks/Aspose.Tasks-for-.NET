namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    using System.IO;
    using System.Reflection;

    internal class ProjectCopying
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(MethodBase.GetCurrentMethod());

            {
                //ExStart:ProjectCopying
                //ExFor: Project.CopyTo(Project)
                //ExSummary: Shows how to copy the project data to another project.
                var project = new Project(dataDir + "CopyToProjectEmpty.xml");
                File.Copy(dataDir + "CopyToProjectEmpty.mpp", dataDir + "ProjectCopying_out.mpp", true);

                var mppProject = new Project(dataDir + "ProjectCopying_out.mpp");

                // skip copying of view data while copying common project data.
                project.CopyTo(mppProject);
                //ExEnd:ProjectCopying
            }

            {
                //ExStart:ProjectCopyingWithOptions
                //ExFor: CopyToOptions
                //ExFor: CopyToOptions.#ctor
                //ExFor: CopyToOptions.CopyViewData
                //ExFor: Project.CopyTo(Project,CopyToOptions)
                //ExSummary: Shows how to copy the project with usage of <see cref="Aspose.Tasks.CopyToOptions"/> instance.
                var project = new Project(dataDir + "CopyToProjectEmpty.xml");
                File.Copy(dataDir + "CopyToProjectEmpty.mpp", dataDir + "ProjectCopying_out.mpp", true);

                var mppProject = new Project(dataDir + "ProjectCopying_out.mpp");

                // skip copying of view data while copying common project data.
                var copyToOptions = new CopyToOptions();
                copyToOptions.CopyViewData = false;
                project.CopyTo(mppProject, copyToOptions);
                //ExEnd:ProjectCopyingWithOptions
            }
        }
    }
}