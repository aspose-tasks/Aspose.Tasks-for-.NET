namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using Aspose.Tasks.Saving;

    internal class CreateEmptyProjectSaveMPP
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:CreateEmptyProjectSaveMPP
            //ExFor: Project.Save(String, SaveFileFormat)
            //ExSummary: Shows how to create a project and save it into MPP format without passing of an MPP template file.
            var project = new Project();

            // The project will be saved into MPP by using internal MPP template.
            project.Save(dataDir + "project.mpp", SaveFileFormat.MPP);
            //ExEnd: CreateEmptyProjectSaveMPP
        }
    }
}
