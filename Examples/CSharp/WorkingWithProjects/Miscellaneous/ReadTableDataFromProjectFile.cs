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

    internal class ReadTableDataFromProjectFile
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:ReadTableDataFromProjectFile
            //ExFor: Project.Tables
            //ExFor: TableField
            //ExSummary: Shows how to read project tables. 
            var project = new Project(dataDir + "ReadTableData.mpp");

            // Access table
            var task = project.Tables.ToList()[0];
            Console.WriteLine("Table Fields Count" + task.TableFields.Count);

            // Display all table fields information
            foreach (var field in task.TableFields)
            {
                Console.WriteLine("Field width: " + field.Width);
                Console.WriteLine("Field Title: " + field.Title);
                Console.WriteLine("Field Title Alignment: " + field.AlignTitle);
                Console.WriteLine("Field Align Data: " + field.AlignData);
            }
            //ExEnd:ReadTableDataFromProjectFile
        }
    }
}