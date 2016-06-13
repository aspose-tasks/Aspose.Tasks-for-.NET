Imports System
Imports Examples.VisualBasic
Imports VisualBasic
Imports Aspose.Tasks

'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx

Namespace CSharp.Projects
    Public Class ReadModulesInformation
        Public Shared Sub Run()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Projects()

            Dim project As New Project(dataDir & Convert.ToString("VbaProject1.mpp"))

            Dim vbaProject As VbaProject = project.VbaProject
            Console.WriteLine("Total Modules Count: " & vbaProject.Modules.Count)

            Dim vbaModule As IVbaModule = vbaProject.Modules.ToList()(0)
            Console.WriteLine("Module Name: " & vbaModule.Name)
            Console.WriteLine("Source Code: " & vbaModule.SourceCode)
        End Sub
    End Class
End Namespace