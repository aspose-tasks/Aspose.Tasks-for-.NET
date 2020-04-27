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
        public void CustomizeTextStyle()
        {
            // ExStart:CustomizeTextStyle
            // ExFor: TextStyle
            // ExFor: TextStyle.#ctor
            // ExFor: TextStyle.FontStyle
            // ExSummary: Shows how to customize text styles which are used to style different text items in a project.
            var project = new Project(DataDir + "CreateProject2.mpp");
            SaveOptions options = new PdfSaveOptions
            {
                PresentationFormat = PresentationFormat.ResourceSheet
            };

            var style = new TextStyle
            {
                Color = Color.OrangeRed,
                FontStyle = FontStyle.Bold
            };
            style.FontStyle |= FontStyle.Italic;
            style.ItemType = TextItemType.OverallocatedResources;

            options.TextStyles = new List<TextStyle>
            {
                style
            };
            project.Save(OutDir + "CustomizeTextStyle_out.pdf", options);

            // ExEnd:CustomizeTextStyle
        }
    }
}