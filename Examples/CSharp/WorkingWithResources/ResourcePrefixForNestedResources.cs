namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    using System.Collections.Generic;
    using System.IO;

    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    //ExStart:ResourcePrefixForNestedResources
    internal class ResourcePrefixForNestedResources : ICssSavingCallback, IFontSavingCallback, IImageSavingCallback
    {
        // The path to the documents directory.
        private static readonly string DataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
        
        public static void Run()
        {
            using (var fs = new FileStream(DataDir + "Project1.mpp", FileMode.Open))
            {
                var project = new Project(fs);
                var options = GetSaveOptions(1);
                using (var stream = new FileStream(DataDir + "document.html", FileMode.Create))
                {
                    project.Save(stream, options);
                }
            }
        }

        public void CssSaving(CssSavingArgs args)
        {
            var stream = new FileStream(DataDir + "css/" + args.FileName, FileMode.Create);
            args.Stream = stream;
            args.KeepStreamOpen = false;
            args.Uri = DataDir + "css/" + args.FileName;
        }

        public void FontSaving(FontSavingArgs args)
        {
            var stream = new FileStream(DataDir + "fonts/" + args.FileName, FileMode.Create);
            args.Stream = stream;
            args.KeepStreamOpen = false;
            args.Uri = DataDir + "fonts/" + args.FileName;
        }

        public void ImageSaving(ImageSavingArgs args)
        {
            if (args.FileName.EndsWith("png"))
            {
                var stream1 = new FileStream(DataDir + "resources/nestedResources/" + args.FileName, FileMode.Create);
                args.Stream = stream1;
                args.KeepStreamOpen = false;
                args.Uri = DataDir + "resources/" + args.FileName;

                // args.NestedUri = dataDir + "nestedResources/" + args.FileName;
            }
            else
            {
                var stream2 = new FileStream(DataDir + "resources/" + args.FileName, FileMode.Create);
                args.Stream = stream2;
                args.KeepStreamOpen = false;
                args.Uri = DataDir + "resources/" + args.FileName;
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

            var program = new ResourcePrefixForNestedResources();
            saveOptions.FontSavingCallback = program;
            saveOptions.CssSavingCallback = program;
            saveOptions.ImageSavingCallback = program;

            saveOptions.Pages.Clear();
            saveOptions.Pages.Add(pageNumber);

            if (!Directory.Exists(DataDir + "fonts"))
            {
                Directory.CreateDirectory(DataDir + "fonts");
            }

            if (!Directory.Exists(DataDir + "resources"))
            {
                Directory.CreateDirectory(DataDir + "resources");
            }

            if (!Directory.Exists(DataDir + "nestedResources"))
            {
                Directory.CreateDirectory(DataDir + "resources/nestedResources");
            }

            if (!Directory.Exists(DataDir + "css"))
            {
                Directory.CreateDirectory(DataDir + "css");
            }

            return saveOptions;
        }
    }
    //ExEnd:ResourcePrefixForNestedResources
}
