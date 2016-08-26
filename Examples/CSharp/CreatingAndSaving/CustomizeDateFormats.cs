using System;
using Aspose.Tasks.Saving;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.CreatingAndSaving
{
    public class CustomizeDateFormats
    {
        public static void Run()
        {
            // ExStart:CustomizeDateFormats

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreatingAndSaving();

            Project project = new Project(dataDir + "Project2.mpp");
            project.Set(Prj.StartDate, new DateTime(2014, 9, 22));
        
            // By default project.DateFormat == DateFormat.Date_ddd_mm_dd_yy (Mon 09/22/14) customize DateFormat (September 22, 2014)
            project.Set(Prj.DateFormat, DateFormat.DateMmmmDdYyyy);
            project.Save(dataDir + "CustomizeDateFormats1_out.pdf", SaveFileFormat.PDF);

            // Export to date format 19/07/2016
            project.Set(Prj.DateFormat, DateFormat.DateDdMmYyyy);
            project.Save(dataDir + "CustomizeDateFormats2_out.pdf", SaveFileFormat.PDF);
            // ExEnd:CustomizeDateFormats
        }
    }
}