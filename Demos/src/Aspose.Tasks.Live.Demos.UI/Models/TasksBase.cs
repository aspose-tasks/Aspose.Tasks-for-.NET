using System;
using System.IO;
using System.Web.Http;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Drawing;
using System.Drawing.Imaging;

namespace  Aspose.Tasks.Live.Demos.UI.Models
{
	///<Summary>
	/// CADBase class to have base methods
	///</Summary>

	public abstract class TasksBase : ApiController
    {
		///<Summary>
		/// ActionDelegate
		///</Summary>
		protected delegate void ActionDelegate(string inFilePath, string outPath, string zipOutFolder);
		///<Summary>
		/// inFileActionDelegate
		///</Summary>
		protected delegate void inFileActionDelegate(string inFilePath);
		///<Summary>
		/// Get File extension
		///</Summary>
		protected string GetoutFileExtension(string fileName, string folderName)
        {
			string sourceFolder = Config.Configuration.WorkingDirectory + folderName;
            fileName = sourceFolder + "\\" + fileName;
            return Path.GetExtension(fileName);
        }
		
        protected Response Process(string modelName, string fileName, string folderName, string outFileExtension, bool createZip, bool checkNumberofPages,  string methodName, ActionDelegate action,
      bool deleteSourceFolder = true, string zipFileName = null)
        {
            
            string guid = Guid.NewGuid().ToString();
            string outFolder = "";
			string sourceFolder = Config.Configuration.WorkingDirectory + folderName;			
            fileName = sourceFolder + "\\" + fileName;

            string fileExtension = Path.GetExtension(fileName).ToLower();
            		

			



			string outfileName = Path.GetFileNameWithoutExtension(fileName) + outFileExtension;
            string outPath = "";

			string zipOutFolder = Config.Configuration.OutputDirectory + guid;
            string zipOutfileName, zipOutPath;
            if (string.IsNullOrEmpty(zipFileName))
            {
                zipOutfileName = guid + ".zip";
				zipOutPath = Config.Configuration.OutputDirectory + zipOutfileName;
            }
            else
            {
                var guid2 = Guid.NewGuid().ToString();
                outFolder = guid2;
                zipOutfileName = zipFileName + ".zip";
				zipOutPath = Config.Configuration.OutputDirectory + guid2;
                Directory.CreateDirectory(zipOutPath);
                zipOutPath += "/" + zipOutfileName;
            }

            if (createZip)
            {
                outfileName = Path.GetFileNameWithoutExtension(fileName) + outFileExtension;
                outPath = zipOutFolder + "/" + outfileName;
                Directory.CreateDirectory(zipOutFolder);
            }
            else
            {
                outFolder = guid;
				outPath = Config.Configuration.OutputDirectory +  outFolder;
                Directory.CreateDirectory(outPath);

                outPath += "/" + outfileName;
            }

            string statusValue = "OK";
            int statusCodeValue = 200;

            try
            {
                action(fileName, outPath, zipOutFolder);

                if (createZip)
                {
                    ZipFile.CreateFromDirectory(zipOutFolder, zipOutPath);
                    Directory.Delete(zipOutFolder, true);
                    outfileName = zipOutfileName;
                }

				if (deleteSourceFolder)
				{
					System.GC.Collect();
					System.GC.WaitForPendingFinalizers();
					Directory.Delete(sourceFolder, true);
				}

            }
            catch (Exception ex)
            {
                statusCodeValue = 500;
                statusValue = "500 " + ex.Message;
               
            }
            return new Response
            {
				FileName = outfileName,
				FolderName = outFolder,
				Status = statusValue,
				StatusCode = statusCodeValue,
			};
        }
		///<Summary>
		/// Aspose Cells Options Class
		///</Summary>
		protected class Options
		{
			///<Summary>
			/// AppName
			///</Summary>
			public string AppName;

			///<Summary>
			/// FolderName
			///</Summary>
			public string FolderName;

			///<Summary>
			/// FileName
			///</Summary>
			public string FileName;

			private string _outputType;

			/// <summary>
			/// By default, it is the extension of FileName
			/// </summary>
			public string OutputType
			{
				get => _outputType;
				set
				{
					if (!value.StartsWith("."))
						value = "." + value;
					_outputType = value;
				}
			}

			/// <summary>
			/// Check if OuputType is a picture extension
			/// </summary>
			public bool IsPicture
			{
				get
				{
					switch (_outputType.ToLower())
					{
						case ".bmp":
						case ".png":
						case ".jpg":
						case ".jpeg":
							return true;
						default:
							return false;
					}
				}
			}

			///<Summary>
			/// ResultFileName
			///</Summary>
			public string ResultFileName;

			///<Summary>
			/// MethodName
			///</Summary>
			public string MethodName;

			///<Summary>
			/// ModelName
			///</Summary>
			public string ModelName;

			///<Summary>
			/// CreateZip
			///</Summary>
			public bool CreateZip;

			///<Summary>
			/// CheckNumberOfPages
			///</Summary>
			public bool CheckNumberOfPages = false;

			///<Summary>
			/// DeleteSourceFolder
			///</Summary>
			public bool DeleteSourceFolder = false;

			///<Summary>
			/// CalculateZipFileName
			///</Summary>
			public bool CalculateZipFileName = true;

			/// <summary>
			/// Output zip filename (without '.zip'), if CreateZip property is true
			/// By default, FileName + AppName
			/// </summary>
			public string ZipFileName;

			/// <summary>
			/// AppSettings.WorkingDirectory + FolderName + "/" + FileName
			/// </summary>
			public string WorkingFileName
			{
				get
				{
					if (File.Exists(Config.Configuration.WorkingDirectory + FolderName + "/" + FileName))
						return Config.Configuration.WorkingDirectory + FolderName + "/" + FileName;
					return Config.Configuration.OutputDirectory + FolderName + "/" + FileName;
				}
			}
		}
		/// <summary>
		/// Process
		/// </summary>
		protected Response Process(ActionDelegate action)
		{
			if (string.IsNullOrEmpty(Opts.OutputType))
				Opts.OutputType = Path.GetExtension(Opts.FileName);
			if (Opts.OutputType.ToLower() == ".html" || Opts.OutputType == ".SVG" || Opts.IsPicture)
				Opts.CreateZip = true;
			if (string.IsNullOrEmpty(Opts.ZipFileName) && Opts.CalculateZipFileName)
				Opts.ZipFileName = Path.GetFileNameWithoutExtension(Opts.FileName) + Opts.AppName;


			return Process(GetType().Name, Opts.ResultFileName, Opts.FolderName, Opts.OutputType, Opts.CreateZip,
				Opts.CheckNumberOfPages,
				 Opts.MethodName, action,
				Opts.DeleteSourceFolder, Opts.ZipFileName);
		}
		/// <summary>
		/// init Options
		/// </summary>
		protected Options Opts = new Options();
		///<Summary>
		/// Process
		///</Summary>
		/// <param name="controllerName"></param>
		/// <param name="fileName"></param>
		/// <param name="folderName"></param>
		/// <param name="productName"></param>
		/// <param name="productFamily"></param>
		/// <param name="methodName"></param>
		/// <param name="action"></param>
		protected async Task<Response> Process(string controllerName, string fileName, string folderName, string productName, string productFamily, string methodName, inFileActionDelegate action)
        {           
            string tempFileName = fileName;
			string sourceFolder = Config.Configuration.WorkingDirectory + folderName;
            fileName = sourceFolder + "/" + fileName;

            string statusValue = "OK";
            int statusCodeValue = 200;

            try
            {
                action(fileName);

                //Directory.Delete(sourceFolder, true);                

            }
            catch (Exception ex)
            {
                statusCodeValue = 500;
                statusValue = "500 " + ex.Message;
               
            }
            return new Response
            {
                Status = statusValue,
                StatusCode = statusCodeValue,
            };
        }
		
    }
}
