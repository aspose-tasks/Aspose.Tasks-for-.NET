namespace Aspose.Tasks.Examples.CSharp.SavingOptions
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
                // ExStart:SaveProjectDataAsTemplate
                // ExFor: SaveTemplateOptions
                // ExFor: SaveTemplateOptions.RemoveActualValues
                // ExFor: SaveTemplateOptions.RemoveBaselineValues
                // ExFor: SaveTemplateOptions.RemoveFixedCosts
                // ExFor: SaveTemplateOptions.RemoveResourceRates
                // ExSummary: Shows how to save project as a template by using options.
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");
                var projectFileInfo = Project.GetProjectFileInfo(DataDir + "EstimatedMilestoneTasks.mpp");

                Console.WriteLine("Project File Format: " + projectFileInfo.ProjectFileFormat);

                // create template save options
                // and tune its properties
                var options = new SaveTemplateOptions
                {
                    // set a value indicating whether all fixed costs from a project template should be removed
                    RemoveFixedCosts = true,

                    // set a value indicating whether all actual values from a project template should be removed
                    RemoveActualValues = true,

                    // set a value indicating whether resource rates from a project template should be removed
                    RemoveResourceRates = true,

                    // set a value indicating whether all baseline values from a project template should be removed
                    RemoveBaselineValues = true
                };

                project.SaveAsTemplate(OutDir + "SaveProjectDataAsTemplate_out.mpt", options);

                var templateFileInfo = Project.GetProjectFileInfo(DataDir + "SaveProjectDataAsTemplate_out.mpt");
                Console.WriteLine("Project File Format: " + templateFileInfo.ProjectFileFormat);

                // ExEnd:SaveProjectDataAsTemplate
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}