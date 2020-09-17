namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Security.Cryptography;
    using System.Security.Cryptography.X509Certificates;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExPdfDigitalSignatureDetails : ApiExampleBase
    {
        [Test]
        public void WorkWithPdfDigitalSignatureDetails()
        {
            try
            {
                // ExStart
                // ExFor: PdfDigitalSignatureDetails
                // ExFor: PdfDigitalSignatureDetails.#ctor(X509Certificate2,String,String,DateTime,PdfDigitalSignatureHashAlgorithm)
                // ExFor: PdfDigitalSignatureDetails.Certificate
                // ExFor: PdfDigitalSignatureDetails.HashAlgorithm
                // ExFor: PdfDigitalSignatureDetails.Location
                // ExFor: PdfDigitalSignatureDetails.Reason
                // ExFor: PdfDigitalSignatureDetails.SignatureDate
                // ExFor: PdfDigitalSignatureHashAlgorithm
                // ExSummary: Shows how to work with PDF digital signature details.
                var project = new Project(DataDir + "CreateProject2.mpp");
            
                var options = new PdfSaveOptions();

                var certificate = new X509Certificate2();
            
                // create PDF signature details
                var signatureDetails = new PdfDigitalSignatureDetails(
                    // specify certificate
                    certificate, 
                    // specify a reason of signing
                    "reason",
                    // specify a location of signing
                    "location", 
                    // specify a date of signing
                    new DateTime(2019, 1, 1), 
                    // specify a hash algorithm of signing
                    PdfDigitalSignatureHashAlgorithm.Sha1);

                Console.WriteLine("Certificate: " + signatureDetails.Certificate);
                Console.WriteLine("Reason: " + signatureDetails.Reason);
                Console.WriteLine("Location: " + signatureDetails.Location);
                Console.WriteLine("Signature Date: " + signatureDetails.SignatureDate);
                Console.WriteLine("Hash Algorithm: " + signatureDetails.HashAlgorithm);

                // set digital signature details
                options.DigitalSignatureDetails = signatureDetails;
            
                // save the project with specified encryption details
                project.Save(OutDir + "WorkWithPdfEncryptionDetails_out.pdf", options);
                // ExEnd
            }
            catch (CryptographicException)
            {
            }
        }
    }
}