namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.IO;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExLicense : ApiExampleBase
    {
        [Test]
        public void ApplyLicenseUsingFile()
        {
            try
            {
                //ExStart:ApplyLicenseUsingFile
                //ExFor: License
                //ExFor: License.SetLicense(String)
                //ExSummary: Shows how to apply a license of Aspose.Tasks.
                var license = new License();
                license.SetLicense("Aspose.Tasks.lic");
                //ExEnd:ApplyLicenseUsingFile
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("The license file is not found.");
            }
        }
        
        [Test]
        public void ApplyLicenseUsingStream()
        {
            try
            {
                //ExStart:ApplyLicenseUsingStream
                //ExFor: License.SetLicense(Stream)
                //ExSummary: Shows how to apply a license of Aspose.Tasks read from <see cref="System.IO.FileStream" />.
                var license = new License();
                using (var stream = new FileStream("Aspose.Tasks.lic", FileMode.Open))
                {
                    license.SetLicense(stream);
                }
                //ExEnd:ApplyLicenseUsingStream
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The license file is not found.");
            }
        }
        
        [Test]
        public void EvaluationDateTimeLimitations()
        {
            //ExStart:DateTimeLimitations
            //ExFor: Project.Save(String,SaveFileFormat)
            //ExSummary: Shows that project' dates are reset in an evaluation mode.
            var project = new Project();

            // Define Tasks
            var task1 = project.RootTask.Children.Add("Task1");
            task1.Set(Tsk.ActualStart, DateTime.Parse("06-Apr-2010"));

            var task2 = project.RootTask.Children.Add("Task2");
            task2.Set(Tsk.ActualStart, DateTime.Parse("10-Apr-2010"));

            project.Save(OutDir + "EvaluationDateTimeLimitations_out.xml", SaveFileFormat.XML);
            //ExEnd:DateTimeLimitations
        }
    }
}