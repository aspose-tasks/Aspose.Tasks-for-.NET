namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExHeaderFooterInfo : ApiExampleBase
    {
        [Test] // ExSkip
        public void WorkWithHeaderFooterInfo()
        {
            // ExStart:ReadHeaderFooterInfo
            // ExFor: HeaderFooterInfo
            // ExFor: HeaderFooterInfo.#ctor
            // ExFor: HeaderFooterInfo.LeftImage
            // ExFor: HeaderFooterInfo.LeftImageSize
            // ExFor: HeaderFooterInfo.LeftText
            // ExFor: HeaderFooterInfo.CenteredImage
            // ExFor: HeaderFooterInfo.CenteredImageSize
            // ExFor: HeaderFooterInfo.CenteredText
            // ExFor: HeaderFooterInfo.RightImage
            // ExFor: HeaderFooterInfo.RightImageSize
            // ExFor: HeaderFooterInfo.RightText
            // ExSummary: Shows how to read page header/footer info.
            var project = new Project(DataDir + "Blank2010.mpp");
            var info = project.DefaultView.PageInfo;

            Console.WriteLine("Header left text: {0} ", info.Header.LeftText);
            Console.WriteLine("Header left image: {0} ", info.Header.LeftImage);
            Console.WriteLine("Header left image size: {0} ", info.Header.LeftImageSize);
            Console.WriteLine("Header center text: {0} ", info.Header.CenteredText);
            Console.WriteLine("Header center image: {0} ", info.Header.CenteredImage);
            Console.WriteLine("Header center image size: {0} ", info.Header.CenteredImageSize);
            Console.WriteLine("Header right text: {0} ", info.Header.RightText);
            Console.WriteLine("Header right image: {0} ", info.Header.RightImage);
            Console.WriteLine("Header right image size: {0} ", info.Header.RightImageSize);
            Console.WriteLine();
            Console.WriteLine("Footer left text: {0} ", info.Footer.LeftText);
            Console.WriteLine("Footer left image: {0} ", info.Footer.LeftImage);
            Console.WriteLine("Footer left image size: {0} ", info.Footer.LeftImageSize);
            Console.WriteLine("Footer center text: {0} ", info.Footer.CenteredText);
            Console.WriteLine("Footer center image: {0} ", info.Footer.CenteredImage);
            Console.WriteLine("Footer center size: {0} ", info.Footer.CenteredImageSize);
            Console.WriteLine("Footer right text: {0} ", info.Footer.RightText);
            Console.WriteLine("Footer right image: {0} ", info.Footer.RightImage);
            Console.WriteLine("Footer right image size: {0} ", info.Footer.RightImageSize);
            // ExEnd:WorkWithHeaderFooterInfo
        }
    }
}