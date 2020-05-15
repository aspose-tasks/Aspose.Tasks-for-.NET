namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    [SuppressMessage("ReSharper", "StyleCop.SA1108", Justification = "Reviewed. Suppression is OK here.")]
    public class ExPrintOptions : ApiExampleBase
    {
        [Test, Explicit, Category("Printing")]
        public void PrintLargeFiles()
        {
            // ExStart:PrintLargeFiles
            // ExFor: PrintOptions
            // ExFor: PrintOptions.#ctor
            // ExFor: NoPrinterInstalledException
            // ExFor: NoPrinterInstalledException.#ctor(SerializationInfo,StreamingContext)
            // ExSummary: Shows how to use print options.
            try
            {
                var project = new Project(DataDir + "Project2.mpp");
                var options = new PrintOptions
                {
                    Timescale = Timescale.ThirdsOfMonths
                };
                if (project.GetPageCount(Timescale.ThirdsOfMonths) <= 280)
                {
                    project.Print(options);
                }
            }
            catch (NoPrinterInstalledException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            // ExEnd: PrintLargeFiles
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}