namespace Aspose.Tasks.Examples.CSharp
{
    using System.Collections.Generic;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExPdfSaveOptions : ApiExampleBase
    {
        [Test]
        public void SaveToMultiplePdfFiles()
        {
            //ExStart:SaveToMultiplePdfFiles
            //ExFor: PdfSaveOptions
            //ExFor: PdfSaveOptions.SaveToSeparateFiles
            //ExFor: PdfSaveOptions.Pages
            //ExSummary: Shows how to save selected pages of a project into PDF file. 
            var project = new Project(DataDir + "Software Development Plan.mpp");
            var saveOptions = new PdfSaveOptions();
            saveOptions.SaveToSeparateFiles = true;
            saveOptions.Pages = new List<int>();
            saveOptions.Pages.Add(1);
            saveOptions.Pages.Add(4);
            project.Save(OutDir + "SaveToMultiplePDFFiles_out.pdf", saveOptions);
            //ExEnd:SaveToMultiplePdfFiles
        }

        [Test]
        public void AddDefaultFontDuringSavingAsPDF()
        {
            //ExStart: AddDefaultFontDuringSavingAsPDF
            //ExFor: PdfSaveOptions.DefaultFontName
            //ExFor: PdfSaveOptions.UseProjectDefaultFont
            //ExSummary: Shows how to set custom font that will be used for print of output pdf.
            var project = new Project(DataDir + "CreateProject2.mpp");

            var options = new PdfSaveOptions
            {
                PresentationFormat = PresentationFormat.GanttChart,
                FitContent = true,
                UseProjectDefaultFont = false,
                DefaultFontName = "Segoe UI Black"
            };
            project.Save(OutDir + "CreateProject2_out.pdf", options);
            //ExEnd:AddDefaultFontDuringSavingAsPDF
        }
    }
}