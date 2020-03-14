using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCurrencies
{
    class GetCurrencyDigits
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:GetCurrencyDigits
            Project project1 = new Project(dataDir + "project.mpp");
            Console.WriteLine(project1.Get(Prj.CurrencyDigits));
            //ExEnd:GetCurrencyDigits
        }
    }
}
