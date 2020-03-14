using Aspose.Tasks.Saving;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectProperties
{
    public class WriteCurrencyProperties
    {
        public static void Run()
        {
            //ExStart:WriteCurrencyProperties
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Create a project instance
            Project project = new Project(dataDir + "WriteCurrencyProperties.mpp");

            // Set currency properties
            project.Set(Prj.CurrencyCode, "AUD");
            project.Set(Prj.CurrencyDigits, 2);
            project.Set(Prj.CurrencySymbol, "$");
            project.Set(Prj.CurrencySymbolPosition, CurrencySymbolPositionType.After);

            // Save the project as XML project file
            project.Save(dataDir + "WriteCurrencyProperties_out.xml", SaveFileFormat.XML);
            //ExEnd:WriteCurrencyProperties
        }
    }
}