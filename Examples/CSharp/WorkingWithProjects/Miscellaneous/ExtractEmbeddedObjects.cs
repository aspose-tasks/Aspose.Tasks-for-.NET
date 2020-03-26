namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Miscellaneous
{
    using System.IO;

    internal class ExtractEmbeddedObjects
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:ExtractEmbeddedObjects
            //ExFor: OleObject.Content
            //ExFor: Project.OleObjects
            //ExSummary: Shows how to extract an embedded OLE object.
            var project = new Project(dataDir + "ExtractEmbeddedObjects.mpp");

            foreach (var ole in project.OleObjects.ToList())
            {
                // We have to check this property because it can be null if the embedded object was created inside the ms project application Or, alternatively, you can use this check: if (ole.FileFormat == "Package")
                if (string.IsNullOrEmpty(ole.FullPath) || ole.Content == null)
                {
                    continue;
                }

                using (var stream = new FileStream(dataDir + Path.GetFileName(ole.FullPath), FileMode.Create))
                {
                    stream.Write(ole.Content, 0, ole.Content.Length);
                }
            }
            //ExEnd:ExtractEmbeddedObjects
        }
    }
}