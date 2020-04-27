namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.IO;
    using NUnit.Framework;

    [TestFixture]
    public class ExLicense : ApiExampleBase
    {
        [Test]
        public void ApplyLicenseUsingFile()
        {
            try
            {
                // ExStart:ApplyLicenseUsingFile
                // ExFor: License
                // ExFor: License.#ctor
                // ExFor: License.SetLicense(String)
                // ExSummary: Shows how to apply a license of Aspose.Tasks.
                var license = new License();
                license.SetLicense("Aspose.Tasks.lic");

                // ExEnd:ApplyLicenseUsingFile
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
                // ExStart:ApplyLicenseUsingStream
                // ExFor: License.SetLicense(Stream)
                // ExSummary: Shows how to apply a license of Aspose.Tasks read from <see cref="System.IO.FileStream" />.
                var license = new License();
                using (var stream = new FileStream("Aspose.Tasks.lic", FileMode.Open))
                {
                    license.SetLicense(stream);
                }

                // ExEnd:ApplyLicenseUsingStream
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The license file is not found.");
            }
        }
    }
}