namespace Aspose.Tasks.Examples.CSharp
{
    using System.Collections.Generic;
    using System.Drawing;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExTextStyle : ApiExampleBase
    {
        [Test]
        public void WorkWithTextStyle()
        {
            // ExStart:WorkWithTextStyle
            // ExFor: TextStyle
            // ExFor: TextStyle.#ctor
            // ExFor: TextStyle.Color
            // ExFor: TextStyle.Font
            // ExFor: TextStyle.ItemType
            // ExFor: TextStyle.BackgroundColor
            // ExFor: TextStyle.BackgroundPattern
            // ExFor: BackgroundPattern
            // ExSummary: Shows how to customize text styles which are used to style different text items in a project.
            var project = new Project(DataDir + "CreateProject2.mpp");
            SaveOptions options = new PdfSaveOptions
            {
                PresentationFormat = PresentationFormat.ResourceSheet
            };

            var style = new TextStyle();
            style.Color = Color.OrangeRed;
            style.Font = new FontDescriptor(FontFamily.GenericMonospace.Name, 10F, FontStyles.Bold | FontStyles.Italic);
            style.ItemType = TextItemType.OverallocatedResources;
            style.BackgroundColor = Color.Aqua;
            style.BackgroundPattern = BackgroundPattern.DarkDither;

            options.TextStyles = new List<TextStyle>
            {
                style
            };
            project.Save(OutDir + "CustomizeTextStyle_out.pdf", options);

            // ExEnd:WorkWithTextStyle
        }
    }
}