namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectProperties
{
    using System;

    internal class ReadFiscalYearProperties
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            
            //ExStart:ReadFiscalYearProperties
            //ExFor: Prj.FyStartDate
            //ExFor: Prj.FiscalYearStart
            //ExSummary: Shows how to read project's fiscal year dates.
            // Create a project instance
            var project = new Project(dataDir + "ReadFiscalYearProperties.mpp");

            // Display fiscal year properties
            Console.WriteLine("Fiscal Year Start Date: " + project.Get(Prj.FyStartDate));
            Console.WriteLine("Fiscal Year Numbering: " + project.Get(Prj.FiscalYearStart));
            //ExEnd:ReadFiscalYearProperties
        }
    }
}