namespace Aspose.Tasks.Examples.CSharp.SavingOptions
{
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExPrimaveraSaveOptions : ApiExampleBase
    {
        [Test]
        public void WorkWithPrimaveraSaveOptions()
        {
            // ExStart:PrimaveraSaveOptions
            // ExFor: PrimaveraSaveOptions
            // ExFor: PrimaveraSaveOptions.#ctor
            // ExFor: PrimaveraSaveOptions.ActivityIdIncrement
            // ExFor: PrimaveraSaveOptions.ActivityIdPrefix
            // ExFor: PrimaveraSaveOptions.ActivityIdSuffix
            // ExFor: PrimaveraSaveOptions.RenumberActivityIds
            // ExSummary: Shows how to work with <see cref="Aspose.Tasks.Saving.PrimaveraSaveOptions" />.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

            // create Primavera save options and tune them
            var options = new PrimaveraSaveOptions
                              {
                                  // define prefix and suffix of an activity
                                  ActivityIdPrefix = "TEST",
                                  ActivityIdSuffix = 10000,

                                  // control renumbering of activities
                                  ActivityIdIncrement = 5,
                                  RenumberActivityIds = true
                              };

            project.Save(OutDir + "WorkWithPrimaveraSaveOptions_out.xer", options);

            // ExEnd:PrimaveraSaveOptions
        }
    }
}