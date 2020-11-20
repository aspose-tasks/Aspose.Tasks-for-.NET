namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExBitmapInvalidSizeException : ApiExampleBase
    {
        [Test]
        public void SaveToStreamWithOptionsAndCatchException()
        {
            // ExStart
            // ExFor: BitmapInvalidSizeException
            // ExFor: BitmapInvalidSizeException.#ctor(SerializationInfo,StreamingContext)
            // ExSummary: Shows how to save project as an image and catch invalid size exception.
            try
            {
                var project = new Project(DataDir + "Blank2010.mpp");

                GanttChartView view = (GanttChartView) project.Views.ToList()[0];
                var options = new ImageSaveOptions(SaveFileFormat.PNG)
                {
                    Timescale = Timescale.DefinedInView
                };

                view.MiddleTimescaleTier.Unit = TimescaleUnit.Minutes;
                view.MiddleTimescaleTier.Count = 1;
                
                project.Save(OutDir + "SaveToStreamAndCatchException_out.mpp", options);
            }
            catch (BitmapInvalidSizeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // ExEnd
        }
    }
}