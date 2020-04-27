namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using NUnit.Framework;

    [TestFixture]
    public class ExMetered : ApiExampleBase
    {
        [Test]
        [SuppressMessage("ReSharper", "UnusedVariable", Justification = "Reviewed. Suppression is OK here.")]
        public void WorkWithMeteredLicense()
        {
            // ExStart:WorkWithMeteredLicense
            // ExFor: Metered
            // ExFor: Metered.ResetMeteredKey
            // ExFor: Metered.SetMeteredKey(String,String)
            // ExSummary: Shows how to use <see cref="Aspose.Tasks.Metered" /> license type with Aspose.Tasks.

            // Let's use metered license (see https://purchase.aspose.com/faqs/licensing/metered)
            // set metered licence
            var metered = new Metered();
            metered.SetMeteredKey("<public key>", "<private key>");

            var project = new Project(DataDir + "Project2.mpp");
            Console.WriteLine("Project Name: " + project.Get(Prj.Name));

            // ...
            // work with project...
            // ...

            // lately the user can reset a metered and stop counting of bytes
            metered.ResetMeteredKey();

            // ExEnd:WorkWithMeteredLicense
        }
    }
}