using Aspose.Tasks.Saving;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class WorkingWithOutlineCodes
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ReadOutlineCodes(dataDir);
            CheckOutlineCodeIdUniqueness(dataDir);
        }

        private static void ReadOutlineCodes(string dataDir)
        {
            // ExStart:ReadOutlineCodes
            Project project = new Project(dataDir + "OutlineCodes.mpp");

            foreach (OutlineCodeDefinition ocd in project.OutlineCodes)
            {
                Console.WriteLine("Alias = " + ocd.Alias);
                if (ocd.AllLevelsRequired)
                    Console.WriteLine("It contains property: must have all levels");
                else
                    Console.WriteLine("It does not contain property: must have all levels");
                if (ocd.Enterprise)
                    Console.WriteLine("It is an enterprise custom outline code.");
                else
                    Console.WriteLine("It is not an enterprise custom outline code.");

                Console.WriteLine("Reference to another custom field for which this outline code definition is an alias is = " + ocd.EnterpriseOutlineCodeAlias);
                Console.WriteLine("Field Id = " + ocd.FieldId);
                Console.WriteLine("Field Name = " + ocd.FieldName);
                Console.WriteLine("Phonetic Alias = " + ocd.PhoneticAlias);
                Console.WriteLine("Guid = " + ocd.Guid);

                // Display outline code masks
                foreach (OutlineMask outlineMask in ocd.Masks)
                {
                    Console.WriteLine("Level of a mask = " + outlineMask.Level);
                    Console.WriteLine("Mask = " + outlineMask.ToString());
                }

                // Display out line code values
                foreach (OutlineValue outlineMask1 in ocd.Values)
                {
                    Console.WriteLine("Description of outline value = " + outlineMask1.Description);
                    Console.WriteLine("Value Id = " + outlineMask1.ValueId);
                    Console.WriteLine("Value = " + outlineMask1.Value);
                    Console.WriteLine("Type = " + outlineMask1.Type);
                }
            }
            // ExEnd:ReadOutlineCodes
        }

        private static void CheckOutlineCodeIdUniqueness(string dataDir)
        {
            // ExStart:CheckOutlineCodeIdUniqueness
            Project project = new Project(dataDir + "OutlineValues2010.mpp");

            OutlineCodeDefinition textOutline = new OutlineCodeDefinition();
            textOutline.FieldId = ExtendedAttributeTask.OutlineCode7.ToString("D");
            textOutline.Alias = "My Outline Code";

            project.OutlineCodes.Add(textOutline);

            OutlineMask mask = new OutlineMask();
            mask.Type = MaskType.Characters;
            textOutline.Masks.Add(mask);

            OutlineValue textValue = new OutlineValue();
            textValue.Value = "Text value 1";
            textValue.ValueId = 1;
            textValue.Type = OutlineValueType.Text;
            textValue.Description = "Text value descr 1";
            textOutline.Values.Add(textValue);

            project.Save(dataDir + "MultipleOutlineValues.mpp", SaveFileFormat.MPP);
            // ExEnd:CheckOutlineCodeIdUniqueness
        }
    }
}