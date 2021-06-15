namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
        // ExFor: OleObject.Id
        // ExFor: OleObject.DisplayAsIcon
        // ExSummary: Shows how to read info about OLE objects.
        [Test]
        public void WorkWithOleObject()
        {
            var images = new Project(DataDir + "TaskImage2010.mpp");
            List<OleObject> oleObjects = images.OleObjects.ToList();

            Console.WriteLine("Ole Objects Count: " + oleObjects.Count);
            foreach (var oleObject in oleObjects)
            {
                Console.WriteLine(" Id: " + oleObject.Id);
                Console.WriteLine(" Name: " + oleObject.Name);
                Console.WriteLine(" DisplayAsIcon: " + oleObject.DisplayAsIcon);
                Console.WriteLine(" Application Name: " + oleObject.ApplicationName);
                Console.WriteLine(" File Format: " + oleObject.FileFormat);
                Console.WriteLine(" Label: " + oleObject.Label);
                Console.WriteLine(" Full Path: " + oleObject.FullPath);
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

        // ExStart ClearOleObjects
        // ExFor: OleObjectCollection.Clear
        // ExSummary: Shows how to remove OLE objects from the specified project.
        [Test]
        public void ClearOleObjects()
        {
            var project = new Project(DataDir + "TaskImage2010.mpp");
            project.OleObjects.Clear();
            project.Save(OutDir + "ClearedProject.mpp");
        }

        // ExEnd

        // ExStart GetVisualObjectPlacementProperties
        // ExFor: View.VisualObjectsPlacements
        // ExSummary: Shows how to get OLE object's placement and appearance properties.
        [Test]
        public void GetVisualObjectPlacementProperties()
        {
            var project = new Project(DataDir + "TaskImage2010.mpp");
            var oleObject = project.OleObjects.First();

            project.Save(OutDir + "ClearedProject.mpp");
            var view = project.Views.First(v => v.Name == "&Gantt Chart");
            var oleObjectPlacement = view.VisualObjectsPlacements.First(p => p.OleObjectId == oleObject.Id);

            Console.WriteLine("BorderLineColor: {0}", oleObjectPlacement.BorderLineColor);
            Console.WriteLine("BorderLineColor: {0}", oleObjectPlacement.BorderLineThickness);

            if (oleObjectPlacement.TaskId > 0)
            {
                Console.WriteLine("Attached to task: {0}", oleObjectPlacement.TaskId);
            }
            else
            {
                Console.WriteLine("Attached to timescale date: {0}", oleObjectPlacement.TimescaleDate);
            }
        }

        // ExEnd

    }
}