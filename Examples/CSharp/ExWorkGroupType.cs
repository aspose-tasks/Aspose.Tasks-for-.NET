namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;

    [TestFixture]
    public class ExWorkGroupType : ApiExampleBase
    {
        [Test]
        public void WorkWithWorkGroupType()
        {
            {
                // ExStart
                // ExFor: WorkGroupType
                // ExFor: WorkGroupType.Web
                // ExSummary: Shows how to set work group of a resource.
                var project = new Project();

                // ...
                var resource = project.Resources.Add("Resource");
                resource.Set(Rsc.Workgroup, WorkGroupType.Web);

                // ...
                // ExEnd
            }

            {
                // ExStart
                // ExFor: WorkGroupType.None
                // ExSummary: Shows how to set work group 'None' of a resource.
                var project = new Project();

                // ...
                var resource = project.Resources.Add("Resource");
                resource.Set(Rsc.Workgroup, WorkGroupType.None);

                // ...
                // ExEnd
            }

            {
                // ExStart
                // ExFor: WorkGroupType.Email
                // ExSummary: Shows how to set work group 'Email' of a resource.
                var project = new Project();

                // ...
                var resource = project.Resources.Add("Resource");
                resource.Set(Rsc.Workgroup, WorkGroupType.Email);

                // ...
                // ExEnd
            }

            {
                // ExStart
                // ExFor: WorkGroupType.Default
                // ExSummary: Shows how to set work group 'Default' of a resource.
                var project = new Project();

                // ...
                var resource = project.Resources.Add("Resource");
                resource.Set(Rsc.Workgroup, WorkGroupType.Default);

                // ...
                // ExEnd
            }
        }
    }
}