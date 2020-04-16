namespace Aspose.Tasks.Examples.CSharp
{
    using System;
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
        public void SaveProjectAsBMP()
        {
            //ExStart:SaveProjectAsBMP
            //ExFor: SaveFileFormat.BMP
            //ExSummary: Shows how to save a project in BMP format.
            var project = new Project(DataDir + "CreateProject1.mpp");
            project.Save(OutDir + "SaveProjectAsBMP_out.bmp", SaveFileFormat.BMP);
            //ExEnd:SaveProjectAsBMP
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
        
        [Test]
        public void CreateEmptyProjectSaveMPP()
        {
            try
            {
                //ExStart
                //ExFor: SaveFileFormat.MPP
                //ExSummary: Shows how to save a project into MPP format without passing of an MPP template file.
                var project = new Project();

                // The project will be saved into MPP by using internal MPP template.
                project.Save(OutDir + "CreateEmptyProjectSaveMPP_out.mpp", SaveFileFormat.MPP);
                //ExEnd:CreateEmptyProjectSaveMPP
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void CreateEmptyProjectSaveXML()
        {
            //ExStart:CreateEmptyProjectSaveXML
            //ExFor: SaveFileFormat.XML
            //ExSummary: Shows how to create an empty project and save it into MS Project XML format.
            var project = new Project();
            project.Save(OutDir + "EmptyProjectSaveXML_out.xml", SaveFileFormat.XML);
            //ExEnd:CreateEmptyProjectSaveXML
        }
        
        [Test]
        public void ExportProjectDataToXERFormat()
        {
            //ExStart:ExportProjectDataToXERFormat
            //ExFor: SaveFileFormat.PrimaveraXER
            //ExSummary: Shows how to open an MPP file and then export it in XER format.
            var project = new Project(DataDir + "Project1.mpp");
            project.Save(OutDir + "ExportProjectDataToXERFormat_out.mpp", SaveFileFormat.PrimaveraXER);
            //ExEnd:ExportProjectDataToXERFormat
        }
        
        [Test]
        public void ExportProjectDataToP6XMLFormat()
        {
            //ExStart:ExportProjectDataToP6XMLFormat
            //ExFor: SaveFileFormat.PrimaveraP6XML
            //ExSummary: Shows how to open an MPP file and then export it in Primavera P6 XML format.
            var project = new Project(DataDir + "Project1.mpp");
            project.Save(OutDir + "ExportProjectDataToXMLFormat_out.xml", SaveFileFormat.PrimaveraP6XML);             
            //ExEnd:ExportProjectDataToP6XMLFormat
        }
        
        [Test]
        public void ExportProjectDataToPrimaveraMPXFormat()
        {
            //ExStart:ExportProjectDataToPrimaveraMPXFormat
            //ExFor: SaveFileFormat.MPX
            //ExSummary: Shows how to open an MPP file and then export it in MPX format.
            var project = new Project(DataDir + "Project1.mpp");
            project.Save(OutDir + "ExportProjectDataToPrimaveraMPXFormat_out.xml", SaveFileFormat.MPX);
            //ExEnd:ExportProjectDataToPrimaveraMPXFormat
        }
    }
}