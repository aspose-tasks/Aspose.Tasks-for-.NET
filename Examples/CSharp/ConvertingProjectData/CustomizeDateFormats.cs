/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    using System;

    using Aspose.Tasks.Saving;

    internal class CustomizeDateFormats
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:CustomizeDateFormats
            //ExFor: DateFormat 
            //ExFor: Prj.StartDate 
            //ExFor: Prj.DateFormat 
            //ExSummary: Shows how to customize date format of all dates in the project to be exported. 
            var project = new Project(dataDir + "CreateProject2.mpp");
            project.Set(Prj.StartDate, new DateTime(2014, 9, 22));
        
            // By default project.DateFormat == DateFormat.Date_ddd_mm_dd_yy (Mon 09/22/14) customize DateFormat (September 22, 2014)
            project.Set(Prj.DateFormat, DateFormat.DateMmmmDdYyyy);
            project.Save(dataDir + "CustomizeDateFormats1_out.pdf", SaveFileFormat.PDF);

            // Export to date format 19/07/2016
            project.Set(Prj.DateFormat, DateFormat.DateDdMmYyyy);
            project.Save(dataDir + "CustomizeDateFormats2_out.pdf", SaveFileFormat.PDF);
            //ExEnd:CustomizeDateFormats
        }
    }
}