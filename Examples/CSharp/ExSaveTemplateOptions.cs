namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExSaveTemplateOptions : ApiExampleBase
    {
        [Test]
        public void SaveProjectDataAsTemplate()
        {
            try
            {
                //ExStart:SaveProjectDataAsTemplate
                //ExFor: SaveTemplateOptions
                //ExFor: SaveTemplateOptions.RemoveActualValues
                //ExFor: SaveTemplateOptions.RemoveBaselineValues
                //ExSummary: Shows how to save project as a template by using options.
                var project = new Project(DataDir + "Project2.mpp");
                var projectFileInfo = Project.GetProjectFileInfo(DataDir + "Project2.mpp");

                if (FileFormat.MPP14 == projectFileInfo.ProjectFileFormat)
                {
                    Console.WriteLine("Project file format is ok");
                }

                var options = new SaveTemplateOptions();
                options.RemoveActualValues = true;
                options.RemoveBaselineValues = true;

                const string TemplateName = "SaveProjectDataAsTemplate_out.mpt";
                project.SaveAsTemplate(OutDir + TemplateName);

                var templateFileInfo = Project.GetProjectFileInfo(DataDir + TemplateName);
                if (FileFormat.MPT14 == templateFileInfo.ProjectFileFormat)
                {
                    Console.WriteLine("Template FileFormat is ok");
                }
                //ExEnd:SaveProjectDataAsTemplate
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}