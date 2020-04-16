namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExOutlineMaskCollection : ApiExampleBase
    {
        [Test]
        public void WorkWithOutlineMaskCollection()
        {
            //ExStart
            //ExFor: OutlineMaskCollection
            //ExFor: OutlineMaskCollection.Add(OutlineMask)
            //ExFor: OutlineMaskCollection.Clear
            //ExFor: OutlineMaskCollection.Contains(OutlineMask)
            //ExFor: OutlineMaskCollection.CopyTo(OutlineMask[],Int32)
            //ExFor: OutlineMaskCollection.Count
            //ExFor: OutlineMaskCollection.GetEnumerator
            //ExFor: OutlineMaskCollection.IndexOf(OutlineMask)
            //ExFor: OutlineMaskCollection.Insert(Int32,OutlineMask)
            //ExFor: OutlineMaskCollection.IsReadOnly
            //ExFor: OutlineMaskCollection.Item(Int32)
            //ExFor: OutlineMaskCollection.Remove(OutlineMask)
            //ExFor: OutlineMaskCollection.RemoveAt(Int32)
            //ExSummary: Shows how to work with outline mask collections.
            var project = new Project(DataDir + "OutlineValues2010.mpp");
            
            var outline = project.OutlineCodes[0];

            // clear outline masks
            if (outline.Masks.Count > 0)
            {
                if (!outline.Masks.IsReadOnly)
                {
                    outline.Masks.Clear();
                }
            }
            
            var mask = new OutlineMask();
            mask.Type = MaskType.Characters;
            var maskWrong = new OutlineMask();
            maskWrong.Type = MaskType.Null;
            
            outline.Masks.Add(mask);
            
            // insert a wrong mask 
            outline.Masks.Insert(0, maskWrong);
            
            // edit the mask by using index access of collection
            var idx = outline.Masks.IndexOf(mask);
            outline.Masks[idx].Length = 2;
            
            // remove a wrong mask by index
            var idxOfWrong = outline.Masks.IndexOf(maskWrong);
            outline.Masks.RemoveAt(idxOfWrong);
            
            // iterate over masks
            foreach (var outlineMask in outline.Masks)
            {
                Console.WriteLine("Length: " + outlineMask.Length);
                Console.WriteLine("Level: " + outlineMask.Level);
                Console.WriteLine("Separator: " + outlineMask.Separator);
                Console.WriteLine("Type: " + outlineMask.Type);
            }
            
            var otherProject = new Project(DataDir + "OutlineValues2010.mpp");
            
            var otherOutline = otherProject.OutlineCodes[0];

            var masks = new OutlineMask[outline.Masks.Count];
            outline.Masks.CopyTo(masks, 0);

            foreach (var maskToAdd in masks)
            {
                if (!otherOutline.Masks.Contains(maskToAdd))
                {
                    otherOutline.Masks.Add(maskToAdd);
                }
            }
            //ExEnd
        }
    }
}