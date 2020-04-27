namespace Aspose.Tasks.Examples.CSharp
{
    using System.Collections.Generic;
    using System.Drawing;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExTextItemType : ApiExampleBase
    {
        [Test]
        public void CustomizeTextStyle()
        {
            // ExStart
            // ExFor: TextItemType
            // ExSummary: Shows how to work with text item types.
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

            // ExEnd
        }
    }
}