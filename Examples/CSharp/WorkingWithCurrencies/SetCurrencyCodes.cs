using Aspose.Tasks.Saving;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCurrencies
{
    class SetCurrencyCodes
    {
        public static void Run()
        {
            //ExStart:SetCurrencyCodes
            // Create new project and set currency code
            Project project1 = new Project();            
            project1.Set(Prj.CurrencyCode, "USD");
            //ExEnd:SetCurrencyCodes

            // Save project as XML
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            project1.Save(dataDir + "project_CurrencyCodes_out.xml", SaveFileFormat.XML);
        }
    }
}
