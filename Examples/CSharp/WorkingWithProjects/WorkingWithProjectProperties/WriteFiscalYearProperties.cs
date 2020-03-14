using System;
using Aspose.Tasks.Saving;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectProperties
{
    public class WriteFiscalYearProperties
    {
        public static void Run()
        {
            try
            {
                //ExStart:WriteFiscalYearProperties
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                // Create a project instance
                Project project = new Project(dataDir + "WriteFiscalYearProperties.mpp");

                // Set fiscal year properties
                project.Set(Prj.FyStartDate, Month.July);
                project.Set(Prj.FiscalYearStart, true);
                project.Save(dataDir + "WriteFiscalYearProperties_out.mpp", SaveFileFormat.MPP);
                //ExEnd:WriteFiscalYearProperties
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }            
        }
    }
}