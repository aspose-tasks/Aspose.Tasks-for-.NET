namespace Aspose.Tasks.Examples.CSharp.Licensing
{
    using System.IO;

    internal class ApplyLicenseUsingStream
    {
        public static void Run()
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
    }
}
