namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;

    [TestFixture]
    public class ExResourceType : ApiExampleBase
    {
        [Test]
        public void WorkWithResourceType()
        {
            //ExStart:WorkWithResourceType
            //ExFor: ResourceType
            //ExFor: ResourceType.Cost
            //ExFor: ResourceType.Material
            //ExFor: ResourceType.Work
            //ExSummary: Shows how to work with resource types.
            var project = new Project();

            // add a work resource
            var work = project.Resources.Add("Work resource");
            work.Set(Rsc.Type, ResourceType.Work);
            
            // add a material resource
            var material = project.Resources.Add("Material resource");
            material.Set(Rsc.Type, ResourceType.Material);
            material.Set(Rsc.MaterialLabel, "kg");
            
            // add a material resource
            var cost = project.Resources.Add("Cost resource");
            material.Set(Rsc.Type, ResourceType.Cost);
            material.Set(Rsc.Cost, 59.99m);
            
            // work with resources: create tasks, assign resources and so on...
            //ExEnd:WorkWithResourceType
        }
    }
}