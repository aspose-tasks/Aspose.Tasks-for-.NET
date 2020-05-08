namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;

    [TestFixture]
    public class ExEarnedValueMethodType : ApiExampleBase
    {
        [Test]
        public void WorkWithEarnedValueMethodType()
        {
            {
                // ExStart
                // ExFor: EarnedValueMethodType
                // ExSummary: Shows how to specify the method used for calculating earned value (EarnedValueMethodType.PercentComplete).
                var project = new Project(DataDir + "Project2.mpp");
                // set earned value method type to 'PercentComplete'
                project.Set(Prj.DefaultTaskEVMethod, EarnedValueMethodType.PercentComplete);
                // work with the project...
                // ExEnd
            }
        }
    }
}