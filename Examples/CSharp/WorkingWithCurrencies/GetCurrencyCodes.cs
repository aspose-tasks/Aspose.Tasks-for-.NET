using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCurrencies
{
    class GetCurrencyCodes
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:GetCurrencyCodes
            Project project1 = new Project(dataDir + "project.mpp");
            Console.WriteLine(project1.Get(Prj.CurrencyCode));
            // ExEnd:GetCurrencyCodes
        }
    }
}
