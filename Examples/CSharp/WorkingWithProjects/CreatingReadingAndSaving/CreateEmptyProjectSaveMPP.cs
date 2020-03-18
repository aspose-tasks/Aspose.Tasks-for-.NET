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
            // there is no more need to load MPP template to save it into MPP
            // add tasks, resources, etc.
            var project = new Project();

            // !The project will be saved into MPP by using internal MPP template.
            project.Save(dataDir + "project.mpp", SaveFileFormat.MPP);
            //ExEnd: CreateEmptyProjectSaveMPP
        }
    }
}
