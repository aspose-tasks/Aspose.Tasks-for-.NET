'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace ModifyingCreatedProject
    Public Class ReadFormulasInLocalAndEnterpriseExtendedAttributesFromMPPFile
        Public Shared Sub Run()
            ' ExStart:ReadFormulasInLocalAndEnterpriseExtendedAttributesFromMPPFile

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingCreatedProject()
            Dim proj As New Project(dataDir & Convert.ToString("Project1.mpp"))
            ' Attached test mpp
            Dim attr As ExtendedAttributeDefinition = proj.ExtendedAttributes(0)
            Console.WriteLine("Attribute Formula: " + attr.Formula)
            ' ExEnd:ReadFormulasInLocalAndEnterpriseExtendedAttributesFromMPPFile
        End Sub
    End Class
End Namespace