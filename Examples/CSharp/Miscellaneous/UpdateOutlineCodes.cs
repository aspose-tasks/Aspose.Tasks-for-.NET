using Aspose.Tasks.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.Miscellaneous
{
    class UpdateOutlineCodes
    {
        public static void Run()
        {
            try
            {
                // ExStart:UpdateOutlineCodes
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
                Project project = new Project(dataDir + "project.mpp");
                 
                // Define outline code and its outline mask
                OutlineCodeDefinition code1 = new OutlineCodeDefinition();
                code1.Alias = "New task outline code1";
                code1.FieldId = ((int)ExtendedAttributeTask.OutlineCode1).ToString();
                code1.FieldName = "Outline Code1";
                OutlineMask mask = new OutlineMask();
                mask.Separator = "+";
                mask.Level = 1;
                mask.Type = MaskType.Numbers;
                code1.Masks.Add(mask);

                // Add outline value
                OutlineValue value = new OutlineValue();
                value.Description = "Value description";
                value.ValueId = 1;
                value.Value = "123456";
                value.Type = OutlineValueType.Number;
                code1.Values.Add(value);

                // Add outline code to project
                project.OutlineCodes.Add(code1);

                // Define outline code and its outline mask
                OutlineCodeDefinition code2 = new OutlineCodeDefinition();
                code2.Alias = "New rsc outline code2";
                code2.FieldId = ((int)ExtendedAttributeResource.OutlineCode2).ToString();
                code2.FieldName = "Outline Code2";
                OutlineMask mask2 = new OutlineMask();
                mask2.Separator = "/";
                mask2.Level = 1;
                mask2.Type = MaskType.Numbers;
                code2.Masks.Add(mask2);

                // Add outline value
                OutlineValue value2 = new OutlineValue();
                value2.Description = "Value2 description";
                value2.ValueId = 2;
                value2.Value = "987654";
                value2.Type = OutlineValueType.Number;
                code2.Values.Add(value2);

                // Add outline code to project
                project.OutlineCodes.Add(code2);

                // Save project as MPP
                project.Save(dataDir + "Updated_project_out.mpp", SaveFileFormat.MPP);
                // ExEnd:UpdateOutlineCodes
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }         
        }
    }
}
