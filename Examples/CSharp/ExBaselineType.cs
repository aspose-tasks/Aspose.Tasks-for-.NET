namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExBaselineType : ApiExampleBase
    {
        [Test]
        public void WorkWithBaselineType()
        {
            {
                // ExStart
                // ExFor: BaselineType
                // ExFor: BaselineType.Baseline
                // ExSummary: Shows how to set baseline for the project (BaselineType.Baseline).
                var project = new Project(DataDir + "Project2.mpp");
                // save baseline fields to the specified baseline for the entire project.
                project.SetBaseline(BaselineType.Baseline);
                // work with project's baselines...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: BaselineType.Baseline1
                // ExSummary: Shows how to set baseline for the project (BaselineType.Baseline1).
                var project = new Project(DataDir + "Project2.mpp");
                // save baseline fields to the specified baseline for the entire project.
                project.SetBaseline(BaselineType.Baseline1);
                // work with project's baselines...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: BaselineType.Baseline2
                // ExSummary: Shows how to set baseline for the project (BaselineType.Baseline2).
                var project = new Project(DataDir + "Project2.mpp");
                // save baseline fields to the specified baseline for the entire project.
                project.SetBaseline(BaselineType.Baseline2);
                // work with project's baselines...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: BaselineType.Baseline3
                // ExSummary: Shows how to set baseline for the project (BaselineType.Baseline3).
                var project = new Project(DataDir + "Project2.mpp");
                // save baseline fields to the specified baseline for the entire project.
                project.SetBaseline(BaselineType.Baseline3);
                // work with project's baselines...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: BaselineType.Baseline4
                // ExSummary: Shows how to set baseline for the project (BaselineType.Baseline4).
                var project = new Project(DataDir + "Project2.mpp");
                // save baseline fields to the specified baseline for the entire project.
                project.SetBaseline(BaselineType.Baseline4);
                // work with project's baselines...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: BaselineType.Baseline5
                // ExSummary: Shows how to set baseline for the project (BaselineType.Baseline5).
                var project = new Project(DataDir + "Project2.mpp");
                // save baseline fields to the specified baseline for the entire project.
                project.SetBaseline(BaselineType.Baseline5);
                // work with project's baselines...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: BaselineType.Baseline6
                // ExSummary: Shows how to set baseline for the project (BaselineType.Baseline6).
                var project = new Project(DataDir + "Project2.mpp");
                // save baseline fields to the specified baseline for the entire project.
                project.SetBaseline(BaselineType.Baseline6);
                // work with project's baselines...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: BaselineType.Baseline7
                // ExSummary: Shows how to set baseline for the project (BaselineType.Baseline7).
                var project = new Project(DataDir + "Project2.mpp");
                // save baseline fields to the specified baseline for the entire project.
                project.SetBaseline(BaselineType.Baseline7);
                // work with project's baselines...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: BaselineType.Baseline8
                // ExSummary: Shows how to set baseline for the project (BaselineType.Baseline8).
                var project = new Project(DataDir + "Project2.mpp");
                // save baseline fields to the specified baseline for the entire project.
                project.SetBaseline(BaselineType.Baseline8);
                // work with project's baselines...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: BaselineType.Baseline9
                // ExSummary: Shows how to set baseline for the project (BaselineType.Baseline9).
                var project = new Project(DataDir + "Project2.mpp");
                // save baseline fields to the specified baseline for the entire project.
                project.SetBaseline(BaselineType.Baseline9);
                // work with project's baselines...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: BaselineType.Baseline10
                // ExSummary: Shows how to set baseline for the project (BaselineType.Baseline10).
                var project = new Project(DataDir + "Project2.mpp");
                // save baseline fields to the specified baseline for the entire project.
                project.SetBaseline(BaselineType.Baseline10);
                // work with project's baselines...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: BaselineType.Undefined
                // ExSummary: Shows that BaselineType.Undefined cannot be used as a correct baseline type.
                var project = new Project(DataDir + "Project2.mpp");
                
                // try to set undefined baseline
                try
                {
                    project.SetBaseline(BaselineType.Undefined);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    // work with exception...
                }
                // ExEnd
            }
        }
    }
}