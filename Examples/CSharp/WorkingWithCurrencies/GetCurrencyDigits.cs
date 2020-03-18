namespace Aspose.Tasks.Examples.CSharp.WorkingWithCurrencies
{
    using System;

    internal class GetCurrencyDigits
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:GetCurrencyDigits
            var project = new Project(dataDir + "project.mpp");
            Console.WriteLine(project.Get(Prj.CurrencyDigits));
            //ExEnd:GetCurrencyDigits
        }
    }
}
