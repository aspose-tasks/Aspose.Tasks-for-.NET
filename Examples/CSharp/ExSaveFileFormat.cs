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
            //ExFor: SaveFileFormat.CSV
            //ExSummary: Shows how to save a project in CSV format.
            var project = new Project(DataDir + "CreateProject1.mpp");
            project.Save(OutDir + "SaveProjectAsCSV_out.csv", SaveFileFormat.CSV);
            //ExEnd:SaveProjectAsCSV
        }
        
        [Test]
        public void SaveProjectAsPDF()
        {
            //ExStart:SaveProjectAsPDF
            //ExFor: SaveFileFormat.PDF
            //ExSummary: Shows how to save a project in PDF format.
            var project = new Project(DataDir + "CreateProject2.mpp");
            project.Save(OutDir + "SaveProjectAsPDF_out.pdf", SaveFileFormat.PDF);
            //ExEnd:SaveProjectAsPDF
        }
        
        [Test]
        public void SaveProjectAsSVG()
        {
            //ExStart:SaveProjectAsSVG
            //ExFor: SaveFileFormat.SVG
            //ExSummary: Shows how to save a project in SVG format.
            var project = new Project(DataDir + "CreateProject1.mpp");
            project.Save(OutDir + "SaveProjectAsSVG_out.SVG", SaveFileFormat.SVG);
            //ExEnd:SaveProjectAsSVG
        }
        
        [Test]
        public void SaveProjectAsText()
        {
            //ExStart:SaveProjectAsText
            //ExFor: SaveFileFormat.TXT
            //ExSummary: Shows how to save a project in TXT format. 
            var project = new Project(DataDir + "CreateProject2.mpp");
            project.Save(OutDir + "SaveProjectAsText_out.txt", SaveFileFormat.TXT);
            //ExEnd:SaveProjectAsText        
        }
        
        [Test]
        public void SaveProjectAsXLSX()
        {
            //ExStart:SaveProjectAsXLSX
            //ExFor: SaveFileFormat.XLSX
            //ExSummary: Shows how to save a project in XLSX format.  
            var project = new Project(DataDir + "CreateProject2.mpp");
            project.Save(OutDir + "SaveProjectAsXLSX_out.xlsx", SaveFileFormat.XLSX);
            //ExEnd:SaveProjectAsXLSX           
        }
        
        [Test]
        public void SaveProjectAsXAML()
        {
            //ExStart:RenderToXAML
            //ExFor: SaveFileFormat.XAML
            //ExSummary: Shows how to save a project in XAML format.
            var project = new Project(DataDir + "Project2.mpp");
            project.Save(OutDir + "RenderToXAML_out.xaml", SaveFileFormat.XAML);
            //ExEnd:RenderToXAML
        }
        
        [Test]
        public void SaveProjectDataToSpreadsheet2003XML()
        {
            //ExStart:SaveProjectDataToSpreadsheet2003XML
            //ExFor: SaveFileFormat.Spreadsheet2003
            //ExSummary: Shows how to save a project in Spreadsheet2003 format.
            var project = new Project(DataDir + "CreateProject2.mpp");
            project.Save(OutDir + "SaveProjectDataToSpreadsheet2003XML_out.xml", SaveFileFormat.Spreadsheet2003);
            //ExEnd:SaveProjectDataToSpreadsheet2003XML
        }
    }
}