using Aspose.Tasks.Saving;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    class CreateEmptyProjectSaveMPP
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:CreateEmptyProjectSaveMPP
            // there is no more need to load MPP template to save it into MPP
            // add tasks, resources, etc.
            Project project = new Project();

            // !The project will be saved into MPP by using internal MPP template.
            project.Save(dataDir + "project.mpp", SaveFileFormat.MPP);
            //ExEnd: CreateEmptyProjectSaveMPP
        }
    }
}
