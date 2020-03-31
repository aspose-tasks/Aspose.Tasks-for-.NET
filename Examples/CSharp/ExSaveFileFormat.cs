namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExSaveFileFormat : ApiExampleBase
    {
        [Test]
        public void SaveProjectAsCSV()
        {
            //ExStart:SaveProjectAsCSV
            //ExFor: SaveFileFormat
            //ExSummary: Shows how to save a project in CSV format.
            var project = new Project(DataDir + "CreateProject1.mpp");
            project.Save(OutDir + "SaveProjectAsCSV_out.csv", SaveFileFormat.CSV);
            //ExEnd:SaveProjectAsCSV
        }
        
        [Test]
        public void SaveProjectAsPDF()
        {
            //ExStart:SaveProjectAsPDF
            //ExFor: SaveFileFormat
            //ExSummary: Shows how to save a project in PDF format.
            var project = new Project(DataDir + "CreateProject2.mpp");
            project.Save(OutDir + "SaveProjectAsPDF_out.pdf", SaveFileFormat.PDF);
            //ExEnd:SaveProjectAsPDF
        }
        
        [Test]
        public void SaveProjectAsSVG()
        {
            //ExStart:SaveProjectAsSVG
            //ExFor: SaveFileFormat
            //ExSummary: Shows how to save a project in SVG format.
            var project = new Project(DataDir + "CreateProject1.mpp");
            project.Save(OutDir + "SaveProjectAsSVG_out.SVG", SaveFileFormat.SVG);
            //ExEnd:SaveProjectAsSVG
        }
        
        [Test]
        public void SaveProjectAsText()
        {
            //ExStart:SaveProjectAsText
            //ExFor: SaveFileFormat
            //ExSummary: Shows how to save a project in TXT format. 
            var project = new Project(DataDir + "CreateProject2.mpp");
            project.Save(OutDir + "SaveProjectAsText_out.txt", SaveFileFormat.TXT);
            //ExEnd:SaveProjectAsText        
        }
        
        [Test]
        public void SaveProjectAsXLSX()
        {
            //ExStart:SaveProjectAsXLSX
            //ExFor: SaveFileFormat
            //ExSummary: Shows how to save a project in XLSX format.  
            var project = new Project(DataDir + "CreateProject2.mpp");
            project.Save(OutDir + "SaveProjectAsXLSX_out.xlsx", SaveFileFormat.XLSX);
            //ExEnd:SaveProjectAsXLSX           
        }
        
        [Test]
        public void SaveProjectDataAsHTML()
        {
            //ExStart:SaveProjectDataAsHTML
            //ExFor: SaveFileFormat
            //ExSummary: Shows how to save a project in HTML format.
            var project = new Project(DataDir + "CreateProject2.mpp");
            var option = new HtmlSaveOptions();
            project.Save(OutDir + "SaveProjectDataAsHTML_out.html", option);

            // OR

            // Adding only one page (page number 2)
            option = new HtmlSaveOptions();            
            option.Pages.Add(2); 
            project.Save(OutDir + "SaveProjectDataAsHTML2_out.html", option);
            //ExEnd:SaveProjectDataAsHTML
        }
    }
}