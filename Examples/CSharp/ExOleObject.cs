namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using NUnit.Framework;

    [TestFixture]
    public class ExOleObject : ApiExampleBase
    {
        // ExStart
        // ExFor: OleObject
        // ExFor: OleObject.Name
        // ExFor: OleObject.ApplicationName
        // ExFor: OleObject.FileFormat
        // ExFor: OleObject.Label
        // ExFor: OleObject.FullPath
        // ExFor: OleObject.TemporaryFile
        // ExFor: OleObject.Linked
        // ExFor: OleObject.View
        // ExFor: OleObject.Content
        // ExSummary: Shows how to read info about OLE objects.
        [Test] // ExSkip
        public void WorkWithOleObject()
        {
            var images = new Project(DataDir + "TaskImage2010.mpp");
            List<OleObject> oleObjects = images.OleObjects.ToList();

            Console.WriteLine("Ole Objects Count: " + oleObjects.Count);
            foreach (var oleObject in oleObjects)
            {
                Console.WriteLine(" Name: " + oleObject.Name);
                Console.WriteLine(" Application Name: " + oleObject.ApplicationName);
                Console.WriteLine(" File Format: " + oleObject.FileFormat);
                Console.WriteLine(" Label: " + oleObject.Label);
                Console.WriteLine(" Full Path: " + oleObject.FullPath);
                Console.WriteLine(" Temporary File: " + oleObject.TemporaryFile);
                Console.WriteLine(" Is Linked: " + oleObject.Linked);
                Console.WriteLine(" View Name: " + oleObject.View.Name);
                Console.WriteLine(" Content (first 10 bytes): " + this.Get10Bytes(oleObject));
            }
        }

        private string Get10Bytes(OleObject oleObject)
        {
            byte[] bytes = oleObject.Content;
            var chunk = new byte[10];
            Array.Copy(bytes, chunk, 10);
            var builder = new StringBuilder();
            foreach (var b in chunk)
            {
                builder.Append(b + ", ");
            }

            builder.Remove(builder.Length - 3, 1);
            return builder.ToString();
        }

        // ExEnd
    }
}