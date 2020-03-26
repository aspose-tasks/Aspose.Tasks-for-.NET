namespace Aspose.Tasks.Examples.CSharp.WorkingWithCurrencies
{
    using System;

    internal class GetCurrencySymbol
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:GetCurrencySymbol
            //ExFor: Prj.CurrencySymbol
            //ExSummary: Shows how to get the project currency symbol.
            var project = new Project(dataDir + "project.mpp");
            Console.WriteLine(project.Get(Prj.CurrencySymbol));
            //ExEnd:GetCurrencySymbol
        }
    }
}
