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
            //ExFor: Tsk.ActualStart
            //ExFor: Tsk.ActualFinish
            //ExSummary: Shows that project' dates are reset in an evaluation mode.
            var project = new Project();

            // create new tasks
            var task1 = project.RootTask.Children.Add("Task1");
            task1.Set(Tsk.ActualStart, new DateTime(2010, 4, 10, 8, 0, 0));
            task1.Set(Tsk.ActualFinish, new DateTime(2010, 4, 10, 17, 0, 0));

            var task2 = project.RootTask.Children.Add("Task2");
            task2.Set(Tsk.ActualStart, new DateTime(2010, 4, 10, 8, 0, 0));
            task2.Set(Tsk.ActualFinish, new DateTime(2010, 4, 10, 17, 0, 0));

            project.Save(OutDir + "EvaluationDateTimeLimitations_out.xml", SaveFileFormat.XML);
            //ExEnd:DateTimeLimitations
        }
    }
}