Imports System
Imports Aspose.Tasks

'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx

Namespace Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects
    Public Class ReadVBAProjectInformation
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Projects()

            ' loading project file
            Dim project As New Project(dataDir & Convert.ToString("VbaProject1.mpp"))

            Dim vbaProject As VbaProject = project.VbaProject

            Console.WriteLine("VbaProject.Name " & vbaProject.Name)
            Console.WriteLine("VbaProject.Description " & vbaProject.Description)
            Console.WriteLine("VbaProject.CompilationArguments" & vbaProject.CompilationArguments)
            Console.WriteLine("VbaProject.HelpContextId" & vbaProject.HelpContextId)

        End Sub
    End Class
End Namespace