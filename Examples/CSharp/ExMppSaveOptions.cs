namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.IO;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExMppSaveOptions : ApiExampleBase
    {
        [Test]
        public void CreateEmptyProjectToSaveToStreamFormat()
        {
            //ExStart:CreateEmptyProjectToSaveToStream
            //ExFor: Project.Save(Stream, SaveFileFormat);
            //ExSummary: Shows how to save project into a stream as an XML MS Project file.
            var project = new Project();

            using (var stream = new FileStream(DataDir + "EmptyProjectSaveStream_out.xml", FileMode.Create, FileAccess.Write))
            {
                // Write the stream into XML format
                project.Save(stream, SaveFileFormat.XML);
            }
            //ExEnd:CreateEmptyProjectToSaveToStream
        }

        [Test]
        public void CreateEmptyProjectToSaveToStreamOptions()
        {
            try
            {
                //ExStart:CreateEmptyProjectToSaveToStreamWithMPPSaveOptions
                //ExFor: MPPSaveOptions
                //ExSummary: Shows how to save project into a stream as an MPP file.
                using (var stream = new FileStream(DataDir + "EmptyProjectSaveStream_out.xml", FileMode.Create, FileAccess.Write))
                {
                    var project = new Project();
                    var options = new MPPSaveOptions();
                    // save in MPP format by using of save options 
                    project.Save(stream, options);
                }
                //ExEnd:CreateEmptyProjectToSaveToStreamWithMPPSaveOptions
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}