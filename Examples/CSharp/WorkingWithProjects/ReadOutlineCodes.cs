using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class ReadOutlineCodes
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

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
    }
}