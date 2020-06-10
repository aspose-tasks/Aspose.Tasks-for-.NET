using System.Threading.Tasks;
using System.IO;
using Aspose.Tasks;
using Aspose.Tasks.Saving;
using System.Diagnostics;

namespace Aspose.Tasks.Live.Demos.UI.Models
{
	///<Summary>
	/// AsposeTasksConversion class to convert tasks file to other format
	///</Summary>
	public class AsposeTasksConversion : TasksBase
	{
			private Response ProcessTask(string fileName, string folderName, string outFileExtension, bool createZip, bool checkNumberofPages, ActionDelegate action)
			{
			Aspose.Tasks.Live.Demos.UI.Models.License.SetAsposeTasksLicense();
				return  Process(this.GetType().Name, fileName, folderName, outFileExtension, createZip, checkNumberofPages,  (new StackTrace()).GetFrame(5).GetMethod().Name, action);

			}
			///<Summary>
			/// ConvertProjectToPdf method to convert project to pdf format
			///</Summary>
			public Response ConvertProjectToPdf(string fileName, string folderName, string outputType)
			{
				return  ProcessTask(fileName, folderName, ".pdf", false, false, delegate (string inFilePath, string outPath, string zipOutFolder)
				{
					Project project = new Project(inFilePath);
					PdfSaveOptions pdfSaveOptions = new PdfSaveOptions();

					if (outputType == "pdfa_1b")
					{
						pdfSaveOptions.Compliance = PdfCompliance.PdfA1b;
					}
					else if (outputType == "pdfa_1a")
					{
						pdfSaveOptions.Compliance = PdfCompliance.PdfA1a;
					}
					else if (outputType == "pdf_15")
					{
						pdfSaveOptions.Compliance = PdfCompliance.Pdf15;
					}

					project.Save(outPath, (SaveOptions)pdfSaveOptions);

				});
			}
			///<Summary>
			/// ConvertProjectToHtml method to convert project to html format
			///</Summary>
			public Response ConvertProjectToHtml(string fileName, string folderName)
			{
				return  ProcessTask(fileName, folderName, ".html", true, false, delegate (string inFilePath, string outPath, string zipOutFolder)
				{
					Project project = new Project(inFilePath);
					project.Save(outPath, SaveFileFormat.HTML);
				});
			}
			///<Summary>
			/// ConvertProjectToPrimavera method to convert project to Primavera format
			///</Summary>
			public Response ConvertProjectToPrimavera(string fileName, string folderName, string outputType)
			{
				if (outputType.Equals("xml") || outputType.Equals("xer") || outputType.Equals("txt") || outputType.Equals("xlsx") || outputType.Equals("xls"))
				{
					SaveFileFormat format = SaveFileFormat.TXT;

					if (outputType.Equals("xlsx") || outputType.Equals("xls"))
					{
						format = SaveFileFormat.XLSX;
					}
					else if (outputType.Equals("xml"))
					{
						format = SaveFileFormat.PrimaveraP6XML;
					}
					else if (outputType.Equals("xer"))
					{
						format = SaveFileFormat.PrimaveraXER;
					}

					return  ProcessTask(fileName, folderName, "." + outputType, false, false, delegate (string inFilePath, string outPath, string zipOutFolder)
					{
						Project project = new Project(inFilePath);

						if (outputType.Equals("xls"))
						{
							var xlsxOutPath = outPath + "x";
							project.Save(xlsxOutPath, format);

							Aspose.Tasks.Live.Demos.UI.Models.License.SetAsposeCellsLicense();
							var workbook = new Aspose.Cells.Workbook(xlsxOutPath);
							workbook.Save(outPath, Aspose.Cells.SaveFormat.Excel97To2003);
						}
						else
						{
							project.Save(outPath, format);
						}
					});
				}

				return  new Response
				{
					FileName = null,
					Status = "Output type not found",
					StatusCode = 500
				};
			}

			public Response ConvertProjectToExchange(string fileName, string folderName, string outputType)
			{
				return  ProcessTask(
						   fileName,
						   folderName,
						   "." + outputType,
						   false,
						   false,
						   delegate (string inFilePath, string outPath, string zipOutFolder)
						   {
							   Project project = new Project(inFilePath);

							   project.Save(outPath, SaveFileFormat.MPX);
						   });
			}

			///<Summary>
			/// ConvertProjectToImages method to convert project to Images format
			///</Summary>
			public Response ConvertProjectToImages(string fileName, string folderName, string outputType)
			{
				if (outputType.Equals("bmp") || outputType.Equals("jpg") || outputType.Equals("png"))
				{
					SaveFileFormat format = SaveFileFormat.BMP;

					if (outputType.Equals("jpg"))
					{
						format = SaveFileFormat.JPEG;
					}
					else if (outputType.Equals("png"))
					{
						format = SaveFileFormat.PNG;
					}
					else if (outputType.Equals("svg"))
					{
						format = SaveFileFormat.SVG;
					}
					else if (outputType.Equals("xps"))
					{
						format = SaveFileFormat.XPS;
					}
					//ImageSaveOptions imageSaveOptions = new ImageSaveOptions(format);

					return  ProcessTask(fileName, folderName, "." + outputType, true, false, delegate (string inFilePath, string outPath, string zipOutFolder)
					{
						Project project = new Project(inFilePath);

						project.Save(outPath, format);
					});
				}

				return new Response
				{
					FileName = null,
					Status = "Output type not found",
					StatusCode = 500
				};
			}
			///<Summary>
			/// ConvertProjectToSingleImage method to convert project to Image format
			///</Summary>
			public Response ConvertProjectToSingleImage(string fileName, string folderName, string outputType)
			{
				if (outputType.Equals("tiff") || outputType.Equals("svg") || outputType.Equals("xps"))
				{
					SaveFileFormat format = SaveFileFormat.TIFF;

					if (outputType.Equals("svg"))
					{
						format = SaveFileFormat.SVG;
					}
					else if (outputType.Equals("xps"))
					{
						format = SaveFileFormat.XPS;
					}

					return  ProcessTask(fileName, folderName, "." + outputType, false, false, delegate (string inFilePath, string outPath, string zipOutFolder)
					{
						Project project = new Project(inFilePath);
						project.Save(outPath, format);
					});
				}

				return new Response
				{
					FileName = null,
					Status = "Output type not found",
					StatusCode = 500
				};
			}
			///<Summary>
			/// ConvertFile
			///</Summary>
			public Response ConvertFile(string fileName, string folderName, string outputType)
			{
				outputType = outputType.ToLower();

				if (outputType.StartsWith("pdf"))
				{
					return  ConvertProjectToPdf(fileName, folderName, outputType);
				}
				else if (outputType.Equals("html"))
				{
					return  ConvertProjectToHtml(fileName, folderName);
				}
				else if (outputType.Equals("bmp") || outputType.Equals("jpg") || outputType.Equals("png"))
				{
					return  ConvertProjectToImages(fileName, folderName, outputType);
				}
				else if (outputType.Equals("tiff") || outputType.Equals("svg") || outputType.Equals("xps"))
				{
					return  ConvertProjectToSingleImage(fileName, folderName, outputType);
				}
				else if (outputType.Equals("xml") || outputType.Equals("xer") || outputType.Equals("txt") || outputType.Equals("xlsx") || outputType.Equals("xls"))
				{
					return  ConvertProjectToPrimavera(fileName, folderName, outputType);
				}
				if (outputType.Equals("mpx"))
				{
					return  ConvertProjectToExchange(fileName, folderName, outputType);
				}

				return new Response
				{
					FileName = null,
					Status = "Output type not found",
					StatusCode = 500
				};
			}
		}
	
}