using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.Licensing
{
    class ApplyLicenseUsingFile
    {
        public static void Run()
        {
            // ExStart:ApplyLicenseUsingFile
            Aspose.Tasks.License license = new Aspose.Tasks.License();
            license.SetLicense("Aspose.Tasks.lic");
            // ExEnd:ApplyLicenseUsingFile
        }
    }
}
