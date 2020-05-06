namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExDateFormat : ApiExampleBase
    {
        [Test]
        public void WorkWithDateFormat()
        {
            // ExStart:CustomizeDateFormats
            // ExFor: DateFormat
            // ExFor: DateFormat.Custom
            // ExFor: DateFormat.DateDd
            // ExFor: DateFormat.DateDddDd
            // ExFor: DateFormat.DateDddHhMmAM
            // ExFor: DateFormat.DateDddMmDd
            // ExFor: DateFormat.DateDddMmDdYy
            // ExFor: DateFormat.DateDddMmDdYyHhMmAM
            // ExFor: DateFormat.DateDddMmmDd
            // ExFor: DateFormat.DateDddMmmDdYyy
            // ExFor: DateFormat.DateDdMmYyyy
            // ExFor: DateFormat.DateHhMmAm
            // ExFor: DateFormat.DateMmDd
            // ExFor: DateFormat.DateMmDdYy
            // ExFor: DateFormat.DateMmDdYyHhMmAM
            // ExFor: DateFormat.DateMmDdYyyy
            // ExFor: DateFormat.DateMmmDd
            // ExFor: DateFormat.DateMmmDdHhMmAM
            // ExFor: DateFormat.DateMmmDdYyy
            // ExFor: DateFormat.DateMmmmDd
            // ExFor: DateFormat.DateMmmmDdYyyy
            // ExFor: DateFormat.DateMmmmDdYyyyHhMmAM
            // ExFor: DateFormat.DateWwwDd
            // ExFor: DateFormat.DateWwwDdYyHhMmAm
            // ExFor: DateFormat.Default
            // ExSummary: Shows how to customize date format of all dates in the project to be exported. 
            var project = new Project(DataDir + "CreateProject2.mpp");
            project.Set(Prj.StartDate, new DateTime(2014, 9, 22));

            // By default project.DateFormat == DateFormat.Date_ddd_mm_dd_yy (Mon 09/22/14) customize DateFormat (September 22, 2014)
            project.Set(Prj.DateFormat, DateFormat.DateMmmmDdYyyy);
            project.Save(OutDir + "CustomizeDateFormats1_out.pdf", SaveFileFormat.PDF);

            // Export to date format 19/07/2016
            project.Set(Prj.DateFormat, DateFormat.DateDdMmYyyy);
            project.Save(OutDir + "CustomizeDateFormats2_out.pdf", SaveFileFormat.PDF);

            // ExEnd:CustomizeDateFormats
        }
    }
}