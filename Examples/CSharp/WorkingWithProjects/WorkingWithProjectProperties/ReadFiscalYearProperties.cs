using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectProperties
{
    public class ReadFiscalYearProperties
    {
        public static void Run()
        {
            // ExStart:ReadFiscalYearProperties
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            
            // Create a project instance
            Project project = new Project(dataDir + "ReadFiscalYearProperties.mpp");

            // Display fiscal year properties
            Console.WriteLine("Fiscal Year Start Date : " + project.Get(Prj.FyStartDate).ToString());
            Console.WriteLine("Fiscal Year Numbering : " + project.Get(Prj.FiscalYearStart).ToString());
            // ExEnd:ReadFiscalYearProperties
        }
    }
}