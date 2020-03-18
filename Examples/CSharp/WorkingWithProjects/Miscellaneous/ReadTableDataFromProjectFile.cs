/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Miscellaneous
{
    using System;

    public class ReadTableDataFromProjectFile
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:ReadTableDataFromProjectFile
            var project = new Project(dataDir + "ReadTableData.mpp");

            // Access table
            var task1 = project.Tables.ToList()[0];
            Console.WriteLine("Table Fields Count" + task1.TableFields.Count);

            // Display all table fields information
            foreach (var tableField in task1.TableFields)
            {
                Console.WriteLine("Field width: " + tableField.Width);
                Console.WriteLine("Field Title: " + tableField.Title);
                Console.WriteLine("Field Title Alignment: " + tableField.AlignTitle);
                Console.WriteLine("Field Align Data: " + tableField.AlignData);
            }
            //ExEnd:ReadTableDataFromProjectFile
        }
    }
}