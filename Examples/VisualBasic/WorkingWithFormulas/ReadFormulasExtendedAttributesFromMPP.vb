'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithFormulas
    Public Class ReadFormulasExtendedAttributesFromMPP
        Public Shared Sub Run()
            ' ExStart:ReadFormulasExtendedAttributesFromMPP
            ' Create project instance
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)
            Dim proj As New Project(dataDir & Convert.ToString("ReadFormulas.mpp"))

            ' Read extended attribute formula
            Dim attr As ExtendedAttributeDefinition = proj.ExtendedAttributes(0)
            Console.WriteLine("Attribute Formula: " + attr.Formula)
            ' ExEnd:ReadFormulasExtendedAttributesFromMPP
        End Sub
    End Class
End Namespace