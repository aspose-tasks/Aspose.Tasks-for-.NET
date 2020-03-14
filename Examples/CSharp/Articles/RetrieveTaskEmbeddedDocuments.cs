using Aspose.Words;
using System.IO;

namespace Aspose.Tasks.Examples.CSharp.Articles
{
    using Aspose.Words.Drawing;

    class RetrieveTaskEmbeddedDocuments
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:RetrieveTaskEmbeddedDocuments
            Project project = new Project(dataDir + "TaskEmbeddedDocuments.mpp");
            Task task = project.RootTask.Children.GetById(1);

            File.WriteAllText(dataDir + "Notes_out.rtf", task.Get(Tsk.NotesRTF));

            Document doc;
            using (MemoryStream stream = new MemoryStream())
            using (StreamWriter streamWriter = new StreamWriter(stream))
            {
                streamWriter.Write(task.Get(Tsk.NotesRTF));
                doc = new Document(stream);
            }

            NodeCollection shapes = doc.GetChildNodes(NodeType.Shape, true);
            foreach (var node in shapes)
            {
                var shape = (Shape)node;
                if (shape.OleFormat != null)
                {
                    if (!shape.OleFormat.IsLink)
                    {
                        // Extract OLE Word object
                        if (shape.OleFormat.ProgId == "Word.Document.12")
                        {
                            MemoryStream stream = new MemoryStream();
                            shape.OleFormat.Save(stream);

                            Document newDoc = new Document(stream);
                            newDoc.Save(dataDir + "RetrieveTaskEmbeddedDocuments_out.doc");
                        }
                    }
                }
            }
            //ExEnd:RetrieveTaskEmbeddedDocuments
        }
    }
}
