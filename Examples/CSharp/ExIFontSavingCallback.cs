namespace Aspose.Tasks.Examples.CSharp
{
    using System.Collections.Generic;
    using System.IO;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExIFontSavingCallback : ApiExampleBase
    {
        // ExStart
        // ExFor: IFontSavingCallback
        // ExFor: IFontSavingCallback.FontSaving(FontSavingArgs)
        // ExFor: HtmlSaveOptions.FontSavingCallback
        // ExSummary: Shows how to work with font saving callbacks.
        [TestFixture] // ExSkip
        internal class ResourcePrefixForNestedResources : ApiExampleBase, ICssSavingCallback, IFontSavingCallback, IImageSavingCallback
        {
            [Test] // ExSkip
            public void ResourcePrefixForNestedResourcesExample()
            {
                var project = new Project(DataDir + "Project1.mpp");
                var options = GetSaveOptions(1);
                project.Save(OutDir + "document_out.html", options);
            }

            public void CssSaving(CssSavingArgs args)
            {
                if (!Directory.Exists(OutDir + "css/"))
                {
                    Directory.CreateDirectory(OutDir + "css/");
                }

                var stream = new FileStream(OutDir + "css/" + args.FileName, FileMode.Create);
                args.Stream = stream;
                args.KeepStreamOpen = false;
                args.Uri = OutDir + "css/" + args.FileName;
            }

            public void FontSaving(FontSavingArgs args)
            {
                if (!Directory.Exists(OutDir + "fonts/"))
                {
                    Directory.CreateDirectory(OutDir + "fonts/");
                }

                var stream = new FileStream(OutDir + "fonts/" + args.FileName, FileMode.Create);
                args.Stream = stream;
                args.KeepStreamOpen = false;
                args.Uri = OutDir + "fonts/" + args.FileName;
            }

            public void ImageSaving(ImageSavingArgs args)
            {
                if (!Directory.Exists(OutDir + "resources/"))
                {
                    Directory.CreateDirectory(OutDir + "resources/");
                }

                if (!Directory.Exists(OutDir + "resources/nestedResources/"))
                {
                    Directory.CreateDirectory(OutDir + "resources/nestedResources/");
                }

                if (args.FileName.EndsWith("png"))
                {
                    var stream1 = new FileStream(OutDir + "resources/nestedResources/" + args.FileName, FileMode.Create);
                    args.Stream = stream1;
                    args.KeepStreamOpen = false;
                    args.Uri = OutDir + "resources/" + args.FileName;

                    // args.NestedUri = dataDir + "nestedResources/" + args.FileName;
                }
                else
                {
                    var stream2 = new FileStream(OutDir + "resources/" + args.FileName, FileMode.Create);
                    args.Stream = stream2;
                    args.KeepStreamOpen = false;
                    args.Uri = OutDir + "resources/" + args.FileName;
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

        // ExEnd
    }
}