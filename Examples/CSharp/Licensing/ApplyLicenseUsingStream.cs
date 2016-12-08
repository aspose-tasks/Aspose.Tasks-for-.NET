using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.Licensing
{
    class ApplyLicenseUsingStream
    {
        public static void Run()
        {
            // ExStart:ApplyLicenseUsingStream
            Aspose.Tasks.License license = new Aspose.Tasks.License();
            FileStream myStream = new FileStream("Aspose.Tasks.lic", FileMode.Open);
            license.SetLicense(myStream);
            // ExEnd:ApplyLicenseUsingStream
        }
    }
}
