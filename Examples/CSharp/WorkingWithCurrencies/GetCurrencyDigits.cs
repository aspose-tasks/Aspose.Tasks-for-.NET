namespace Aspose.Tasks.Examples.CSharp.WorkingWithCurrencies
{
    using System;

    internal class GetCurrencyDigits
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:GetCurrencyDigits
            //ExFor: Prj.CurrencyDigits
            //ExSummary: Shows how to get the project currency digits.
            var project = new Project(dataDir + "project.mpp");
            Console.WriteLine(project.Get(Prj.CurrencyDigits));
            //ExEnd:GetCurrencyDigits
        }
    }
}
