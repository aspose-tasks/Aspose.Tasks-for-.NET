using System.IO;
using Aspose.Tasks;
using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class ReadFiscalYearProperties
    {
        public static void Run()
        {
            //ExStart: ReadFiscalYearProperties
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();
            //Create a project reader instance
            Project project = new Project(dataDir+ "ReadFiscalYearProperties.mpp");

            //Display fiscal year properties
            Console.WriteLine("Fiscal Year Start Date : " + project.Get(Prj.FyStartDate).ToString());
            Console.WriteLine("Fiscal Year Numbering : " + project.Get(Prj.FiscalYearStart).ToString());
            //ExEnd: ReadFiscalYearProperties
        }
    }
}