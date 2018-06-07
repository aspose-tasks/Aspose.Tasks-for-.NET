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

            // Assign the resource desired task
            ResourceAssignment assn = project.ResourceAssignments.Add(task1, rsc1);

            var assignment = project.ResourceAssignments.First();

            // Custom attributes which is visible in "Resource Usage" view can be created with ExtendedAttributeDefinition.CreateResourceDefinition method.
            {
                ExtendedAttributeDefinition resCostAttr = ExtendedAttributeDefinition.CreateResourceDefinition(
                    CustomFieldType.Cost,
                    ExtendedAttributeResource.Cost5,
                    "My cost");

                project.ExtendedAttributes.Add(resCostAttr);

                var value = resCostAttr.CreateExtendedAttribute();
                value.Value = "1500";

                assignment.ExtendedAttributes.Add(value);
            }

            // Custom attributes which is visible in "Task Usage" view can be created with ExtendedAttributeDefinition.CreateTaskDefinition method
            {
                ExtendedAttributeDefinition resCostAttr2 = ExtendedAttributeDefinition.CreateTaskDefinition(
                    CustomFieldType.Cost,
                    ExtendedAttributeTask.Cost5,
                    "My cost for task");

                project.ExtendedAttributes.Add(resCostAttr2);

                var value = resCostAttr2.CreateExtendedAttribute();
                value.Value = "2300";

                assignment.ExtendedAttributes.Add(value);
            }

            project.Save(dataDir + "AddExtendedAttributesToResourceAssignment_out.mpp", SaveFileFormat.MPP);
            //ExEnd: AddExtendedAttributesToResourceAssignment
        }
    }
}
