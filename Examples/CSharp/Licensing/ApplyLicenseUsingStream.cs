namespace Aspose.Tasks.Examples.CSharp.Licensing
{
    using System;
    using System.IO;

    internal class ApplyLicenseUsingStream
    {
        public static void Run()
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
    }
}
