using Aspose.Tasks.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    public class AddExtendedAttributesToResourceAssignment
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart: AddExtendedAttributesToResourceAssignment
            // Create new project
            Project project = new Project(dataDir + "Blank2010.mpp");

            // Add new task and resource
            Task task1 = project.RootTask.Children.Add("Task");
            Resource rsc1 = project.Resources.Add("Rsc");

            // Assign the resource to the desired task
            ResourceAssignment assignment = project.ResourceAssignments.Add(task1, rsc1);

            // Custom attributes which is visible in "Resource Usage" view can be created with ExtendedAttributeDefinition.CreateResourceDefinition method.
            {
                ExtendedAttributeDefinition resCostAttributeDefinition = ExtendedAttributeDefinition.CreateResourceDefinition(
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
                ExtendedAttributeDefinition taskCostAttributeDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(
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
    }
}
