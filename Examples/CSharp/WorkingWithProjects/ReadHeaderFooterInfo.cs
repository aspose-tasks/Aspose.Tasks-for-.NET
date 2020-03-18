/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    using System;

    using Aspose.Tasks.Visualization;

    internal class ReadHeaderFooterInfo
    {
        //ExStart:ReadHeaderFooterInfo
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Create project and project info instances
            var project = new Project(dataDir + "Blank2010.mpp");
            var info = project.DefaultView.PageInfo;

            Console.WriteLine("Page data cannot be null : {0} ", !info.Equals(null));

            AssertHeaderFooterCorrect(info);
            AssertPageSettingsCorrect(info);
            AssertPageViewSettingsCorrect(info);
            AssertMarginsCorrect(info);
            AssertLegendCorrect(info);
        }

        private static void AssertHeaderFooterCorrect(PageInfo info)
        {
            Console.WriteLine("Header left text Equals LEFT HEADER : {0} ", info.Header.LeftText.Equals("LEFT HEADER"));
            Console.WriteLine("Header center text Equals CENTER HEADER : {0} ", info.Header.CenteredText.Equals("CENTER HEADER"));
            Console.WriteLine("Header right text Equals RIGHT HEADER : {0} ", info.Header.RightText.Equals("RIGHT HEADER"));

            Console.WriteLine("Footer left text Equals LEFT FOOTER : {0} ", info.Footer.LeftText.Equals("LEFT FOOTER"));
            Console.WriteLine("Footer center text Equals CENTER FOOTER : {0} ", info.Footer.CenteredText.Equals("CENTER FOOTER"));
            Console.WriteLine("Footer right text Equals RIGHT FOOTER : {0} ", info.Footer.RightText.Equals("RIGHT FOOTER"));
        }

        private static void AssertPageSettingsCorrect(PageInfo info)
        {
            Console.WriteLine("Portrait Orientation is Portrait : {0} ", info.PageSettings.IsPortrait.Equals(true));
            Console.WriteLine("AdjustToPercentOfNormalSize is enabled : {0} ", info.PageSettings.AdjustToPercentOfNormalSize.Equals(true));
         
            Console.WriteLine("PercentOfNormalSize Equals 150 : {0} ", info.PageSettings.PercentOfNormalSize.Equals(150));
            Console.WriteLine("PagesInWidth Equals 3 : {0} ", info.PageSettings.PagesInWidth.Equals(3));
            Console.WriteLine("PagesInHeight Equals 7 : {0} ", info.PageSettings.PagesInHeight.Equals(7));
            Console.WriteLine("PaperSize Equals PaperA4 : {0} ", info.PageSettings.PaperSize.Equals(PrinterPaperSize.PaperA4));
            Console.WriteLine("FirstPageNumber : {0} ", info.PageSettings.FirstPageNumber);
        }

        private static void AssertPageViewSettingsCorrect(PageInfo info)
        {
            Console.WriteLine("PrintAllSheetColumns is set to false : {0} ", info.PageViewSettings.PrintAllSheetColumns.Equals(false));
            Console.WriteLine("PrintFirstColumnsCountOnAllPages is set to true : {0} ", info.PageViewSettings.PrintFirstColumnsCountOnAllPages.Equals(true));

            Console.WriteLine("FirstColumnsCount Equals 3 : {0} ",  info.PageViewSettings.FirstColumnsCount.Equals(3));
            Console.WriteLine("PrintNotes is set to true : {0} ", info.PageViewSettings.PrintNotes.Equals(true));
            Console.WriteLine("PrintBlankPages is set to false : {0} ", info.PageViewSettings.PrintBlankPages.Equals(false));
            Console.WriteLine("FitTimescaleToEndOfPage is set to true : {0} ", info.PageViewSettings.FitTimescaleToEndOfPage.Equals(true));
        }

        private static void AssertMarginsCorrect(PageInfo info)
        {
            Console.WriteLine("Margins.Left Equals 1 : {0} ", info.Margins.Left - 1 <= 1e-5);
            Console.WriteLine("Margins.Top Equals 1.1 : {0} ", info.Margins.Top - 1.1 <= 1e-5);
            Console.WriteLine("Margins.Right Equals 1.2 : {0} ", info.Margins.Right - 1.2 <= 1e-5);
            Console.WriteLine("Margins.Bottom Equals 1.2 : {0} ", info.Margins.Bottom - 1.3 <= 1e-5);

            Console.WriteLine("Margin.Borders Equals Border.AroundEveryPage : {0} ", info.Margins.Borders.Equals(Border.AroundEveryPage));
        }

        private static void AssertLegendCorrect(PageInfo info)
        {
            Console.WriteLine("Legend left text Equals LEFT LEGEND : {0} ", info.Legend.LeftText.Equals("LEFT LEGEND"));
            Console.WriteLine("Legend center text Equals CENTER LEGEND : {0} ", info.Legend.CenteredText.Equals("CENTER LEGEND"));
            Console.WriteLine("Legend right text Equals RIGHT LEGEND : {0} ", info.Legend.RightText.Equals("RIGHT LEGEND"));

            Console.WriteLine("LegendOn Equals Legend.OnEveryPage : {0} ", info.Legend.LegendOn.Equals(Legend.OnEveryPage));
            Console.WriteLine("Legend Width Equals 5 : {0} ", info.Legend.Width - 5 <= 1e-5);
        }
        //ExEnd:ReadHeaderFooterInfo
    }
}
