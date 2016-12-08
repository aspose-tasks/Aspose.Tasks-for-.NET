Imports System.IO
Imports Aspose.Tasks
Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects
    Public Class SaveProjectDataAsTemplate
        Public Shared Sub Run()
            Try
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

                ' ExStart:SaveProjectDataAsTemplate
                Const projectName As String = "Project2.mpp"
                Dim project1 As New Project(dataDir & projectName)
                Dim projectFileInfo As ProjectFileInfo = Project.GetProjectFileInfo(dataDir & projectName)

                If FileFormat.MPP14 = projectFileInfo.ProjectFileFormat Then
                    Console.WriteLine("Project file format is ok")
                End If

                Dim options As New SaveTemplateOptions()
                options.RemoveActualValues = True
                options.RemoveBaselineValues = True

                Const templateName As String = "SaveProjectDataAsTemplate_out.mpt"
                project1.SaveAsTemplate(dataDir & templateName)

                Dim templateFileInfo As ProjectFileInfo = Project.GetProjectFileInfo(dataDir & templateName)
                If FileFormat.MPT14 = templateFileInfo.ProjectFileFormat Then
                    Console.WriteLine("Template FileFormat is ok")
                End If
                ' ExEnd:SaveProjectDataAsTemplate
            Catch ex As NotSupportedException
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace