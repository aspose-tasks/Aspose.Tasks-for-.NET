namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectProperties
{
    using Aspose.Tasks.Saving;

    internal class WriteCurrencyProperties
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:WriteCurrencyProperties
            //ExFor: Prj.CurrencyCode
            //ExFor: Prj.CurrencyDigits
            //ExFor: Prj.CurrencySymbol
            //ExFor: Prj.CurrencySymbolPosition
            //ExSummary: Shows how to write project's currency properties.
            // Create a project instance
            var project = new Project(dataDir + "WriteCurrencyProperties.mpp");

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