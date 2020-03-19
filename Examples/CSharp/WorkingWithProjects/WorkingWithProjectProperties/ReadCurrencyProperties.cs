namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectProperties
{
    using System;

    internal class ReadCurrencyProperties
    {
        public static void Run()
        {
            //ExStart:ReadCurrencyProperties
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Create project instance
            var project = new Project(dataDir + "ReadCurrencyProperties.mpp");

            // Display currency properties
            Console.WriteLine("Currency Code : " + project.Get(Prj.CurrencyCode));
            Console.WriteLine("<br>Currency Digits : " + project.Get(Prj.CurrencyDigits));
            Console.WriteLine("<br>Currency Symbol : " + project.Get(Prj.CurrencySymbol));
            Console.WriteLine("Currency Symbol Position" + project.Get(Prj.CurrencySymbolPosition));
            //ExEnd:ReadCurrencyProperties
        }
    }
}