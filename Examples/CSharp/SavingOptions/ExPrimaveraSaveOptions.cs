namespace Aspose.Tasks.Examples.CSharp.SavingOptions
{
    using System;
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
        
        [Test]
        public void WorkWithPrimaveraActivityId()
        {
            // ExStart:PrimaveraActivityId
            // ExFor: Tsk.ActivityId
            // ExSummary: Shows how to work with ActivityId field specific to Primavera projects
            var project = new Project(DataDir + "test.xer");

            var task = project.RootTask.Children.GetById(1);
            
            Console.WriteLine("Task activity_id: {0}", task.Get(Tsk.ActivityId));
            
            task.Set(Tsk.ActivityId, "CUSTOM_ACTIVITY_ID");

            // create Primavera save options and specify that ActivityIds should not be overwritten during saving.
            var options = new PrimaveraSaveOptions
            {
                RenumberActivityIds = false
            };

            project.Save(OutDir + "WorkWithPrimaveraActivityId_out.xer", options);

            // ExEnd:PrimaveraActivityId
        }
    }
}