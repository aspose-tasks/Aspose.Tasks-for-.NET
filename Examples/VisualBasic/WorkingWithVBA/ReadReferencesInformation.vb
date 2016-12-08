Imports System
Imports Aspose.Tasks

'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx

Namespace WorkingWithVBA
    Public Class ReadReferencesInformation
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:ReadReferencesInformation
            Dim project As New Project(dataDir & Convert.ToString("VbaProject1.mpp"))

            Dim vbaProject As VbaProject = project.VbaProject
            Dim references As VbaReferenceCollection = vbaProject.References
            Console.WriteLine("Reference count ", references.Count)

            Dim reference As VbaReference = vbaProject.References.ToList()(0)
            Console.WriteLine("Identifier: " & reference.LibIdentifier)
            Console.WriteLine("Name: " & reference.Name)

            reference = vbaProject.References.ToList()(1)
            Console.WriteLine("Identifier: " & reference.LibIdentifier)
            Console.WriteLine("Name: " & reference.Name)

            reference = vbaProject.References.ToList()(2)
            Console.WriteLine("Identifier: " & reference.LibIdentifier)
            Console.WriteLine("Name: " & reference.Name)
            ' ExEnd:ReadReferencesInformation
        End Sub
    End Class
End Namespace

