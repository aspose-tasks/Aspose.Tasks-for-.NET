using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCurrencies
{
    class GetCurrencySymbol
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:GetCurrencySymbol
            Project project1 = new Project(dataDir + "project.mpp");
            Console.WriteLine(project1.Get(Prj.CurrencySymbol));
            // ExEnd:GetCurrencySymbol
        }
    }
}
