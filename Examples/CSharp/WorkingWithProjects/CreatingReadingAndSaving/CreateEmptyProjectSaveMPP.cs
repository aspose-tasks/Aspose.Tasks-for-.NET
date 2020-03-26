namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using System;
    using Aspose.Tasks.Saving;

    internal class CreateEmptyProjectSaveMPP
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            try
            {
                //ExStart:CreateEmptyProjectSaveMPP
                //ExFor: Project.#ctor
                //ExFor: Project.Save(String, SaveFileFormat)
                //ExSummary: Shows how to create a project and save it into MPP format without passing of an MPP template file.
                var project = new Project();

                // The project will be saved into MPP by using internal MPP template.
                project.Save(dataDir + "CreateEmptyProjectSaveMPP_out.mpp", SaveFileFormat.MPP);
                //ExEnd: CreateEmptyProjectSaveMPP
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
