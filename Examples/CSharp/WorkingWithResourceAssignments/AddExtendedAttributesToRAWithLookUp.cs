namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    using Aspose.Tasks.Saving;

    internal class AddExtendedAttributesToRAWithLookUp
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            
            //ExStart: AddExtendedAttributesToRAWithLookUp
            // Create new project
            var project = new Project(dataDir + "Blank2010.mpp");

            // Assign resource "1 TRG: Trade Group" to the "TASK 1" by creating a ResourceAssignment object.
            var resource = project.Resources.GetById(1);
            var task = project.RootTask.Children.GetById(1);

            var assignment = project.ResourceAssignments.Add(task, resource);

            // Create custom attribute definition with lookup.
            var resCostAttr = ExtendedAttributeDefinition.CreateLookupResourceDefinition(
                CustomFieldType.Cost,
                ExtendedAttributeResource.Cost5,
                "My lookup resource cost");
            project.ExtendedAttributes.Add(resCostAttr);

            var value1 = new Value { NumericValue = 1500, Description = "Val 1", Id = 1, Val = "1500" };

            resCostAttr.AddLookupValue(value1);

            resCostAttr.AddLookupValue(new Value { NumericValue = 2500, Description = "Val 2", Id = 2 });

            // This value can be seen in "Resource usage" view of MS Project.
            var attributeValue = resCostAttr.CreateExtendedAttribute(value1);
            assignment.ExtendedAttributes.Add(attributeValue);

            // Create custom attribute definition with lookup.
            var taskCostAttr = ExtendedAttributeDefinition.CreateLookupTaskDefinition(
                ExtendedAttributeTask.Cost4,
                "My lookup task cost");

            project.ExtendedAttributes.Add(taskCostAttr);

            var taskLookupValue1 = new Value { NumericValue = 18, Description = "Task val 1", Id = 3, Val = "18" };
            taskCostAttr.AddLookupValue(taskLookupValue1);

            resCostAttr.AddLookupValue(new Value { NumericValue = 30, Description = "Task val 2", Id = 4 });

            // This value can be seen in "Task usage" view of MS Project.
            assignment.ExtendedAttributes.Add(taskCostAttr.CreateExtendedAttribute(taskLookupValue1));

            project.Save(dataDir + "AddExtendedAttributesToRAWithLookUp_out.mpp", SaveFileFormat.MPP);
            //ExEnd: AddExtendedAttributesToRAWithLookUp
        }
    }
}
