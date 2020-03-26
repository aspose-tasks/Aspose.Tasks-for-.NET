namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectProperties
{
    using System;

    internal class ReadCurrencyProperties
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:ReadCurrencyProperties
            //ExFor: Prj.CurrencyCode
            //ExFor: Prj.CurrencyDigits
            //ExFor: Prj.CurrencySymbol
            //ExFor: Prj.CurrencySymbolPosition
            //ExSummary: Shows how to read project's currency properties. 
            var project = new Project(dataDir + "ReadCurrencyProperties.mpp");

            // Display currency properties
            Console.WriteLine("Currency Code: " + project.Get(Prj.CurrencyCode));
            Console.WriteLine("Currency Digits: " + project.Get(Prj.CurrencyDigits));
            Console.WriteLine("Currency Symbol: " + project.Get(Prj.CurrencySymbol));
            Console.WriteLine("Currency Symbol Position: " + project.Get(Prj.CurrencySymbolPosition));
            //ExEnd:ReadCurrencyProperties
        }
    }
}