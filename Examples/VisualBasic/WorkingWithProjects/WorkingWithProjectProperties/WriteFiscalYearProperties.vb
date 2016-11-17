Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks
Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects.WorkingWithProjectProperties
    Public Class WriteFiscalYearProperties
        Public Shared Sub Run()
            Try
                ' ExStart: WriteFiscalYearProperties
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

                ' Create a project instance
                Dim project As New Project(dataDir & "WriteFiscalYearProperties.mpp")

                ' Set fiscal year properties
                project.[Set](Prj.FyStartDate, Month.July)
                project.[Set](Prj.FiscalYearStart, True)
                project.Save(dataDir & "WriteFiscalYearProperties_out.mpp", SaveFileFormat.MPP)
                'ExEnd: WriteFiscalYearProperties
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace