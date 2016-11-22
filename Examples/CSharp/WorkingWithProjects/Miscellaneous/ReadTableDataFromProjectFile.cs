using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Miscellaneous
{
    public class ReadTableDataFromProjectFile
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:ReadTableDataFromProjectFile
            Project project = new Project(dataDir + "ReadTableData.mpp");

            // Access table
            Table task1 = project.Tables.ToList()[0];
            Console.WriteLine("Table Fields Count" + task1.TableFields.Count);

            // Display all table fields information
            foreach (TableField tableField in task1.TableFields)
            {
                Console.WriteLine("Field width: " + tableField.Width);
                Console.WriteLine("Field Title: " + tableField.Title);
                Console.WriteLine("Field Title Alignment: " + tableField.AlignTitle.ToString());
                Console.WriteLine("Field Align Data: " + tableField.AlignData.ToString());
            }
            // ExEnd:ReadTableDataFromProjectFile
        }
    }
}