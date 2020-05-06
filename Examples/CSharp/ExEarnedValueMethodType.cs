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
                // ExFor: EarnedValueMethodType.PercentComplete
                // ExSummary: Shows how to specify the method used for calculating earned value (EarnedValueMethodType.PercentComplete).
                var project = new Project(DataDir + "Project2.mpp");
                // set earned value method type to 'PercentComplete'
                project.Set(Prj.DefaultTaskEVMethod, EarnedValueMethodType.PercentComplete);
                // work with the project...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: EarnedValueMethodType.PhysicalPercentComplete
                // ExSummary: Shows how to specify the method used for calculating earned value (EarnedValueMethodType.PhysicalPercentComplete).
                var project = new Project(DataDir + "Project2.mpp");
                // set earned value method type to 'PhysicalPercentComplete'
                project.Set(Prj.DefaultTaskEVMethod, EarnedValueMethodType.PhysicalPercentComplete);
                // work with the project...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: EarnedValueMethodType.Undefined
                // ExSummary: Shows how to specify the method used for calculating earned value (EarnedValueMethodType.Undefined).
                var project = new Project(DataDir + "Project2.mpp");
                // set earned value method type to 'Undefined'
                project.Set(Prj.DefaultTaskEVMethod, EarnedValueMethodType.Undefined);
                // work with the project...
                // ExEnd
            }
        }
    }
}