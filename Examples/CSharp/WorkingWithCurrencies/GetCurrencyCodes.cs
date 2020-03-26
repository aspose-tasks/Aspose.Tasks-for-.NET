namespace Aspose.Tasks.Examples.CSharp.WorkingWithCurrencies
{
    using System;

    internal class GetCurrencyCodes
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:GetCurrencyCodes
            //ExFor: Prj.CurrencyCode
            //ExSummary: Shows how to get the project currency code.
            var project = new Project(dataDir + "project.mpp");
            Console.WriteLine(project.Get(Prj.CurrencyCode));
            //ExEnd:GetCurrencyCodes
        }
    }
}
