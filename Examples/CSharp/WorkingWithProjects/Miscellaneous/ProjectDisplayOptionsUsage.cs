namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Miscellaneous
{
    public class ProjectDisplayOptionsUsage
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:ProjectDisplayOptionsUsage
            //ExFor: ProjectDisplayOptions
            //ExFor: ProjectDisplayOptions.#ctor
            //ExFor: ProjectDisplayOptions.ShowTaskScheduleWarnings
            //ExFor: Project.DisplayOptions
            //ExSummary: Shows how to tune project's display options.
            var project = new Project(dataDir + "Blank2010.mpp");
            
            // Set a value indicating whether to show warnings when Project identifies a possible scheduling conflict with a manually scheduled task.
            // This option is available for Project 2010 version and later.
            project.DisplayOptions.ShowTaskScheduleWarnings = false;
            //ExEnd:ProjectDisplayOptionsUsage
        }
    }
}