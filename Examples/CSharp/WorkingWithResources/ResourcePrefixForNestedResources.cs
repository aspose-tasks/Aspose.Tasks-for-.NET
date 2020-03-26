namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    using System.Collections.Generic;
    using System.IO;

    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    //ExStart:ResourcePrefixForNestedResources
    //ExFor: ICssSavingCallback
    //ExFor: IFontSavingCallback
    //ExFor: IImageSavingCallback
    //ExFor: CssSavingArgs
    //ExFor: CssSavingArgs.#ctor
    //ExFor: FontSavingArgs
    //ExFor: ImageSavingArgs
    //ExSummary: Shows how to set resource prefixes for nested resources.
    internal class ResourcePrefixForNestedResources : ICssSavingCallback, IFontSavingCallback, IImageSavingCallback
    {
        private static readonly string DataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
        
        public static void Run()
        {
            var project = new Project(DataDir + "Project1.mpp");
            var options = GetSaveOptions(1);
            project.Save(DataDir + "document_out.html", options);
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
            var options = new HtmlSaveOptions
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
            options.FontSavingCallback = program;
            options.CssSavingCallback = program;
            options.ImageSavingCallback = program;

            options.Pages.Clear();
            options.Pages.Add(pageNumber);

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

            return options;
        }
    }
    //ExEnd:ResourcePrefixForNestedResources
}
