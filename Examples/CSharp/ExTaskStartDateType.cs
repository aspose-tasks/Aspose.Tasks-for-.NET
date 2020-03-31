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
            //ExStart:SetAttributesForNewTasks
            //ExFor: TaskStartDateType
            //ExSummary: Shows how to set task's default start date.
            var project = new Project();
            project.Set(Prj.NewTaskStartDate, TaskStartDateType.CurrentDate);
            project.Save(OutDir + "SetAttributesForNewTasks_out.xml", SaveFileFormat.XML);
            //ExEnd:SetAttributesForNewTasks
        }
    }
}