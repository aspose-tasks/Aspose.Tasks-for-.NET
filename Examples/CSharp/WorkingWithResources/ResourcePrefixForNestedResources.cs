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
            FileStream stream = new FileStream("css/" + args.FileName, FileMode.Create);
            args.Stream = stream;
            args.KeepStreamOpen = false;
            args.Uri = "css/" + args.FileName;
        }

        public void FontSaving(FontSavingArgs args)
        {
            FileStream stream = new FileStream("fonts/" + args.FileName, FileMode.Create);
            args.Stream = stream;
            args.KeepStreamOpen = false;
            args.Uri = "fonts/" + args.FileName;
        }

        public void ImageSaving(ImageSavingArgs args)
        {
            if (args.FileName.EndsWith("png"))
            {
                FileStream stream1 = new FileStream("resources/nestedResources/" + args.FileName, FileMode.Create);
                args.Stream = stream1;
                args.KeepStreamOpen = false;
                args.Uri = "resources/" + args.FileName;
                args.NestedUri = "nestedResources/" + args.FileName;
            }
            else
            {
                FileStream stream2 = new FileStream("resources/" + args.FileName, FileMode.Create);
                args.Stream = stream2;
                args.KeepStreamOpen = false;
                args.Uri = "resources/" + args.FileName;
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

            if (!Directory.Exists("fonts"))
            {
                Directory.CreateDirectory("fonts");
            }

            if (!Directory.Exists("resources"))
            {
                Directory.CreateDirectory("resources");
            }

            if (!Directory.Exists("nestedResources"))
            {
                Directory.CreateDirectory("resources/nestedResources");
            }

            if (!Directory.Exists("css"))
            {
                Directory.CreateDirectory("css");
            }

            return saveOptions;
        }
    }
    // ExEnd:ResourcePrefixForNestedResources
}
