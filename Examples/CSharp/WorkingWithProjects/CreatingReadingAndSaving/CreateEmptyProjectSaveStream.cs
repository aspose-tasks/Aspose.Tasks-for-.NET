namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using System.IO;
    using Saving;

    internal class CreateEmptyProjectSaveStream
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            {
                //ExStart:CreateEmptyProjectToSaveToStream
                //ExFor: Project.Save(Stream, SaveFileFormat);
                //ExSummary: Shows how to save project into a stream as an XML MS Project file.
                var project = new Project();

                // Create a file stream
                using (var stream = new FileStream(dataDir + "EmptyProjectSaveStream_out.xml", FileMode.Create, FileAccess.Write))
                {
                    // Write the stream into XML format
                    project.Save(stream, SaveFileFormat.XML);
                }
                //ExEnd: CreateEmptyProjectToSaveToStream
            }
            
            {
                //ExStart:CreateEmptyProjectToSaveToStreamWithMPPSaveOptions
                //ExFor: MPPSaveOptions
                //ExFor: Project.Save(Stream, MPPSaveOptions)
                //ExSummary: Shows how to save project into a stream as an MPP file.
                var project = new Project();

                // Create a file stream
                using (var stream = new FileStream(dataDir + "EmptyProjectSaveStream_out.xml", FileMode.Create, FileAccess.Write))
                {
                    var options = new MPPSaveOptions();
                    
                    // by using of MPPSaveOptions we save it in MPP format
                    project.Save(stream, options);
                }
                //ExEnd: CreateEmptyProjectToSaveToStreamWithMPPSaveOptions
            }
            
            {
                //ExStart:CreateEmptyProjectToSaveToStreamWithMPPSaveOptions
                //ExFor: Project.Save(String, MPPSaveOptions)
                //ExSummary: Shows how to save project as an MPP file.
                var project = new Project();

                var options = new MPPSaveOptions();

                // by using of MPPSaveOptions we save it in MPP format
                project.Save(dataDir + "EmptyProjectSaveStream_out.xml", options);
                //ExEnd: CreateEmptyProjectToSaveToStreamWithMPPSaveOptions
            }
            
            {
                //ExStart:CreateEmptyProjectToSaveToStreamWithImageOptions
                //ExFor: ImageSaveOptions
                //ExFor: ImageSaveOptions.#ctor(SaveFileFormat)
                //ExFor: Project.Save(Stream, SaveOptions)
                //ExSummary: Shows how to save project into a stream as an image.
                var project = new Project();

                // Create a file stream
                using (var stream = new FileStream(dataDir + "EmptyProjectSaveStream_out.xml", FileMode.Create, FileAccess.Write))
                {
                    var options = new ImageSaveOptions(SaveFileFormat.PNG);
                    
                    // by using of ImageSaveOptions we save the project into image format
                    project.Save(stream, options);
                }
                //ExEnd: CreateEmptyProjectToSaveToStreamWithImageOptions
            }
        }
    }
}
