namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExTaskStartDateType : ApiExampleBase
    {
        [Test]
        public void SetAttributesForNewTasks()
        {
            {
                // ExStart:SetAttributesForNewTasks
                // ExFor: TaskStartDateType
                // ExFor: TaskStartDateType.CurrentDate
                // ExSummary: Shows how to set task's default start date as 'CurrentDate'.
                var project = new Project();
                project.Set(Prj.NewTaskStartDate, TaskStartDateType.CurrentDate);
                project.Save(OutDir + "SetAttributesForNewTasks_out.xml", SaveFileFormat.XML);

                // ExEnd:SetAttributesForNewTasks
            }

            {
                // ExStart
                // ExFor: TaskStartDateType.ProjectStartDate
                // ExSummary: Shows how to set task's default start date as 'ProjectStartDate'.
                var project = new Project();
                project.Set(Prj.NewTaskStartDate, TaskStartDateType.ProjectStartDate);
                project.Save(OutDir + "SetAttributesForNewTasks_out.xml", SaveFileFormat.XML);

                // ExEnd
            }

            {
                // ExStart
                // ExFor: TaskStartDateType.Undefined
                // ExSummary: Shows how to set task's default start date as 'Undefined'.
                var project = new Project();
                project.Set(Prj.NewTaskStartDate, TaskStartDateType.Undefined);
                project.Save(OutDir + "SetAttributesForNewTasks_out.xml", SaveFileFormat.XML);

                // ExEnd
            }
        }
    }
}