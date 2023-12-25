namespace Aspose.Tasks.Examples.CSharp.SavingOptions
{
    using System;
    using System.IO;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExMppSaveOptions : ApiExampleBase
    {
        [Test]
        public void CreateEmptyProjectToSaveToStreamOptions()
        {
            try
            {
                // ExStart:CreateEmptyProjectToSaveToStreamWithMPPSaveOptions
                // ExFor: MPPSaveOptions
                // ExFor: MPPSaveOptions.RemoveInvalidAssignments
                // ExFor: MPPSaveOptions.WriteViewData
                // ExSummary: Shows how to save project into a stream as an MPP file.
                using (var stream = new FileStream(OutDir + "EmptyProjectSaveStream_out.xml", FileMode.Create, FileAccess.Write))
                {
                    var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                    // create save options
                    SimpleSaveOptions options = new MPPSaveOptions
                    {
                        // sets a value indicating whether to remove invalid resource assignments when saving to MPP
                        RemoveInvalidAssignments = true
                    };

                    // save MPP with options
                    project.Save(stream, options);
                }

                // ExEnd:CreateEmptyProjectToSaveToStreamWithMPPSaveOptions
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}