using System.IO;
using Aspose.Tasks;
using Aspose.Tasks.Saving;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class WriteFiscalYearProperties
    {
        public static void Run()
        {
            //ExStart: WriteFiscalYearProperties
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();

            //Create a project instance
            Project prj = new Project(dataDir+ "WriteFiscalYearProperties.mpp");
            //Set fiscal year properties
            prj.Set(Prj.FyStartDate, Month.July);
            prj.Set(Prj.FiscalYearStart, true);
            prj.Save(dataDir+ "saved.mpp", SaveFileFormat.MPP);
            //ExEnd: WriteFiscalYearProperties
        }
    }
}