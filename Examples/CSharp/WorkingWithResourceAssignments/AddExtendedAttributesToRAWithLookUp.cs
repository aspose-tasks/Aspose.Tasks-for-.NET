namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    using System;
    using Aspose.Tasks.Saving;

    internal class AddExtendedAttributesToRAWithLookUp
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            try
            {
                //ExStart: AddExtendedAttributesToRAWithLookUp
                //ExFor: ExtendedAttributeDefinition.CreateLookupResourceDefinition(CustomFieldType, ExtendedAttributeResource, String)
                //ExFor: ExtendedAttributeDefinition.CreateLookupTaskDefinition(ExtendedAttributeTask, String)
                //ExFor: ExtendedAttributeDefinition.AddLookupValue(Value)
                //ExSummary: Shows how to add extended attributes with lookups for assignments.
                var project = new Project(dataDir + "Blank2010.mpp");

                // Assign resource "1 TRG: Trade Group" to the "TASK 1" by creating a ResourceAssignment object.
                var resource = project.Resources.GetById(1);
                var task = project.RootTask.Children.GetById(1);
                var assignment = project.ResourceAssignments.Add(task, resource);

                // Create custom attribute definition with lookup.
                var resExtendedAttributeDefinition = ExtendedAttributeDefinition.CreateLookupResourceDefinition(
                    CustomFieldType.Cost,
                    ExtendedAttributeResource.Cost5,
                    "My lookup resource cost");
                project.ExtendedAttributes.Add(resExtendedAttributeDefinition);

                var firstValue = new Value { NumericValue = 1500, Description = "Val 1", Id = 1, Val = "1500" };
                var secondValue = new Value { NumericValue = 2500, Description = "Val 2", Id = 2 };
                resExtendedAttributeDefinition.AddLookupValue(firstValue);
                resExtendedAttributeDefinition.AddLookupValue(secondValue);

                // This value can be seen in "Resource usage" view of MS Project.
                var attributeValue = resExtendedAttributeDefinition.CreateExtendedAttribute(firstValue);
                assignment.ExtendedAttributes.Add(attributeValue);

                // Create custom attribute definition with lookup.
                var taskCostAttr = ExtendedAttributeDefinition.CreateLookupTaskDefinition(
                    ExtendedAttributeTask.Cost4,
                    "My lookup task cost");
                project.ExtendedAttributes.Add(taskCostAttr);
                var taskFirstValue = new Value { NumericValue = 18, Description = "Task val 1", Id = 3, Val = "18" };
                var resSecondValue = new Value { NumericValue = 30, Description = "Task val 2", Id = 4 };
                
                taskCostAttr.AddLookupValue(taskFirstValue);
                resExtendedAttributeDefinition.AddLookupValue(resSecondValue);

                // This value can be seen in "Task usage" view of MS Project.
                assignment.ExtendedAttributes.Add(taskCostAttr.CreateExtendedAttribute(taskFirstValue));

                project.Save(dataDir + "AddExtendedAttributesToRAWithLookUp_out.mpp", SaveFileFormat.MPP);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
            //ExEnd: AddExtendedAttributesToRAWithLookUp
        }
    }
}
