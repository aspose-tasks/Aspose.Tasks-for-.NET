using System;
using Aspose.Tasks.Saving;

namespace Aspose.Tasks.Examples.CSharp.HandlingBasicProperties
{
    public class WriteFiscalYearProperties
    {
        public static void Run()
        {
            // ExStart:WriteFiscalYearProperties

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_HandlingBasicProperties();

            try
            {
                // Create a project instance
                Project prj = new Project(dataDir + "WriteFiscalYearProperties.mpp");

                // Set fiscal year properties
                prj.Set(Prj.FyStartDate, Month.July);
                prj.Set(Prj.FiscalYearStart, true);
                prj.Save(dataDir + "saved.mpp", SaveFileFormat.MPP);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
            // ExEnd:WriteFiscalYearProperties
        }
    }
}