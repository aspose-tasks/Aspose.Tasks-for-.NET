Imports System.IO

Namespace Licensing
    Public Class ApplyLicenseUsingStream
        Public Shared Sub Run()
            ' ExStart:ApplyLicenseUsingStream
            Dim license As Aspose.Tasks.License = New Aspose.Tasks.License()
            Dim myStream As New FileStream("Aspose.Tasks.lic", FileMode.Open)
            license.SetLicense(myStream)
            ' ExEnd:ApplyLicenseUsingStream
        End Sub
    End Class
End Namespace