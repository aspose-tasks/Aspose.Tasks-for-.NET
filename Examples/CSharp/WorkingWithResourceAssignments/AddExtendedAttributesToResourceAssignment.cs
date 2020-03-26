namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    using System;
    using Aspose.Tasks.Saving;

    internal class AddExtendedAttributesToResourceAssignment
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            try
            {
                //ExStart: AddExtendedAttributesToResourceAssignment
                //ExFor: ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType,ExtendedAttributeTask,String)
                //ExSummary: Shows how to add extended attribute to a resource assignment.
                // Create new project
                var project = new Project(dataDir + "Blank2010.mpp");

                // Add new task and resource
                var task = project.RootTask.Children.Add("Task");
                var resource = project.Resources.Add("Rsc");
                var assignment = project.ResourceAssignments.Add(task, resource);

                // Custom attributes which is visible in "Resource Usage" view can be created with ExtendedAttributeDefinition.CreateResourceDefinition method.
                {
                    var resCostAttributeDefinition = ExtendedAttributeDefinition.CreateResourceDefinition(
                        CustomFieldType.Cost,
                        ExtendedAttributeResource.Cost5,
                        "My cost");

                    project.ExtendedAttributes.Add(resCostAttributeDefinition);

                    var value = resCostAttributeDefinition.CreateExtendedAttribute();

                    // The type of the attribute is "Cost", so we need to use "NumericValue" property.
                    value.NumericValue = 1500;

                    assignment.ExtendedAttributes.Add(value);
                }

                // Custom attributes which is visible in "Task Usage" view can be created with ExtendedAttributeDefinition.CreateTaskDefinition method
                {
                    var taskCostAttributeDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(
                        CustomFieldType.Cost,
                        ExtendedAttributeTask.Cost5,
                        "My cost for task");

                    project.ExtendedAttributes.Add(taskCostAttributeDefinition);

                    var value = taskCostAttributeDefinition.CreateExtendedAttribute();

                    // The type of the attribute is "Cost", so we need to use "NumericValue" property.
                    value.NumericValue = 2300;

                    assignment.ExtendedAttributes.Add(value);
                }

                project.Save(dataDir + "AddExtendedAttributesToResourceAssignment_out.mpp", SaveFileFormat.MPP);
                //ExEnd: AddExtendedAttributesToResourceAssignment
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
