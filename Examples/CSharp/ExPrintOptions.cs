namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExPrintOptions : ApiExampleBase
    {
        [Test, Explicit]
        public void PrintLargeFiles()
        {
            try
            {
                //ExStart:PrintLargeFiles
                //ExFor: PrintOptions
                //ExSummary: Shows how to use print options.
                var project = new Project(DataDir + "Project2.mpp");
                var options = new PrintOptions();
                options.Timescale = Timescale.ThirdsOfMonths;
                if (project.GetPageCount(Timescale.ThirdsOfMonths) <= 280)
                {
                    project.Print(options);
                }
                //ExEnd:PrintLargeFiles
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}