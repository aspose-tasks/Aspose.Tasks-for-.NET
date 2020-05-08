namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExPageMargins : ApiExampleBase
    {
        [Test]
        public void WorkWithPageMargins()
        {
            try
            {
                // ExStart:WorkWithPageMargins
                // ExFor: PageMargins
                // ExFor: PageMargins.Borders
                // ExFor: PageMargins.Bottom
                // ExFor: PageMargins.Left
                // ExFor: PageMargins.Right
                // ExFor: PageMargins.Top
                // ExFor: Border
                // ExSummary: Shows how to work with page margins.
                var project = new Project(DataDir + "Project2.mpp");

                // lets modify the default view
                var margins = project.DefaultView.PageInfo.Margins;

                // lets modify margins
                margins.Left = 10d;
                margins.Top = 10d;
                margins.Right = 10d;
                margins.Bottom = 10d;
                margins.Borders = Border.OutsidePages;

                project.Save(OutDir + "WorkWithPageMargins_out.mpp", SaveFileFormat.MPP);
                // ExEnd:WorkWithPageMargins
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}