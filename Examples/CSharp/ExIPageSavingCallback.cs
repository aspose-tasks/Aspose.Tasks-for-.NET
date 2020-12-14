using System;

namespace Aspose.Tasks.Examples.CSharp
{
    using System.Collections.Generic;
    using System.IO;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExIPageSavingCallback : ApiExampleBase
    {
        // ExStart:UsePageSavingCallbackToSavePageToSeparateStreams
        // ExFor: IPageSavingCallback
        // ExFor: IPageSavingCallback.PageSaving(PageSavingArgs)
        // ExFor: IPageSavingCallback.OnFinish
        // ExSummary: Shows how to save multi page document to user-provided streams using page saving callback.
        [Test] 
        public void UsePageSavingCallbackToSavePageToSeparateStreams()
        {
            var project = new Project(DataDir + "Homemoveplan.mpp");
            
            var imageSaveOptions = new ImageSaveOptions(SaveFileFormat.PNG);
            
            var callback = new CustomPageSavingCallback();
            imageSaveOptions.PageSavingCallback = callback;
            imageSaveOptions.SaveToSeparateFiles = true;
            project.Save(Stream.Null, imageSaveOptions);

            foreach (var streams in callback.PageStreams)
            {
                // process each page stream
            }
        }

        private sealed class CustomPageSavingCallback : IPageSavingCallback
        {
            public List<MemoryStream> PageStreams { get; } = new List<MemoryStream>();

            public void PageSaving(PageSavingArgs args)
            {
                var memoryStream = new MemoryStream();
                args.Stream = memoryStream;
                args.KeepStreamOpen = false;
                this.PageStreams.Add(memoryStream);
            }

            public void OnFinish()
            {
            }
        }

        // ExEnd:UsePageSavingCallbackToSavePageToSeparateStreams
    }
}
