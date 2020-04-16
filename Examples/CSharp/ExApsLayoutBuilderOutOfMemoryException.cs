namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExApsLayoutBuilderOutOfMemoryException : ApiExampleBase
    {
        [Test]
        public void SaveToStreamWithOptionsAndCatchException()
        {
            //ExStart
            //ExFor: ApsLayoutBuilderOutOfMemoryException
            //ExFor: ApsLayoutBuilderOutOfMemoryException.#ctor(SerializationInfo,StreamingContext)
            //ExSummary: Shows how to save project as an image and catch exceptions.
            try
            {
                var project = new Project(DataDir + "Blank2010.mpp");

                var options = new ImageSaveOptions(SaveFileFormat.PNG) { TimescaleTier = new TimescaleTier(TimescaleUnit.Minutes, 1) };
                project.Save(OutDir + "SaveToStreamWithOptionsAndCatchException_out.mpp", options);
            }
            catch (ApsLayoutBuilderOutOfMemoryException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (BitmapInvalidSizeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //ExEnd
        }
    }
}