using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    // ExStart:ResourcePrefixForNestedResources
    public class ResourcePrefixForNestedResources : ICssSavingCallback, IFontSavingCallback, IImageSavingCallback
    {
        // The path to the documents directory.
        public static string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            using (FileStream fs = new FileStream(dataDir + "Project1.mpp", FileMode.Open))
            {
                Project project = new Project(fs);
                HtmlSaveOptions options = GetSaveOptions(1);
                using (FileStream stream = new FileStream(dataDir + "document.html", FileMode.Create))
                {
                    project.Save(stream, options);
                }
            }
        }

        public void CssSaving(CssSavingArgs args)
        {
            FileStream stream = new FileStream(dataDir + "css/" + args.FileName, FileMode.Create);
            args.Stream = stream;
            args.KeepStreamOpen = false;
            args.Uri = dataDir + "css/" + args.FileName;
        }

        public void FontSaving(FontSavingArgs args)
        {
            FileStream stream = new FileStream(dataDir + "fonts/" + args.FileName, FileMode.Create);
            args.Stream = stream;
            args.KeepStreamOpen = false;
            args.Uri = dataDir + "fonts/" + args.FileName;
        }

        public void ImageSaving(ImageSavingArgs args)
        {
            if (args.FileName.EndsWith("png"))
            {
                FileStream stream1 = new FileStream(dataDir + "resources/nestedResources/" + args.FileName, FileMode.Create);
                args.Stream = stream1;
                args.KeepStreamOpen = false;
                args.Uri = dataDir + "resources/" + args.FileName;
                //args.NestedUri = dataDir + "nestedResources/" + args.FileName;
            }
            else
            {
                FileStream stream2 = new FileStream(dataDir + "resources/" + args.FileName, FileMode.Create);
                args.Stream = stream2;
                args.KeepStreamOpen = false;
                args.Uri = dataDir + "resources/" + args.FileName;
            }
        }

        private static HtmlSaveOptions GetSaveOptions(int pageNumber)
        {
            var saveOptions = new HtmlSaveOptions
            {
                Pages = new List<int>(),
                IncludeProjectNameInPageHeader = false,
                IncludeProjectNameInTitle = false,
                PageSize = PageSize.A3,
                Timescale = Timescale.ThirdsOfMonths,
                ReduceFooterGap = true,
                FontFaceTypes = FontFaceType.Ttf,
                ExportCss = ResourceExportType.AsFile,
                ExportFonts = ResourceExportType.AsFile,
                ExportImages = ResourceExportType.AsFile
            };

            ResourcePrefixForNestedResources program = new ResourcePrefixForNestedResources();
            saveOptions.FontSavingCallback = program;
            saveOptions.CssSavingCallback = program;
            saveOptions.ImageSavingCallback = program;

            saveOptions.Pages.Clear();
            saveOptions.Pages.Add(pageNumber);

            if (!Directory.Exists(dataDir + "fonts"))
            {
                Directory.CreateDirectory(dataDir + "fonts");
            }

            if (!Directory.Exists(dataDir + "resources"))
            {
                Directory.CreateDirectory(dataDir + "resources");
            }

            if (!Directory.Exists(dataDir + "nestedResources"))
            {
                Directory.CreateDirectory(dataDir + "resources/nestedResources");
            }

            if (!Directory.Exists(dataDir + "css"))
            {
                Directory.CreateDirectory(dataDir + "css");
            }

            return saveOptions;
        }
    }
    // ExEnd:ResourcePrefixForNestedResources
}
