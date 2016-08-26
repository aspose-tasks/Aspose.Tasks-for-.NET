using System;

namespace Aspose.Tasks.Examples.CSharp.HandlingBasicProperties
{
    public class ReadCurrencyProperties
    {
        public static void Run()
        {
            // ExStart:ReadCurrencyProperties
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_HandlingBasicProperties();
            Project project = new Project(dataDir + "ReadCurrencyProperties.mpp");

            // Display currency properties
            Console.WriteLine("Currency Code : " + project.Get(Prj.CurrencyCode).ToString());
            Console.WriteLine("<br>Currency Digits : " + project.Get(Prj.CurrencyDigits).ToString());
            Console.WriteLine("<br>Currency Symbol : " + project.Get(Prj.CurrencySymbol).ToString());
            Console.WriteLine("Currency Symbol Position" + project.Get(Prj.CurrencySymbolPosition).ToString());
            // ExEnd:ReadCurrencyProperties
        }
    }
}