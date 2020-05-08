namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExPdfEncryptionDetails : ApiExampleBase
    {
        [Test]
        public void WorkWithPdfEncryptionDetails()
        {
            // ExStart
            // ExFor: PdfEncryptionDetails
            // ExFor: PdfEncryptionDetails.#ctor(String,String,PdfEncryptionAlgorithm)
            // ExFor: PdfEncryptionDetails.EncryptionAlgorithm
            // ExFor: PdfEncryptionDetails.OwnerPassword
            // ExFor: PdfEncryptionDetails.Permissions
            // ExFor: PdfEncryptionDetails.UserPassword
            // ExFor: PdfPermissions
            // ExFor: PdfEncryptionAlgorithm
            // ExSummary: Shows how to use specify PDF encryption details while saving a project as PDF file.
            var project = new Project(DataDir + "CreateProject2.mpp");

            // lets specify encryption details  
            var encryptionDetails = new PdfEncryptionDetails(
                // specify user password
                "userPassword", 
                // specify owner password
                "ownerPassword", 
                // specify encryption algorithm
                PdfEncryptionAlgorithm.RC4_128);

            // specify permissions
            encryptionDetails.Permissions = PdfPermissions.ModifyContents | PdfPermissions.ModifyAnnotations;
            
            // show user and owner passwords
            Console.WriteLine("User Password: " + encryptionDetails.UserPassword);
            Console.WriteLine("Owner Password: " + encryptionDetails.OwnerPassword);
            // show encryption mode: RC4_40 or RC4_128
            Console.WriteLine("Encryption Algorithm: " + encryptionDetails.EncryptionAlgorithm);
            Console.WriteLine("Permissions: " + encryptionDetails.Permissions);

            var options = new PdfSaveOptions
            {
                EncryptionDetails = encryptionDetails
            };
            
            // save the project with specified encryption details
            project.Save(OutDir + "WorkWithPdfEncryptionDetails_out.pdf", options);

            // ExEnd
        }
    }
}