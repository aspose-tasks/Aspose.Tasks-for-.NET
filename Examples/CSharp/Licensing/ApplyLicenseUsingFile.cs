namespace Aspose.Tasks.Examples.CSharp.Licensing
{
    using System;

    internal class ApplyLicenseUsingFile
    {
        public static void Run()
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
    }
}
