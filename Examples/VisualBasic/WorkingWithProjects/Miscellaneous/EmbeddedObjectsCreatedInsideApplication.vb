Imports System.Collections.Generic
Imports System.IO

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects.Miscellaneous
    Public Class EmbeddedObjectsCreatedInsideApplication
        Public Shared Sub Run()
            Try
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

                ' ExStart:EmbeddedObjectsCreatedInsideApplication
                Dim fileFormatExt As IDictionary(Of String, String) = New Dictionary(Of String, String)()
                fileFormatExt.Add("RTF", "_rtfFile_out.rtf")
                fileFormatExt.Add("MSWordDoc", "_wordFile_out.docx")
                fileFormatExt.Add("ExcelML12", "_excelFile_out.xlsx")

                Dim project As New Project(dataDir & Convert.ToString("Embedded.mpp"))

                For Each oleObject As OleObject In project.OleObjects
                    Dim name As String = oleObject.ToString()
                    If Not String.IsNullOrEmpty(oleObject.FileFormat) AndAlso fileFormatExt.ContainsKey(oleObject.FileFormat) Then
                        Dim path As String = (dataDir & Convert.ToString("EmbeddedContent_")) + fileFormatExt(oleObject.FileFormat)
                        Using fileStream As New FileStream(path, FileMode.Create)
                            fileStream.Write(oleObject.Content, 0, oleObject.Content.Length)
                        End Using
                    End If
                Next
                ' ExEnd:EmbeddedObjectsCreatedInsideApplication
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace