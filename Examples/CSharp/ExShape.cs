namespace Aspose.Tasks.Examples.CSharp
{
    using System.IO;
    using NUnit.Framework;
    using Words;
    using Words.Drawing;

    [TestFixture]
    public class ExShape : ApiExampleBase
    {
        [Test]
        public void RetrieveTaskEmbeddedDocuments()
        {
            //ExStart:RetrieveTaskEmbeddedDocuments
            //ExFor: Tsk.NotesRTF
            //ExFor: Shape
            //ExSummary: Shows how to extract embedded RTF and save OLE objects from it. 
            var project = new Project(DataDir + "TaskEmbeddedDocuments.mpp");
            var task = project.RootTask.Children.GetById(1);

            File.WriteAllText(OutDir + "TaskEmbeddedDocuments_out.rtf", task.Get(Tsk.NotesRTF));

            Document doc;
            using (var stream = new MemoryStream())
            {
                using (var writer = new StreamWriter(stream))
                {
                    writer.Write(task.Get(Tsk.NotesRTF));
                    doc = new Document(stream);
                }
            }

            var shapes = doc.GetChildNodes(NodeType.Shape, true);
            foreach (var node in shapes)
            {
                var shape = (Shape)node;
                if (shape.OleFormat == null 
                    || shape.OleFormat.IsLink
                    || shape.OleFormat.ProgId != "Word.Document.12")
                {
                    continue;
                }

                // Extract OLE Word object
                using (var stream = new MemoryStream())
                {
                    shape.OleFormat.Save(stream);

                    var newDocument = new Document(stream);
                    newDocument.Save(OutDir + "RetrieveTaskEmbeddedDocuments_out.doc");
                }
            }
            //ExEnd:RetrieveTaskEmbeddedDocuments
        }
    }
}