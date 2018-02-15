using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.Articles
{
    class RenderDifferentPresentationFormatsToXAML
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:RenderDifferentPresentationFormatsToXAML
            Project project = new Project(dataDir + "Project2.mpp");

            PresentationFormat presentationFormat = PresentationFormat.GanttChart;
            string resultFile = "RenderDifferentPresentationFormatsToXAML_" + presentationFormat + "_out.xaml";
            SaveOptions options = new XamlOptions();
            options.PresentationFormat = presentationFormat;

            project.Save(dataDir + resultFile, options);
            // ExEnd:RenderDifferentPresentationFormatsToXAML
        }
    }
}
