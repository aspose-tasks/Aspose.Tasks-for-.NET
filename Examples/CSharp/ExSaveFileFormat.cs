namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExSaveFileFormat : ApiExampleBase
    {
        [Test]
        public void SaveProjectAsCSV()
        {
            // ExStart:SaveProjectAsCSV
            // ExFor: SaveFileFormat
            // ExFor: SaveFileFormat.CSV
            // ExSummary: Shows how to save a project in CSV format.
            var project = new Project(DataDir + "CreateProject1.mpp");
            project.Save(OutDir + "SaveProjectAsCSV_out.csv", SaveFileFormat.CSV);

            // ExEnd:SaveProjectAsCSV
        }

        [Test]
        public void SaveProjectAsPDF()
        {
            // ExStart:SaveProjectAsPDF
            // ExFor: SaveFileFormat.PDF
            // ExSummary: Shows how to save a project in PDF format.
            var project = new Project(DataDir + "CreateProject2.mpp");
            project.Save(OutDir + "SaveProjectAsPDF_out.pdf", SaveFileFormat.PDF);

            // ExEnd:SaveProjectAsPDF
        }

        [Test]
        public void SaveProjectAsSVG()
        {
            // ExStart:SaveProjectAsSVG
            // ExFor: SaveFileFormat.SVG
            // ExSummary: Shows how to save a project in SVG format.
            var project = new Project(DataDir + "CreateProject1.mpp");
            project.Save(OutDir + "SaveProjectAsSVG_out.SVG", SaveFileFormat.SVG);

            // ExEnd:SaveProjectAsSVG
        }

        [Test]
        public void SaveProjectAsBMP()
        {
            // ExStart:SaveProjectAsBMP
            // ExFor: SaveFileFormat.BMP
            // ExSummary: Shows how to save a project in BMP format.
            var project = new Project(DataDir + "CreateProject1.mpp");
            project.Save(OutDir + "SaveProjectAsBMP_out.bmp", SaveFileFormat.BMP);

            // ExEnd:SaveProjectAsBMP
        }

        [Test]
        public void SaveProjectAsXLSX()
        {
            var project = new Project("Microsoft Project 2019.mpp");

            // save project file as TXT file
            project.Save(OutDir + "Microsoft Project 2019.txt", SaveFileFormat.TXT);
            
            // or as XLSX file
            project.Save(OutDir + "Microsoft Project 2019.xlsx", SaveFileFormat.XLSX);
        }
        
        [Test]
        public void SaveProjectAsXAML()
        {
            // ExStart:RenderToXAML
            // ExFor: SaveFileFormat.XAML
            // ExSummary: Shows how to save a project in XAML format.
            var project = new Project(DataDir + "Project2.mpp");
            project.Save(OutDir + "RenderToXAML_out.xaml", SaveFileFormat.XAML);

            // ExEnd:RenderToXAML
        }

        [Test]
        public void SaveProjectDataToSpreadsheet2003XML()
        {
            // ExStart:SaveProjectDataToSpreadsheet2003XML
            // ExFor: SaveFileFormat.Spreadsheet2003
            // ExSummary: Shows how to save a project in Spreadsheet2003 format.
            var project = new Project(DataDir + "CreateProject2.mpp");
            project.Save(OutDir + "SaveProjectDataToSpreadsheet2003XML_out.xml", SaveFileFormat.Spreadsheet2003);

            // ExEnd:SaveProjectDataToSpreadsheet2003XML
        }

        [Test]
        public void CreateEmptyProjectSaveMPP()
        {
            try
            {
                // ExStart
                // ExFor: SaveFileFormat.MPP
                // ExSummary: Shows how to save a project into MPP format without passing of an MPP template file.
                var project = new Project();

                // The project will be saved into MPP by using internal MPP template.
                project.Save(OutDir + "CreateEmptyProjectSaveMPP_out.mpp", SaveFileFormat.MPP);

                // ExEnd:CreateEmptyProjectSaveMPP
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void CreateEmptyProjectSaveXML()
        {
            // ExStart:CreateEmptyProjectSaveXML
            // ExFor: SaveFileFormat.XML
            // ExSummary: Shows how to create an empty project and save it into MS Project XML format.
            var project = new Project();
            project.Save(OutDir + "EmptyProjectSaveXML_out.xml", SaveFileFormat.XML);

            // ExEnd:CreateEmptyProjectSaveXML
        }

        [Test]
        public void ExportProjectDataToXERFormat()
        {
            // ExStart:ExportProjectDataToXERFormat
            // ExFor: SaveFileFormat.PrimaveraXER
            // ExSummary: Shows how to open an MPP file and then export it in XER format.
            var project = new Project(DataDir + "Project1.mpp");
            project.Save(OutDir + "ExportProjectDataToXERFormat_out.mpp", SaveFileFormat.PrimaveraXER);

            // ExEnd:ExportProjectDataToXERFormat
        }

        [Test]
        public void ExportProjectDataToP6XMLFormat()
        {
            // ExStart:ExportProjectDataToP6XMLFormat
            // ExFor: SaveFileFormat.PrimaveraP6XML
            // ExSummary: Shows how to open an MPP file and then export it in Primavera P6 XML format.
            var project = new Project(DataDir + "Project1.mpp");
            project.Save(OutDir + "ExportProjectDataToXMLFormat_out.xml", SaveFileFormat.PrimaveraP6XML);             
            
            // ExEnd:ExportProjectDataToP6XMLFormat
        }
        
        [Test]
        public void ExportProjectDataToPrimaveraMPXFormat()
        {
            // ExStart:ExportProjectDataToPrimaveraMPXFormat
            // ExFor: SaveFileFormat.MPX
            // ExSummary: Shows how to open an MPP file and then export it in MPX format.
            var project = new Project(DataDir + "Project1.mpp");
            project.Save(OutDir + "ExportProjectDataToPrimaveraMPXFormat_out.xml", SaveFileFormat.MPX);

            // ExEnd:ExportProjectDataToPrimaveraMPXFormat
        }

        [Test]
        public void ExportProjectDataToHTMLFormat()
        {
            // ExStart:ExportProjectDataToHTMLFormat
            // ExFor: SaveFileFormat.HTML
            // ExSummary: Shows how to open an MPP file and then export it in HTML format.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");
            project.Save(OutDir + "ExportProjectDataToPrimaveraHTMLFormat_out.html", SaveFileFormat.HTML);

            // ExEnd:ExportProjectDataToHTMLFormat
        }

        [Test]
        public void ExportProjectDataToPNGFormat()
        {
            // ExStart:ExportProjectDataToPNGFormat
            // ExFor: SaveFileFormat.PNG
            // ExSummary: Shows how to open an MPP file and then export it in PNG format.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");
            project.Save(OutDir + "ExportProjectDataToPrimaveraPNGFormat_out.png", SaveFileFormat.PNG);

            // ExEnd:ExportProjectDataToPNGFormat
        }

        [Test]
        public void ExportProjectDataToJPEGFormat()
        {
            // ExStart:ExportProjectDataToJPEGFormat
            // ExFor: SaveFileFormat.JPEG
            // ExSummary: Shows how to open an MPP file and then export it in JPEG format.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");
            project.Save(OutDir + "ExportProjectDataToPrimaveraJPEGFormat_out.jpg", SaveFileFormat.JPEG);

            // ExEnd:ExportProjectDataToJPEGFormat
        }

        [Test]
        public void ExportProjectDataToXPSFormat()
        {
            // ExStart:ExportProjectDataToXPSFormat
            // ExFor: SaveFileFormat.XPS
            // ExSummary: Shows how to open an MPP file and then export it in XPS format.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");
            project.Save(OutDir + "ExportProjectDataToPrimaveraXPSFormat_out.xps", SaveFileFormat.XPS);

            // ExEnd:ExportProjectDataToXPSFormat
        }

        [Test]
        public void ExportProjectDataToTIFFFormat()
        {
            // ExStart:ExportProjectDataToTIFFFormat
            // ExFor: SaveFileFormat.TIFF
            // ExSummary: Shows how to open an MPP file and then export it in TIFF format.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");
            project.Save(OutDir + "ExportProjectDataToPrimaveraTIFFFormat_out.xps", SaveFileFormat.TIFF);

            // ExEnd:ExportProjectDataToTIFFFormat
        }

        [Test]
        public void ExportProjectDataToTXTFormat()
        {
            // ExStart:ExportProjectDataToTXTFormat
            // ExFor: SaveFileFormat.TXT
            // ExSummary: Shows how to open an MPP file and then export it in TXT format.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");
            project.Save(OutDir + "ExportProjectDataToPrimaveraTXTFormat_out.xps", SaveFileFormat.TXT);

            // ExEnd:ExportProjectDataToTXTFormat
        }

        [Test]
        public void ExportProjectDataToXLSXFormat()
        {
            // ExStart:ExportProjectDataToXLSXFormat
            // ExFor: SaveFileFormat.XLSX
            // ExSummary: Shows how to open an MPP file and then export it in XLSX format.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");
            project.Save(OutDir + "ExportProjectDataToPrimaveraXLSXFormat_out.xps", SaveFileFormat.XLSX);

            // ExEnd:ExportProjectDataToXLSXFormat
        }

        [Test]
        [SuppressMessage("ReSharper", "UnusedVariable", Justification = "Reviewed. Suppression is OK here.")]
        public void ExportProjectDataToGdHtmlFormat()
        {
            // ExStart:ExportProjectDataToGdHtmlFormat
            // ExFor: SaveFileFormat.GdHtml
            // ExSummary: Shows how to open an MPP file and then export it in GdHtml format.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");
            
            // save project in table - based HTML format
            project.Save(OutDir + "ExportProjectDataToPrimaveraGdHtmlFormat_out.html", SaveFileFormat.GdHtml);
            
            // reading of such GdHTML is also supported
            var readProject = new Project(OutDir + "ExportProjectDataToPrimaveraGdHtmlFormat_out.html");
            Console.WriteLine("Project Name: " + readProject.Get(Prj.Name));
            
            // ExEnd:ExportProjectDataToGdHtmlFormat
        }
    }
}