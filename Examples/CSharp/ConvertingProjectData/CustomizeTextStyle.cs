/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    using System.Collections.Generic;
    using System.Drawing;

    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    internal class CustomizeTextStyle
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:CustomizeTextStyle
            //ExFor: TextStyle
            //ExFor: TextItemType
            //ExFor: TextStyle.FontStyle
            //ExFor: SaveOptions.TextStyles
            //ExSummary: Shows how to customize text styles which are used to style different text items in a project.
            var project = new Project(dataDir + "CreateProject2.mpp");
            SaveOptions options = new PdfSaveOptions();
            options.PresentationFormat = PresentationFormat.ResourceSheet;

            var style = new TextStyle();
            style.Color = Color.OrangeRed;
            style.FontStyle = FontStyle.Bold;
            style.FontStyle |= FontStyle.Italic;
            style.ItemType = TextItemType.OverallocatedResources;

            options.TextStyles = new List<TextStyle>();
            options.TextStyles.Add(style);
            project.Save(dataDir + "CustomizeTextStyle_out.pdf", options);
            //ExEnd:CustomizeTextStyle
        }
    }
}