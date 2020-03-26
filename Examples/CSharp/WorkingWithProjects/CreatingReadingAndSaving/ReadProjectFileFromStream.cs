namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using System;
    using System.IO;

    using Aspose.Tasks.Saving;

    internal class ReadProjectFileFromStream
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            try
            {
                //ExStart:ReadProjectFileFromStream
                //ExFor: Project.#ctor(Stream)
                //ExSummary: Shows how to read XML project file from a stream.
                // Read project xml into file stream
                using (Stream stream = new FileStream(dataDir + "Project.xml", FileMode.Open))
                {
                    // Create project using file stream
                    var project = new Project(stream);
                    project.Save(dataDir + "ReadProjectFileFromStream_out.xml", SaveFileFormat.XML);
                }
                //ExEnd:ReadProjectFileFromStream
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}