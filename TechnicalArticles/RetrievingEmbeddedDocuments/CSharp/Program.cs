//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using Aspose.Words;
using Aspose.Words.Drawing;

namespace RetrievingEmbeddedDocumentsExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            ProjectReader reader = new ProjectReader();
            Project project = reader.Read(dataDir + "project.mpp");
            Task task = project.GetTaskById(1);
            File.WriteAllText(dataDir+ "Notes.rtf", task.NotesRTF);
            Document doc = null;
            using (MemoryStream stream = new MemoryStream())
            using (StreamWriter streamWriter = new StreamWriter(stream))
            {
                streamWriter.Write(task.NotesRTF);
                doc = new Document(stream);

            }
            NodeCollection shapes = doc.GetChildNodes(NodeType.Shape, true);
            foreach (Shape shape in shapes)
            {

                if (shape.OleFormat != null)
                {
                    if (!shape.OleFormat.IsLink)
                    {
                        //Extract OLE Word object
                        if (shape.OleFormat.ProgId == "Word.Document.12")
                        {
                            MemoryStream stream = new MemoryStream();
                            shape.OleFormat.Save(stream);

                            Document newDoc = new Document(stream);
                            newDoc.Save(dataDir+ "Embedded doc.doc");
                        }
                    }
                }


            }
        }
    }


}


            
