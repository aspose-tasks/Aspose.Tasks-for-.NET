/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    using System;

    using Aspose.Tasks.Saving;

    internal class WorkingWithOutlineCodes
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            try
            {
                ReadOutlineCodes(dataDir);
                CheckOutlineCodeIdUniqueness(dataDir);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        private static void ReadOutlineCodes(string dataDir)
        {
            //ExStart:ReadOutlineCodes
            //ExFor: Project.OutlineCodes
            //ExSummary: Shows how to read outline codes.
            var project = new Project(dataDir + "OutlineCodes.mpp");

            foreach (var ocd in project.OutlineCodes)
            {
                Console.WriteLine("Alias = " + ocd.Alias);
                Console.WriteLine(ocd.AllLevelsRequired ? "It contains property: must have all levels" : "It does not contain property: must have all levels");
                Console.WriteLine(ocd.Enterprise ? "It is an enterprise custom outline code." : "It is not an enterprise custom outline code.");
                Console.WriteLine("Reference to another custom field for which this outline code definition is an alias is = " + ocd.EnterpriseOutlineCodeAlias);
                Console.WriteLine("Field Id = " + ocd.FieldId);
                Console.WriteLine("Field Name = " + ocd.FieldName);
                Console.WriteLine("Phonetic Alias = " + ocd.PhoneticAlias);
                Console.WriteLine("Guid = " + ocd.Guid);

                // Display outline code masks
                foreach (var outlineMask in ocd.Masks)
                {
                    Console.WriteLine("Level of a mask = " + outlineMask.Level);
                    Console.WriteLine("Mask = " + outlineMask);
                }

                // Display out line code values
                foreach (var outlineMask1 in ocd.Values)
                {
                    Console.WriteLine("Description of outline value = " + outlineMask1.Description);
                    Console.WriteLine("Value Id = " + outlineMask1.ValueId);
                    Console.WriteLine("Value = " + outlineMask1.Value);
                    Console.WriteLine("Type = " + outlineMask1.Type);
                }
            }
            //ExEnd:ReadOutlineCodes
        }

        private static void CheckOutlineCodeIdUniqueness(string dataDir)
        {
            //ExStart:CheckOutlineCodeIdUniqueness
            //ExFor: Project.OutlineCodes
            //ExFor: OutlineMask
            //ExFor: OutlineValue
            //ExFor: OutlineCodeDefinition.FieldId
            //ExFor: OutlineCodeDefinition.Alias
            //ExFor: OutlineValueCollection.Add(OutlineValue)
            //ExFor: OutlineMaskCollection.Add(OutlineMask)
            //ExSummary: Shows how to check outline code ids uniqueness.
            var project = new Project(dataDir + "OutlineValues2010.mpp");

            var outline = new OutlineCodeDefinition();
            outline.FieldId = ExtendedAttributeTask.OutlineCode7.ToString("D");
            outline.Alias = "My Outline Code";

            project.OutlineCodes.Add(outline);

            var mask = new OutlineMask();
            mask.Type = MaskType.Characters;
            outline.Masks.Add(mask);

            var value = new OutlineValue();
            value.Value = "Text value 1";
            value.ValueId = 1;
            value.Type = OutlineValueType.Text;
            value.Description = "Text value descr 1";
            outline.Values.Add(value);

            project.Save(dataDir + "MultipleOutlineValues.mpp", SaveFileFormat.MPP);
            //ExEnd:CheckOutlineCodeIdUniqueness
        }
    }
}