namespace Aspose.Tasks.Examples.CSharp
{
    using System.Collections.Generic;
    using System.IO;
    using NUnit.Framework;

    [TestFixture]
    public class ExOleObjectCollection : ApiExampleBase
    {
        [Test]
        public void WorkWithOleObjectCollection()
        {
            //ExStart:WorkWithOleObjectCollection
            //ExFor: OleObjectCollection
            //ExFor: OleObjectCollection.GetEnumerator
            //ExFor: OleObjectCollection.ToList
            //ExSummary: Shows how to work with collection of OLE objects.
            IDictionary<string, string> extensions = new Dictionary<string, string>();
            extensions.Add("RTF", "_rtfFile_out.rtf");
            extensions.Add("MSWordDoc", "_wordFile_out.docx");
            extensions.Add("ExcelML12", "_excelFile_out.xlsx");
            
            var project = new Project(DataDir + "Embedded.mpp");
            
            // by using index access
            // List<OleObject> list = project.OleObjects.ToList();
            // for (var index = 0; index < list.Count; index++)
            // {
            //     var oleObject = list[index];
            // }

            // or enumeration one can iterate over OLE objects
            foreach (var oleObject in project.OleObjects)
            {
                if (string.IsNullOrEmpty(oleObject.FileFormat))
                {
                    continue;
                }

                if (string.IsNullOrEmpty(oleObject.FileFormat) || !extensions.ContainsKey(oleObject.FileFormat))
                {
                    continue;
                }

                var path = OutDir + "EmbeddedContent_" + extensions[oleObject.FileFormat];
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    stream.Write(oleObject.Content, 0, oleObject.Content.Length);
                }
            }
            //ExEnd:WorkWithOleObjectCollection
        }
    }
}