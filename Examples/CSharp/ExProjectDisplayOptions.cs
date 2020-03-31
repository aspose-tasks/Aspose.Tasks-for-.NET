namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;

    [TestFixture]
    public class ExProjectDisplayOptions : ApiExampleBase
    {
        [Test]
        public void ProjectDisplayOptionsUsage()
        {
            //ExStart:ProjectDisplayOptionsUsage
            //ExFor: ProjectDisplayOptions
            //ExFor: ProjectDisplayOptions.#ctor
            //ExFor: ProjectDisplayOptions.ShowTaskScheduleWarnings
            //ExSummary: Shows how to use project's display options.
            var project = new Project(DataDir + "Blank2010.mpp");
            
            // Set a value indicating whether to show warnings when Project identifies a possible scheduling conflict with a manually scheduled task.
            // This option is available for Project 2010 version and later.
            project.DisplayOptions.ShowTaskScheduleWarnings = false;
            //ExEnd:ProjectDisplayOptionsUsage
        }
    }
}