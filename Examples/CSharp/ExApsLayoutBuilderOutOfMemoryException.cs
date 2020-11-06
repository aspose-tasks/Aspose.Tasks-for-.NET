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
        public void WorkWithApsLayoutBuilderOutOfMemoryException()
        {
            // ExStart
            // ExFor: ApsLayoutBuilderOutOfMemoryException
            // ExFor: ApsLayoutBuilderOutOfMemoryException.#ctor(SerializationInfo,StreamingContext)
            // ExSummary: Shows how to save project as an image and catch exceptions.
            try
            {
                var project = new Project(DataDir + "Blank2010.mpp");

                var ganttChart = (GanttChartView)project.Views.ToList()[0];

                ganttChart.MiddleTimescaleTier.Unit = TimescaleUnit.Hours;
                ganttChart.BottomTimescaleTier.Unit = TimescaleUnit.Minutes;
                ganttChart.BottomTimescaleTier.Count = 1;
                
                var options = new ImageSaveOptions(SaveFileFormat.PNG);
                options.Timescale = Timescale.DefinedInView;
                
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

            // ExEnd
        }
    }
}