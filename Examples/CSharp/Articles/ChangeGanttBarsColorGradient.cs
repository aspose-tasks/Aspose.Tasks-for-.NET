using Aspose.Tasks.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.Articles
{
    class ChangeGanttBarsColorGradient
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:ChangeGanttBarsColorGradient
            Project project = new Project(dataDir + "Project2.mpp");
            
            SaveOptions options = new XamlOptions();
            options.UseGradientBrush = false;
            project.Save(dataDir + "ChangeGanttBarsColorGradient_Solid_out.xaml", options);

            options.UseGradientBrush = true;
            project.Save(dataDir + "ChangeGanttBarsColorGradient_Gradient_out.xaml", options);
            // ExEnd:ChangeGanttBarsColorGradient
        }
    }
}
