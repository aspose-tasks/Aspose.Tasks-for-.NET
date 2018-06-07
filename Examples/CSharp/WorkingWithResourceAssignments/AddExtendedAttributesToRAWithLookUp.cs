using Aspose.Tasks.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    public class AddExtendedAttributesToRAWithLookUp
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart: AddExtendedAttributesToRAWithLookUp
            // Create new project
            Project project = new Project(dataDir + "Blank2010.mpp");

            var assignment = project.ResourceAssignments.First();

            {
                ExtendedAttributeDefinition resCostAttr = ExtendedAttributeDefinition.CreateLookupResourceDefinition(
                    CustomFieldType.Cost,
                    ExtendedAttributeResource.Cost5,
                    "My lookup cost");

                var value1 = new Value { NumberValue = 1500, Description = "Val 1", Id = 1, Val = "1500" };

                resCostAttr.AddLookupValue(value1);

                resCostAttr.AddLookupValue(new Value
                {
                    NumberValue = 2500,
                    Description = "Val 2",
                    Id = 2
                });

                project.ExtendedAttributes.Add(resCostAttr);

                var value = resCostAttr.CreateExtendedAttribute(value1);
                value.Value = "1500";
                project.Save(dataDir + "AddExtendedAttributesToRAWithLookUp_out.mpp", SaveFileFormat.MPP);
                //ExEnd: AddExtendedAttributesToRAWithLookUp
            }
        }
    }
}
