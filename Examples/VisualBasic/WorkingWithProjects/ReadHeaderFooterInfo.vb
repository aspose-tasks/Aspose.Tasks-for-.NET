Imports Aspose.Tasks.Visualization

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects
    Public Class ReadHeaderFooterInfo
        ' ExStart:ReadHeaderFooterInfo
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' Create project and project info instances
            Dim project As New Project(dataDir & "HeaderFooter2007_3.mpp")
            Dim info As PageInfo = project.DefaultView.PageInfo

            Console.WriteLine("Page data cannot be null : {0} ", info.Equals(Nothing))

            If info IsNot Nothing Then
                AssertHeaderFooterCorrect(info)
                AssertPageSettingsCorrect(info)
                AssertPageViewSettingsCorrect(info)
                AssertMarginsCorrect(info)
                AssertLegendCorrect(info)
            End If

        End Sub

        Private Shared Sub AssertHeaderFooterCorrect(info As PageInfo)
            Console.WriteLine("Header left text Equals LEFT HEADER : {0} ", info.Header.LeftText.Equals("LEFT HEADER"))
            Console.WriteLine("Header center text Equals CENTER HEADER : {0} ", info.Header.CenteredText.Equals("CENTER HEADER"))
            Console.WriteLine("Header right text Equals RIGHT HEADER : {0} ", info.Header.RightText.Equals("RIGHT HEADER"))

            Console.WriteLine("Footer left text Equals LEFT FOOTER : {0} ", info.Footer.LeftText.Equals("LEFT FOOTER"))
            Console.WriteLine("Footer center text Equals CENTER FOOTER : {0} ", info.Footer.CenteredText.Equals("CENTER FOOTER"))
            Console.WriteLine("Footer right text Equals RIGHT FOOTER : {0} ", info.Footer.RightText.Equals("RIGHT FOOTER"))
        End Sub

        Private Shared Sub AssertPageSettingsCorrect(info As PageInfo)
            Console.WriteLine("Portrait Orientation is Portrait : {0} ", info.PageSettings.IsPortrait.Equals(True))
            Console.WriteLine("AdjustToPercentOfNormalSize is enabled : {0} ", info.PageSettings.AdjustToPercentOfNormalSize.Equals(True))

            Console.WriteLine("PercentOfNormalSize Equals 150 : {0} ", info.PageSettings.PercentOfNormalSize.Equals(150))
            Console.WriteLine("PagesInWidth Equals 3 : {0} ", info.PageSettings.PagesInWidth.Equals(3))
            Console.WriteLine("PagesInHeight Equals 7 : {0} ", info.PageSettings.PagesInHeight.Equals(7))
            Console.WriteLine("PaperSize Equals PaperA4 : {0} ", info.PageSettings.PaperSize.Equals(PrinterPaperSize.PaperA4))
            Console.WriteLine("FirstPageNumber Equals 2 : {0} ", info.PageSettings.FirstPageNumber.Equals(Short.MinValue + 2))
        End Sub

        Private Shared Sub AssertPageViewSettingsCorrect(info As PageInfo)
            Console.WriteLine("PrintAllSheetColumns is set to false : {0} ", info.PageViewSettings.PrintAllSheetColumns.Equals(False))
            Console.WriteLine("PrintFirstColumnsCountOnAllPages is set to true : {0} ", info.PageViewSettings.PrintFirstColumnsCountOnAllPages.Equals(True))

            Console.WriteLine("FirstColumnsCount Equals 3 : {0} ", info.PageViewSettings.FirstColumnsCount.Equals(3))
            Console.WriteLine("PrintNotes is set to true : {0} ", info.PageViewSettings.PrintNotes.Equals(True))
            Console.WriteLine("PrintBlankPages is set to false : {0} ", info.PageViewSettings.PrintBlankPages.Equals(False))
            Console.WriteLine("FitTimescaleToEndOfPage is set to true : {0} ", info.PageViewSettings.FitTimescaleToEndOfPage.Equals(True))
        End Sub

        Private Shared Sub AssertMarginsCorrect(info As PageInfo)
            Console.WriteLine("Margins.Left Equals 1 : {0} ", If((info.Margins.Left - 1 <= 0.00001), True, False))
            Console.WriteLine("Margins.Top Equals 1.1 : {0} ", If((info.Margins.Top - 1.1 <= 0.00001), True, False))
            Console.WriteLine("Margins.Right Equals 1.2 : {0} ", If((info.Margins.Right - 1.2 <= 0.00001), True, False))
            Console.WriteLine("Margins.Bottom Equals 1.2 : {0} ", If((info.Margins.Bottom - 1.3 <= 0.00001), True, False))

            Console.WriteLine("Margin.Borders Equals Border.AroundEveryPage : {0} ", info.Margins.Borders.Equals(Border.AroundEveryPage))
        End Sub

        Private Shared Sub AssertLegendCorrect(info As PageInfo)
            Console.WriteLine("Legend left text Equals LEFT LEGEND : {0} ", info.Legend.LeftText.Equals("LEFT LEGEND"))
            Console.WriteLine("Legend center text Equals CENTER LEGEND : {0} ", info.Legend.CenteredText.Equals("CENTER LEGEND"))
            Console.WriteLine("Legend right text Equals RIGHT LEGEND : {0} ", info.Legend.RightText.Equals("RIGHT LEGEND"))

            Console.WriteLine("LegendOn Equals Legend.OnEveryPage : {0} ", info.Legend.LegendOn.Equals(Legend.OnEveryPage))
            Console.WriteLine("Legend Width Equals 7.77 : {0} ", If((info.Legend.Width - 7.77 <= 0.00001), True, False))
        End Sub
        ' ExEnd:ReadHeaderFooterInfo
    End Class
End Namespace

