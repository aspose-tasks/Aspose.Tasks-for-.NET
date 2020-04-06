namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExDateFormat : ApiExampleBase
    {
        [Test]
        public void CustomizeDateFormats()
        {
            //ExStart:CustomizeDateFormats
            //ExFor: DateFormat 
            //ExSummary: Shows how to customize date format of all dates in the project to be exported. 
            var project = new Project(DataDir + "CreateProject2.mpp");
            project.Set(Prj.StartDate, new DateTime(2014, 9, 22));
        
            // By default project.DateFormat == DateFormat.Date_ddd_mm_dd_yy (Mon 09/22/14) customize DateFormat (September 22, 2014)
            project.Set(Prj.DateFormat, DateFormat.DateMmmmDdYyyy);
            project.Save(OutDir + "CustomizeDateFormats1_out.pdf", SaveFileFormat.PDF);

            // Export to date format 19/07/2016
            project.Set(Prj.DateFormat, DateFormat.DateDdMmYyyy);
            project.Save(OutDir + "CustomizeDateFormats2_out.pdf", SaveFileFormat.PDF);
            //ExEnd:CustomizeDateFormats
        }
    }
}